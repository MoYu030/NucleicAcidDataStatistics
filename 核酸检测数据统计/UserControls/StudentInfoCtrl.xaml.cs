using System;
using System.Collections.Generic;
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
using 核酸检测数据统计.Common;

namespace 核酸检测数据统计.UserControls
{
    /// <summary>
    /// StudentInfoCtrl.xaml 的交互逻辑
    /// </summary>
    public partial class StudentInfoCtrl : UserControl
    {
        public StudentInfoCtrl(Students stu)
        {
            InitializeComponent();
            stu_Class.Text = stu.Classname;
            stu_Name.Text = stu.Name;
            stu_Status.Text = stu.Msg;
            if (stu_Status.Text == "已做核酸")
                stu_Status.Foreground = Brushes.Green;
            else
                stu_Status.Foreground = Brushes.Red;
        }
    }
}
