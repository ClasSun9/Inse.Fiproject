using System;
using System.Windows.Input;

namespace Inse.Fiproject.Wpf.Mvvm
{
    public class RelayCommand : ICommand
    {
        //--------------------  field

        private Action execute;

        private Func<bool> canExecute;

        //--------------------  property

        //  null

        //--------------------  event

        public event EventHandler CanExecuteChanged
        {
            add    { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        //--------------------  function

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            this.execute?.Invoke();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return this.canExecute?.Invoke() ?? true;
        }

        //--------------------  constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecute"></param>
        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
    }

    public class RelayCommand<T> : ICommand
    {
        //--------------------  field

        private Action<T> execute;

        private Func<T, bool> canExecute;

        //--------------------  property

        //  null

        //--------------------  event

        public event EventHandler CanExecuteChanged
        {
            add    { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        //--------------------  function

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            this.execute?.Invoke((T)parameter);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return this.canExecute?.Invoke((T)parameter) ?? true;
        }

        //--------------------  constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecute"></param>
        public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
    }
}
