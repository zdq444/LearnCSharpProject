using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_17_1
{
    class Employee
    {
        public Employee(){ }
        public Employee(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; set; }

        public void GoHome(TrafficTool tool)
        {
            Console.WriteLine($"我是{this.Name}");
            tool.Run();
        }
    }
}
