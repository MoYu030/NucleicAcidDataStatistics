using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 核酸检测数据统计.Common
{
    public class Students:NotifyPropertyChanged
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;OnPropertyChanged("Name"); }
        }
        private string classname;

        public string Classname
        {
            get { return classname; }
            set { classname = value;OnPropertyChanged("Classname"); }
        }

        private string msg;

        public string Msg
        {
            get { return msg; }
            set { msg = value; OnPropertyChanged("Msg"); }
        }

    }
}
