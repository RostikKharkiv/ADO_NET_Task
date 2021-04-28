using System;
using System.Collections.Generic;
using System.Text;

namespace Man
{
    class Student : Man
    {
        private int _year;
        private int _course;
        private int _group;
        public int Year 
        { 
            get
            {
                return _year;
            }
            set
            {
                if (value < 0)
                    throw new InValidManStudentException("Invalid value of Age");
                _year = value;
            } 
        }
        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                if (value < 0)
                    throw new InValidManStudentException("Invalid value of Course");
                _course = value;
            }
        }
        public int Group
        {
            get
            {
                return _group;
            }
            set
            {
                if (value < 0)
                    throw new InValidManStudentException("Invalid value of Group");
                _group = value;
            }
        }

        public Student(string name, int age, int weight, int height, int year, int course, int group)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            Year = year;
            Course = course;
            Group = group;
        }

        public Student() {}

        public override void Show()
        {
            string msg = $"{Environment.NewLine}ФИО: {Name}{Environment.NewLine}Возраст: {Age}{Environment.NewLine}Вес: {Weight}{Environment.NewLine}Рост: {Height}{Environment.NewLine}Год начала обучения: {Year}{Environment.NewLine}Курс: {Course}{Environment.NewLine}Группа: {Group}";
            Console.WriteLine(msg);
        }
    }
}
