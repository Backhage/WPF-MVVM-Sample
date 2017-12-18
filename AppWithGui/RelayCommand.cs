using System;
using System.Windows.Input;

namespace AppWithGui
{
    internal class RelayCommand : ICommand
    {
        private readonly Action<object> command;
        private readonly Predicate<object> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> command) : this(command, null)
        {
        }

        public RelayCommand(Action<object> command, Predicate<object> canExecute)
        {
            this.command = command ?? throw new ArgumentNullException(nameof(command));
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            command.Invoke(parameter);
        }
    }
}
