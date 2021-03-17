using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_17_Inheritance
{
    public class PM:Employee
    {
        public int Year { get; set; }

        public  void  DoWork()
        {
            Console.WriteLine("PM摸鱼");
        }
    }
}
