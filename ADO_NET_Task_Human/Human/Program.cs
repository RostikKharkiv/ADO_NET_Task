using System;

namespace Man
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] stud = new Student[10];

            foreach (Student s in stud)
            {
                s.Age = 26;
            }
        }
    }
}
