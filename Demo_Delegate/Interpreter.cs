using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate
{
    /// <summary>
    /// 翻译器
    /// </summary>
    class Interpreter
    {
        //原始写法
        //public delegate void Languge();
        //public Languge languge;

        public Action languge;

        //public Student stu;
        //public void SayHi(string languge)
        //{
        //    switch (languge)
        //    {
        //        case "chinese":
        //            Console.WriteLine("你好");
        //            break;
        //        case "english":
        //            Console.WriteLine("Hi");
        //            break;
        //        default:
        //            break;
        //    }

        //}
        public void SayHi()
        {
            if (languge == null)
            { 
                
                Chinese();
            }
            else 
            {
                languge();
            };
        }

        public void Chinese()
        {
            Console.WriteLine("你好");
        }

        public void English()
        {
            Console.WriteLine("Hello");
        }
    }
}
