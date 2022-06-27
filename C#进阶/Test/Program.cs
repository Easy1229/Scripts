using System;
using System.Runtime.InteropServices;

namespace 继承
{
    enum Gender
    {
        Male,
        Female,
    }
    class Student
    {
        public virtual void Say()
        {
            Console.WriteLine("123");
        }
       
    }

    class Test:Student
    {
        public override void Say()
        {
            Console.WriteLine("456");
        }
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            Test test = new Test();
            student.Say();
            test.Say();
            
        }
    }
}