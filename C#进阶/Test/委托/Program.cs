using System;
using System.Collections.Generic;

namespace 委托
{
    class Program
    {
        static void Test01()
        {
            Console.WriteLine("第一");
        }
        static void Test02()
        {
            Console.WriteLine("第二");
        }

        delegate void Test();
        public static void Main(string[] args)
        {
            Test[] array = {Test01, Test02};
            for (int i = 0; i < array.Length; i++)
            {
                array[i]();
            }
            List<Test> list = new List<Test>();
            list.Add(Test01);
            list.Add(Test02);
            foreach (var t in list)
            {
                t();
            }
            Console.ReadKey();
        }
    }
}