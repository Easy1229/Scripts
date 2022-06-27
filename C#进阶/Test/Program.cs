using System;

namespace 继承
{
    class Student
    {
        public string name;
        public int age;
        public Gender gender;

        public Student(string name, int age, Gender gender)
        {
            name = this.name;
            age = this.age;
            gender = this.gender;
        }
    }

    enum Gender
    {
        Male,
        Female,
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}