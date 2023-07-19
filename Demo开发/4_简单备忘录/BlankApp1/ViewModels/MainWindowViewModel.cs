using Prism.Commands;
using Prism.Mvvm;
using System.Diagnostics;

namespace BlankApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public DelegateCommand TestCommand { get; set; }

        public MainWindowViewModel()
        {
            TestCommand = new DelegateCommand(() =>
            {
                Debug.WriteLine("我是另一个Command");
            });
        }

    }
}
