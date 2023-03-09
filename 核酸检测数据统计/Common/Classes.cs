using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 核酸检测数据统计.Common
{
    public class Classes:NotifyPropertyChanged
    {
        private string classname;

        public string ClassName
        {
            get { return classname; }
            set { classname = value; OnPropertyChanged("Name"); }
        }
    }
}
