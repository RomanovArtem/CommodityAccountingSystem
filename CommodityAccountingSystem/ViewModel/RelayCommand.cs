using System;
using System.Windows.Input;

namespace CommodityAccountingSystem.View
{
    #region RelayCommand
    public class RelayCommand : ICommand
    {
        #region Fields
        /// <summary>
        /// метод выполнения
        /// </summary>
        Action _TargetExecuteMethod;

        /// <summary>
        /// может выполниться метод?
        /// </summary>
        Func<bool> _TargetCanExecuteMethod;
        #endregion

        #region Constructors
        public RelayCommand(Models.Product editProduct, Action executeMethod)
        {
            _TargetExecuteMethod = executeMethod;
        }

        public RelayCommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            _TargetExecuteMethod = executeMethod;
            _TargetCanExecuteMethod = canExecuteMethod;
        }
        #endregion

        #region Commands
        /// <summary>
        /// определяет, может ли команда выполняться
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        bool ICommand.CanExecute(object parameter)
        {
            if (_TargetCanExecuteMethod != null)
            {
                return _TargetCanExecuteMethod();
            }
            if (_TargetExecuteMethod != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///  выполняет логику команды
        /// </summary>
        /// <param name="parameter"></param>
        void ICommand.Execute(object parameter)
        {
            if (_TargetExecuteMethod != null)
            {
                _TargetExecuteMethod();
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// событие вызывается при изменении условий, указывающий, может ли команда выполняться
        /// </summary>
        public event EventHandler CanExecuteChanged;
        #endregion

        #region Methods
        /// <summary>
        /// Может выполнять изменения ?
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }
        #endregion
    }
    #endregion

    #region RelayCommand<T>
    public class RelayCommand<T> : ICommand
    {
        #region Fields
        /// <summary>
        /// метод выполнения
        /// </summary>
        Action<T> _TargetExecuteMethod;
        /// <summary>
        /// может выполниться метод?
        /// </summary>
        Func<T, bool> _TargetCanExecuteMethod;
        #endregion

        #region Constructors
        public RelayCommand(Action<T> executeMethod)
        {
            _TargetExecuteMethod = executeMethod;
        }

        public RelayCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
        {
            _TargetExecuteMethod = executeMethod;
            _TargetCanExecuteMethod = canExecuteMethod;
        }
        #endregion

        #region Commands
        /// <summary>
        /// определяет, может ли команда выполняться
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        bool ICommand.CanExecute(object parameter)
        {
            if (_TargetCanExecuteMethod != null)
            {
                T tparm = (T)parameter;
                return _TargetCanExecuteMethod(tparm);
            }
            if (_TargetExecuteMethod != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// выполняет логику команды
        /// </summary>
        /// <param name="parameter"></param>
        void ICommand.Execute(object parameter)
        {
            _TargetExecuteMethod?.Invoke((T)parameter);
        }
        #endregion

        #region Events
        /// <summary>
        /// событие вызывается при изменении условий, указывающий, может ли команда выполняться
        /// </summary>
        public event EventHandler CanExecuteChanged;
        #endregion

        #region Methods
        /// <summary>
        /// Может выполнять изменения ?
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }
        #endregion
    }
    #endregion
}