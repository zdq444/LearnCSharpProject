using System;
using System.Collections.Generic;

namespace Demo3_17_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            PM pM = new PM() {Name="PM",Age=12,Gender=Gender.女,UserID="01001",Year=10 };
            SE sE = new SE() {Name="SE",Age=13,Gender=Gender.男,UserID="09001",pop="好" };

            List<Employee> em = new List<Employee>();
            em.Add(pM);
            em.Add(sE);
            foreach (var item in em)
            {
                item.DoWork();

            }
            
        }
    }
}
