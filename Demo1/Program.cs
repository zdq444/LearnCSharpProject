using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = getArray();
            foreach (var item in number)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static int[] getArray()
        {
            int[] tempArray = new int[20];
            tempArray[0]= 1;
            tempArray[1]= 1;
            for (int i = 2; i < tempArray.Length; i++)
            {
                tempArray[i] = tempArray[i - 1] + tempArray[i - 2];
            }

            return tempArray;
        }
    }
}
