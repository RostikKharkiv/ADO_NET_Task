using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        private double AB => GetSideLength(X1, Y1, X2, Y2);
        private double BC => GetSideLength(X2, Y2, X3, Y3);
        private double AC => GetSideLength(X1, Y1, X3, Y3);

        private double P => Perimetr();
        private double S => Square();

        public int X1 { get; set; }

        public int X2 { get; set; }

        public int X3 { get; set; }

        public int Y1 { get; set; }

        public int Y2 { get; set; }

        public int Y3 { get; set; }

        public Triangle(int x1 = 0, int y1 = 0, int x2 = 0, int y2 = 0, int x3 = 0, int y3 = 0)
        {
            X1 = x1;
            X2 = x2;
            X3 = x3;
            Y1 = y1;
            Y2 = y2;
            Y3 = y3;

            if (!IsValid())
            {
                throw new InValidSideException("Wrong size lenght");
            }
        }

        private double GetSideLength(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - X1) + (y2 - y1) * (y2 - y1));
        }

        private bool IsValid()
        {
            return (AB < BC + AC && BC < AB + AC && AC < AB + AC);
        }
        private double Perimetr()
        {
            return AB + BC + AC;
        }

        private double Square()
        {
            return Math.Sqrt(P * (P - AB) * (P - BC) * (P - AC));
        }

        public void Show()
        {
            string msg = $"{Environment.NewLine}Координаты точек треугольника: ({X1};{Y1}), ({X2};{Y2}), ({X3};{Y3}){Environment.NewLine}Стороны трекгольника равны: AB - {AB:#.##} BC - {BC:#.##}; AC - {AC:#.##}{Environment.NewLine}Периметр треугольника равен: {P:#.##}{Environment.NewLine}Площадь треугольника равна: {S:#.##}";
            Console.WriteLine(msg);
        }


    }
}
