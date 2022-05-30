using System;
using System.Windows.Input;

namespace ScreenCapture
{
    internal class RelayCommand : ICommand
    {
        private Action<object> _execute;
        public Func<bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;
            else
            {
                return _canExecute();
            }
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke(parameter);
        }
    }
}
