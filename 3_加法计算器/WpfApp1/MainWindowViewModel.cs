using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private int _num1;

        public int Num1
        {
            get { return _num1; }
            set { _num1 = value; OnPropertyChanged("Num1"); }
        }

        private int _num2;

        public int Num2
        {
            get { return _num2; }
            set { _num2 = value; OnPropertyChanged("Num2"); }
        }

        private int _sum;

        public int Sum
        {
            get { return _sum; }
            set { _sum = value; OnPropertyChanged("Sum"); }
        }


        private void AddBtn()
        {
            Sum = Num1 + Num2;
        }

        private void ClearBtn()
        {
            Sum = 0;
            Num1 = 0;
            Num2 = 0;
        }

        public MyCommand AddCommand { get; set; }

        public MyCommand ClearCommand { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;


        public MainWindowViewModel()
        {
            Num1 = 0;
            Num2 = 0;
            Sum = 0;
            AddCommand = new MyCommand(AddBtn);
            ClearCommand = new MyCommand(ClearBtn);
        }

        /// <summary>
        /// 强制事件通知
        /// </summary>
        /// <param name="propertyName"></param>

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
