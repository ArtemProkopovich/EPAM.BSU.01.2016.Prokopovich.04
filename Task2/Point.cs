using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Task2
{
    public struct Point : IEquatable<Point>
    {
        private static double Accuracy { get; }
        public double X { get; }
        public double Y { get; }

        static Point()
        {
            double acr;
            Accuracy = Double.TryParse(ConfigurationManager.AppSettings.Get("accuracy"), out acr) ? acr : 0.000001;
        }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
                return false;
            if (obj.GetType() != typeof (Point))
                return false;
            Point p = (Point)obj;
            return Equals(p);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode()*397) ^ Y.GetHashCode();
            }
        }

        public static double Length(Point lhs, Point rhs)
        {
            return Abs(Sqrt(Pow(lhs.X - rhs.X, 2) + Pow(lhs.Y - rhs.Y, 2)));
        } 

        public bool Equals(Point other)
        {
            return Abs(X - other.X) < Accuracy && Abs(Y - other.Y) < Accuracy;
        }

        public static bool Equals(Point lhs, Point rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator ==(Point lhs, Point rhs)
        {
            return Equals(lhs, rhs);
        }

        public static bool operator !=(Point lhs, Point rhs)
        {
            return !Equals(lhs, rhs);
        }
    }
}
