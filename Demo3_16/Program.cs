using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo3_16
{
    public enum sex
    {
        男,女
    }
    class Program
    {
        static void Main(string[] args)
        {

            //MethodArrayList();
            //MethodHashTable();
            MethodList();

        }
        /// <summary>
        /// 数组和集合
        /// </summary>
        public static void MethodArrayList()
        {
            #region 数组
            Student[] studentsArray = new Student[2];
            studentsArray[0] = new Student() { Age = 1, Name = "张三", Sex = sex.女.ToString() };
            studentsArray[1] = new Student() { Age = 2, Name = "小红", Sex = sex.女.ToString() };
            foreach (var item in studentsArray)
            {
                Console.WriteLine($"数组姓名:{item.Name},年龄：{item.Age},性别：{item.Sex}");
            }
            #endregion

            #region 集合List

            ArrayList students = new ArrayList();
            students.Add(new Student() { Name = "李四", Sex = sex.男.ToString(), Age = 12 });
            Student stu = (Student)students[0];
            stu.Name = "李五";
            foreach (Student item in students)
            {
                Console.WriteLine($"集合姓名:{item.Name},年龄：{item.Age},性别：{item.Sex}");
            }
            #endregion
        }
        /// <summary>
        /// Hashtable 无序的，Key Value键值对，只能通过键值对形式操作
        /// </summary>
        public static void MethodHashTable()
        {
            Student stu1 = new Student() { Age = 1, Name = "张三", Sex = sex.女.ToString() };
            Student stu2 = new Student() { Age = 2, Name = "小红", Sex = sex.女.ToString() };

            Hashtable ht = new Hashtable();
            ht.Add("2", stu1);
            ht.Add("1", stu2);
            Student st=ht[1] as Student;
        }
        /// <summary>
        /// List<T>泛型集合，安全，限定数据类型，集中了数组和集合的优点。
        /// </summary>
        public static void MethodList()
        {
            Student stu1 = new Student() { Age = 1, Name = "张三", Sex = sex.女.ToString() };
            Student stu2 = new Student() { Age = 2, Name = "小红", Sex = sex.女.ToString() };
            List<Student> students = new List<Student>() {stu1,stu2 };
            
        }
        /// <summary>
        /// 泛型字典，比Hashtable强在规定了数据类型
        /// </summary>
        public static void MethodDictionary()
        {
            Student stu1 = new Student() { Age = 1, Name = "张三", Sex = sex.女.ToString() };
            Student stu2 = new Student() { Age = 2, Name = "小红", Sex = sex.女.ToString() };
            Dictionary<string, Student> dic = new Dictionary<string, Student>();
            dic.Add("1",stu1);
        }
    }
}
