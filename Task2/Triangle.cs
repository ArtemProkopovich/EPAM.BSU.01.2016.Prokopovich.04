﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Task2
{
    public class Triangle : Shape
    {
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }
        public Point ThirdPoint { get; set; }

        public Triangle(double firstX, double firstY, double secondX, double secondY, double thirdX, double thirdY)
        {
            FirstPoint = new Point(firstX,firstY);
            SecondPoint = new Point(secondX,secondY);
            ThirdPoint = new Point(thirdX, thirdY);
        }

        public Triangle(Point firstP, Point secondP , Point thirdP)
        {
            FirstPoint = firstP;
            SecondPoint = secondP;
            ThirdPoint = thirdP;
        }

        public bool IsIsosceles
        {
            get
            {
                double l1 = Point.Length(FirstPoint, SecondPoint);
                double l2 = Point.Length(SecondPoint, ThirdPoint);
                double l3 = Point.Length(FirstPoint, ThirdPoint);
                return Abs(l1 - l2) < Accuracy || Abs(l2 - l3) < Accuracy || (Abs(l1 - l3) < Accuracy);
            }
        }

        public bool IsEquilateral
        {
            get
            {
                double l1 = Point.Length(FirstPoint, SecondPoint);
                double l2 = Point.Length(SecondPoint, ThirdPoint);
                double l3 = Point.Length(FirstPoint, ThirdPoint);
                return Abs(l1 - l2) < Accuracy && Abs(l2 - l3) < Accuracy;
            }
        }

        public override double Square()
        {
            return 1.0/2.0*Math.Abs((FirstPoint.X-ThirdPoint.X)*(SecondPoint.Y-ThirdPoint.Y)-(SecondPoint.X-ThirdPoint.X)* (FirstPoint.Y - ThirdPoint.Y));
        }

        public override double Perimetr()
        {
            return Point.Length(FirstPoint, SecondPoint) + Point.Length(FirstPoint, ThirdPoint) +
                   Point.Length(SecondPoint, ThirdPoint);
        }
    }
}
