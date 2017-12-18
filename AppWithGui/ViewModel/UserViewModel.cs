using AppWithGui.Model;
using System.Collections.ObjectModel;

namespace AppWithGui.ViewModel
{
    internal class UserViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        public User SelectedUser { get; set; }

        public UserViewModel()
        {
            LoadUsers();
            DeleteCommand = new RelayCommand(o => OnDelete(SelectedUser), o => CanDelete(SelectedUser));
        }

        private void LoadUsers()
        {
            var users = new ObservableCollection<User>
            {
                new User { FirstName = "Eric", LastName = "Backhage" },
                new User { FirstName = "Onkel", LastName = "Tom" },
                new User { FirstName = "Sten", LastName = "Strong" },
                new User { FirstName = "Max", LastName = "Power" },
            };

            Users = users;
        }

        private void OnDelete(object user)
        {
            var u = user as User;
            Users.Remove(u);
        }

        private bool CanDelete(object user)
        {
            var u = user as User;
            return u != null;
        }
    }
}
