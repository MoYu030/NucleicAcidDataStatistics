using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 核酸检测数据统计.Common
{
    public class Functions:NotifyPropertyChanged
    {
        public List<Classes> GetClassInfo(List<Students> arrayList)
        {
            List<Classes> list = new List<Classes>();
            foreach (var item in arrayList) 
            {
                if(!list.Any(t=>t.ClassName==item.Classname)) 
                list.Add(new Classes() { ClassName=item.Classname});
            }
            return list;
        }

        public static void Delay(int waitTime)
        {
            if (waitTime <= 0) return;

            Console.WriteLine("开始执行 ...");
            DateTime nowTimer = DateTime.Now;
            int interval = 0;
            while (interval < waitTime)
            {
                TimeSpan spand = DateTime.Now - nowTimer;
                interval = spand.Seconds;
            }

            Console.WriteLine(waitTime + "秒后继续 ...");
        }
    }
}
