using System;

namespace SestaPamoka
{
    public class Circle
    {
        private double _radius = 1;
        private string color = "red";

        public Circle()
        {
        }

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea() 
        {
            return Math.PI * _radius * _radius;
        }

        public double GetLength()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
