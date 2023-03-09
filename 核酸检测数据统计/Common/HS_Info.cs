using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 核酸检测数据统计.Common
{
    public class HS_Info:NotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        private int code;

        public int Code
        {
            get { return code; }
            set { code = value;OnPropertyChanged("Code"); }
        }

        /// <summary>
        /// 
        /// </summary>
        private List<Students> array;

        public List<Students> Array
        {
            get { return array; }
            set { array = value; OnPropertyChanged("Array"); }
        }

        /// <summary>
        /// 暂无数据
        /// </summary>
        private List<Students> array2;

        public List<Students> Array2
        {
            get { return array2; }
            set { array2 = value; OnPropertyChanged("Array2"); }
        }

      
    }
  
   
}
