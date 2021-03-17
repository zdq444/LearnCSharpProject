using System;

namespace Demo3_17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee("张胜男");
            Employee em2 = new Employee("帝释天");

            em1.GoHome(new Car());

        }
    }
}
