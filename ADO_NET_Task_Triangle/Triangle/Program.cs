using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(1,1,2,3,4,10);
            triangle1.Show();
            triangle1.X1 = 2;
            triangle1.Y1 = 5;
            triangle1.Show();
        }
    }
}
