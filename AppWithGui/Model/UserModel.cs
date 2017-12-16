using System;
using System.ComponentModel;

namespace AppWithGui.Model
{
    internal class UserModel
    {
    }

    internal class User : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;

        public event PropertyChangedEventHandler PropertyChanged;

        public string FirstName
        {
            get => firstName;
            set
            {
                if (firstName != null && firstName.Equals(value))
                {
                    return;
                }
                firstName = value;
                RaisePropertyChanged(nameof(FirstName));
                RaisePropertyChanged(nameof(FullName));
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (lastName != null && lastName.Equals(value, StringComparison.Ordinal))
                {
                    return;
                }
                lastName = value;
                RaisePropertyChanged(nameof(LastName));
                RaisePropertyChanged(nameof(FullName));
            }
        }

        public string FullName => string.Concat(firstName, " ", lastName);

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
