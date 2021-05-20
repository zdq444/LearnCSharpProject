using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_Thread
{
    class MakeTea
    {
        public void Star()
        {
            //Boid();
            //WashCap();

            Thread t1 = new Thread(Boid);
            Thread t2 = new Thread(WashCap);
            t1.Start();
            t2.Start();
        }

        public void Boid()
        {
            Console.WriteLine("正在烧水");
            Thread.Sleep(3000);
            Console.WriteLine("水已烧开");
        }

        public void WashCap()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"正在洗第{i}个杯子");             
            }
            Console.WriteLine("杯子已经洗完了！");
        }
    }
}
