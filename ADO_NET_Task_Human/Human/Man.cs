using System;
using System.Collections.Generic;
using System.Text;

namespace Man
{
    class Man
    {
        private int _age;
        private int _weight;
        private int _height;

        public string Name { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                    throw new InValidManStudentException("Invalid value of Age");
                _age = value;
            }
        }
        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value < 0)
                    throw new InValidManStudentException("Invalid value of Weight");
                _weight = value;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                    throw new InValidManStudentException("Invalid value of Height");
                _height = value;
            }
        }

        public Man(string name, int age, int weight, int height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public Man() {}

        public virtual void Show()
        {
            string msg = $"{Environment.NewLine}ФИО: {Name}{Environment.NewLine}Возраст: {Age}{Environment.NewLine}Вес: {Weight}{Environment.NewLine}Рост: {Height}";
            Console.WriteLine(msg);
        }
    }
}
