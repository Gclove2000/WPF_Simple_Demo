using BlankApp1.ViewModels;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlankApp1.Views
{
    /// <summary>
    /// Memo.xaml 的交互逻辑
    /// </summary>
    public partial class Memo : UserControl
    {

        public MemoViewModel viewModel { get; set; }

        public string UserName
        {
            get { return viewModel.UserName; }
            set
            {
                viewModel.UserName = value;
            }
        }

        public Memo()
        {
            viewModel = new MemoViewModel();
            InitializeComponent();

            this.DataContext = viewModel;

        }
    }
}
