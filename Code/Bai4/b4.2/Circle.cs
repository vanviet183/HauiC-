using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b4._2
{
    internal class Circle
    {
        public double radius { get; set; }

        static double PI = 3.14;

        public Circle(double radius)
        {
            this.radius = radius;
        }


        public Circle()
        {
        }

        public double Area(double radius)
        {
            return radius * PI;
        }

        public double Perimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }
}
