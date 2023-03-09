using Newtonsoft.Json;
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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using 核酸检测数据统计.Common;

namespace 核酸检测数据统计
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            AutoLogin();
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
            // 没有数据的提示    断网 关闭按钮
        }
        string teacher_name="";
        List<Students> arrayList = new List<Students>();
        Thread thread;
        private void start_btn_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("ApplicationUserData.json", name_txt.Text);//实现自动登录
            //判断是否为空
            if(name_txt.Text=="")
            {
                System.Windows.Forms.MessageBox.Show("使用前，记得输入姓名哦");
                return;
            }
            //样式变化
            StyleChanged();
            //委托
            Action callback = () => 
            {           
                App.Current.Dispatcher.Invoke((Action)(() =>
                {
                    if (arrayList is null)
                    {
                        StyleChanged();
                        System.Windows.Forms.MessageBox.Show("很抱歉，没有查询到任何数据");
                    }
                    else
                    {
                        if (arrayList.Count() > 0)
                        {
                            new InfoWindow(arrayList).Show();
                            this.Close();
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("没有查询到数据");
                            StyleChanged();
                        }
                    }
                }));
            };
            teacher_name=name_txt.Text;
            thread = new Thread(GetDataList);
            thread.Start(callback);
        }

        private void GetDataList(object obj)
        {
            HttpHelper hp = new HttpHelper();
            Action callback = obj as Action;
            string json = hp.Get(teacher_name);
            //判断是否超时（httpHelper中请求超时返回“”）
            var db = JsonConvert.DeserializeObject<HS_Info>(json);
            //判断状态码是否为200
            if (db != null)
            {
                if (db.Code != 200)
                    StyleChanged();
                else
                {
                    if (!(db.Array2 is null))
                        arrayList.AddRange(db.Array2);//未核酸
                    if (!(db.Array is null))
                        arrayList.AddRange(db.Array);//已核酸
                    callback();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("请求超时");
                arrayList = null;
                callback();
            }

        }
        //UI切换
        private void StyleChanged()
        {
            if (name_box.Visibility == Visibility.Hidden)
            {
                name_box.Visibility = start_btn.Visibility = Visibility.Visible;
                load.Visibility = Visibility.Hidden;
            }
            else
            {
                name_box.Visibility = start_btn.Visibility = Visibility.Hidden;
                load.Visibility = Visibility.Visible;
            }
        }
        //半自动登录
        private void AutoLogin()
        {
            if(File.Exists("ApplicationUserData.json"))
            {
                name_txt.Text = File.ReadAllText("ApplicationUserData.json");
            }
        }
        //关闭软件
        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
