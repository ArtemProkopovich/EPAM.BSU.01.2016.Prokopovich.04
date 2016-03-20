using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task2
{
    public class Rectangle : Shape
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

        public Point Point { get;}

        public Rectangle(double x, double y, double width, double height)
        {
            Point = new Point(x, y);
            Width = width;
            Height = height;
        }

        public Rectangle(Point p, double width, double height)
        {
            Point = new Point(p);
            Width = width;
            Height = height;
        }

        public Rectangle(Point leftTop, Point rightBottom)
        {
            Point = new Point(leftTop);
            Width = rightBottom.X - leftTop.X;
            Height = rightBottom.Y - leftTop.Y;
        }

        public double Diagonal => Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));

        public bool IsSquare => Math.Abs(width - height) < Accuracy;

        public override double Square()
        {
            return width*height;
        }

        public override double Perimetr()
        {
            return 2*(width + height);
        }
    }
}
