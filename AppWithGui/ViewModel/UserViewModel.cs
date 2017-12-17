using AppWithGui.Model;
using System.Collections.ObjectModel;

namespace AppWithGui.ViewModel
{
    internal class UserViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public UserViewModel()
        {
            LoadUsers();
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
    }
}
