using MaterialDesignColors.Recommended;
using MiniExcelLibs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using 核酸检测数据统计.Common;
using 核酸检测数据统计.UserControls;

namespace 核酸检测数据统计
{
    /// <summary>
    /// InfoWindow.xaml 的交互逻辑
    /// </summary>
    public partial class InfoWindow : Window
    {
        public InfoWindow(List<Students> arrayList)
        {
            InitializeComponent();
            Load(arrayList);
        }
        List<Classes> classList = new List<Classes>();
        List<Students> stu= new List<Students>();
        Functions ft= new Functions();
        string className="全部";
        string isFinish="全部";
        private void Load(List<Students> arrayList)
        {
            class_item.Items.Clear();
            stu = arrayList;
            IsFinish_item.SelectedIndex = 0;
            //获取老师所带的班级信息
            classList = ft.GetClassInfo(stu);
            class_item.ItemsSource = classList;
            //全体人员数据
            GetStuInfo();
            GetPercent(stu);
        }
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void class_item_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = class_item.SelectedIndex;
            className = classList[i].ClassName;
            GetStuInfo();
        }
        private void IsFinish_item_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
             item =(ListBoxItem) IsFinish_item.SelectedValue ;
            isFinish = item.Content.ToString();
            GetStuInfo();
        }
        List<Students> query=new List<Students>();
        private void GetStuInfo()
        {
             query = stu;
            //System.Windows.Forms.MessageBox.Show(stu.Count().ToString());
            if (className != "全部")
            {
                query = query.Where(t => t.Classname == className).ToList();
                GetPercent(query);
            }
            if (isFinish != "全部")
                query = query.Where(t => t.Msg == isFinish).ToList();
            wrap.Children.Clear();
            //System.Windows.Forms.MessageBox.Show(query.Count().ToString());
            foreach (var db in query)
            {
                wrap.Children.Add(new StudentInfoCtrl(db));
            }

        }
        private void GetPercent(List<Students> students)
        {
            try
            {
                int complete = students.Count(t => t.Msg == "已做核酸");
                int notdone = students.Count(t => t.Msg == "未做核酸");
                complete_txt.Text = complete.ToString();
                notdone_txt.Text = notdone.ToString();
                percent_txt.Text = $"{(complete * 100 / students.Count())}%";
            }
            catch { }
        }

        private void name_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                class_item.ItemsSource = classList.Where(t => t.ClassName.Contains(name_txt.Text));
            }
            catch{}
        }

        private void min_btn_Click(object sender, RoutedEventArgs e)
        {
            WindowState=WindowState.Minimized;
        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void excel_btn_Click(object sender, RoutedEventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog(); 
            sfd.Filter = "Excel表格（*.xlsx）|*.xlsx"; //设置文件类型
            sfd.FilterIndex = 1;            //设置默认文件类型显示顺序             
            sfd.RestoreDirectory = true;//保存对话框是否记忆上次打开的目录         
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK) //点了保存按钮进入 
            {
                if (File.Exists(sfd.FileName))
                    System.Windows.Forms.MessageBox.Show("替换失败，请更换文件名或路径后重试");
                else
                {
                    MiniExcel.SaveAs(sfd.FileName.ToString(), query); //保存文件
                    System.Windows.MessageBox.Show("保存成功");
                }
            }
        }
    }
}
