using System;
using System.Collections.Generic;

namespace 列表排序
{
    class Student
    {
        public string name;
        public int score;

        public Student(string n, int s)
        {
            name = n;
            score = s;
        }

        public override string ToString()
        {
            return string.Format($"学生：{name} 分数：{score}");
        }
    }
    class Program
    {
        public static int StudentSort(Student a,Student b)
        {
            if (a.score < b.score)
            {
                return -1;
            }

            if (a.score > b.score)
            {
                return 1;
            }

            return 0;
        }
            static void PrintList<T>(List<T> list)
        {
            foreach (T t in list)
            {
                Console.WriteLine(t+"");
            }
            Console.WriteLine("============");
        }
        public static void Main(string[] args)
        {
            Student s1 = new Student("小明",95);
            Student s2 = new Student("小亮",80);
            Student s3 = new Student("小红",90);

            List<Student> students = new List<Student>{s1,s2,s3};
            students.Sort(StudentSort);
            PrintList(students);
            Console.ReadKey();
        }
    }
}