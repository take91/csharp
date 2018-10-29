using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CommandPattern
{
    class RelayCommand : ICommand
    {
        #region Variables
        Func<object, bool> canExcute;
        Action<object> excuteAction;
        #endregion

        #region Construction/Initialization
        public RelayCommand(Action<object> excuteAction) : this(excuteAction, null)
        {

        }

        public RelayCommand(Action<object> excuteAction, Func<object, bool> canExcute)
        {
            this.excuteAction = excuteAction ?? throw new ArgumentNullException("Execute Action was null for ICommanding Operation.");
            this.canExcute = canExcute;
        }
        #endregion

        #region ICommand Member
        public bool CanExecute(object param)
        {
            if (param?.ToString().Length == 0) return false;
            bool result = this.canExcute == null ? true : this.canExcute.Invoke(param);
            return result;
        }

        public void Execute(object param)
        {
            this.excuteAction.Invoke(param);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
        #endregion
    }
}
