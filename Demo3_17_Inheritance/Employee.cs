using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_17_Inheritance
{
    public class Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public string UserID { get; set; }

        public  void DoWork()
        {
            Console.WriteLine("摸鱼");
        }
    }
}
