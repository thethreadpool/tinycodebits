using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tinycodebits
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double x, double y) : this()
        {
            X = x;
            Y = y;
        }
    }

    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public bool Intersects(Circle circle)
        {
            //two circles intersect if the distance between the 2 centers is less than the sum of the 2 radii

            if (circle != null)
            {
                double centerDistance = Math.Sqrt(Math.Pow(circle.Center.X - Center.X, 2) + Math.Pow(circle.Center.Y - Center.Y, 2));
                if (centerDistance <= circle.Radius + Radius)
                    return true;
            }

            return false;
        }

        
    }


}
