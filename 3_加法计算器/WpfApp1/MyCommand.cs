using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class MyCommand : ICommand
    {
        Action MyAction;

        public event EventHandler? CanExecuteChanged;

        public MyCommand(Action MyAction)
        {
            this.MyAction = MyAction;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            MyAction();
        }
    }
}
