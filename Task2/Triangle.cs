using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Triangle : Shape
    {
        private Point firstPoint;
        public Point FirstPoint
        {
            get { return firstPoint; }
            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException();
                else
                    firstPoint = value;
            }
        }

        private Point secondPoint;
        public Point SecondPoint {
            get { return secondPoint; }
            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException();
                else
                    secondPoint = value;
            }
        }

        private Point thirdPoint;

        public Point ThirdPoint
        {
            get { return thirdPoint; }
            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException();
                else
                    thirdPoint = value;
            }
        }
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

        public override double Square()
        {
            return 1.0/2.0*Math.Abs((firstPoint.X-thirdPoint.X)*(secondPoint.Y-thirdPoint.Y)-(secondPoint.X-thirdPoint.X)* (firstPoint.Y - thirdPoint.Y));
        }

        public override double Perimetr()
        {
            return Point.Length(firstPoint, secondPoint) + Point.Length(firstPoint, thirdPoint) +
                   Point.Length(secondPoint, thirdPoint);
        }
    }
}
