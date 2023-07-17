using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MainWindowViewModel
    {
        public List<IconClass> M_IconClass { get; set; }

        public IconClass M_Icon { get; set; }

        public string IconUrl = "./Resource/#iconfont";
        public MainWindowViewModel()
        {
            M_Icon = new IconClass()
            {
                Title = "搜索",
                Icon = "\ue645"
            };
            M_IconClass = new List<IconClass> {
                new IconClass()
                {
                    Title="搜索",
                    Icon = "\ue645"
                },
                new IconClass()
                {
                    Title = "闹钟",
                    Icon = "\ue601",
                },
                new IconClass()
                {
                    Title= "日历",
                    Icon = "\ue65b"
                },
                new IconClass()
                {
                    Title = "五角星",
                    Icon = "\ue6b6"
                },
                new IconClass()
                {
                    Title = "灯泡",
                    Icon = "\ue648"
                }
            };
        }
    }

    public class IconClass
    {
        public string Icon { get; set; }

        public string Title { get; set; }
    }
}
