using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShapeContract
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public void OnPropertyChanged(string name)
        {
            var propertChanged = PropertyChanged;
            if (propertChanged != null)
            {
                propertChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object> _ParemeterisedCommand;
        private readonly Action _Command;
        private readonly Func<bool> _CanExecuted;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> command, Func<bool> canExecuted)
        {
            _CanExecuted = canExecuted;
            _ParemeterisedCommand = command;
        }

        public RelayCommand(Action command, Func<bool> canExecuted = null)
        {
            _Command = command;
            _CanExecuted = () => true;
        }


        public Action<object> ParemeterisedCommand => _ParemeterisedCommand;

        public bool CanExecute(object parameter = null)
        {
            return _CanExecuted();
        }

        public void Execute(object parameter = null)
        {
            if (parameter == null)
                _Command();
            else
                _ParemeterisedCommand(parameter);
        }

    }
}
