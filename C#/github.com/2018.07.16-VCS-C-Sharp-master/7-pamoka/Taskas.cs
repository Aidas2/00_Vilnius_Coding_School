using System;

namespace Septinta
{
    public class Taskas
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Taskas(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Spausdinti() 
        {
            Console.WriteLine($"x={X}, y={Y}");
        }
    }
}
