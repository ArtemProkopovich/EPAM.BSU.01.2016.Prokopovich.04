using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Ellipse : Shape
    {
        private double width;
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                width = value;
            }
        }

        private double height;
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                height = value;
            }
        }

        public Point Point { get; }

        public Ellipse(double x, double y, double width, double height)
        {
            Point = new Point(x, y);
            Width = width;
            Height = height;
        }

        public Ellipse(Point p, double width, double height)
        {
            Point = new Point(p);
            Width = width;
            Height = height;
        }

        public Ellipse(Point leftTop, Point rightBottom)
        {
            Point = new Point(leftTop);
            Width = rightBottom.X - leftTop.X;
            Height = rightBottom.Y - leftTop.Y;
        }

        public bool IsCircle => Math.Abs(width - height) < Accuracy;

        public double SemimajorAxis => Math.Max(Width/2, Height/2);

        public double SemiminorAxis => Math.Min(Width / 2, Height / 2);

        public double Eccentricity => Math.Sqrt(1 - Math.Pow(SemiminorAxis, 2)/Math.Pow(SemimajorAxis, 2));

        public override double Square()
        {
            return Math.PI*Width*Height/4.0;
        }

        public override double Perimetr()
        {
            return 4*(Math.PI*Width/2*Height/2 + Width/2 - Height/2)/(Width/2 + Height/2);
        }
    }
}
