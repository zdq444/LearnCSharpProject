using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_16
{/*
  * 所有的引用类型都存在堆上。
  * 当值类型是类类型的字段或属性时，存在堆上，是引用类型的一部分。
  * 结构里的引用类型字段存在栈上的是地址。
  */
    class ClassManager
    {
        Teacher teacher;//结构，值类型，具体的。
        Student student = new Student();//类，引用类型，抽象的

        public void Exam()
        {
            teacher.Name = "张三";
            student.Name = "李四";
            Console.WriteLine($"老师:{teacher.Name},学生：{student.Name}");

            foreach(var item in Enum.GetNames(typeof(sex)))
            {
                Console.WriteLine(item);

            }
        }
    }
}
