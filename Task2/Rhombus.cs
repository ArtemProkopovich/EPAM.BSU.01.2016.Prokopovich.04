using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Task2
{
    public class Rhombus : Shape
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

        public bool IsSquare => Math.Abs(Width - Height) < Accuracy;

        public Point Point { get; }

        public Rhombus(double x, double y, double width, double height)
        {
            Point = new Point(x, y);
            Width = width;
            Height = height;
        }

        public Rhombus(Point p, double width, double height)
        {
            Point = new Point(p);
            Width = width;
            Height = height;
        }

        public Rhombus(Point leftTop, Point rightBottom)
        {
            Point = new Point(leftTop);
            Width = rightBottom.X - leftTop.X;
            Height = rightBottom.Y - leftTop.Y;
        }

        public override double Square()
        {
            return Width*Height/2.0;
        }

        public override double Perimetr()
        {
            return 4*Sqrt(Pow(Width/2.0, 2) + Pow(Height/2.0, 2));
        }
    }
}
