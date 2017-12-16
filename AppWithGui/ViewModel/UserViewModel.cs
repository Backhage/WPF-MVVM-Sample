using AppWithGui.Model;
using System.Collections.ObjectModel;

namespace AppWithGui.ViewModel
{
    internal class UserViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public void LoadUsers()
        {
            var users = new ObservableCollection<User>
            {
                new User { FirstName = "Teo", LastName = "Karlsson" },
                new User { FirstName = "Helen", LastName = "Karlsson" },
                new User { FirstName = "Lukas", LastName = "Karlsson" },
                new User { FirstName = "Eric", LastName = "Backhage" }
            };

            Users = users;
        }
    }
}
