using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task2
{
    public class Rectangle : Point
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

        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(Point p, double width, double height) : base(p)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(Point leftTop, Point rightBottom) : base(leftTop)
        {
            Width = rightBottom.X - leftTop.X;
            Height = rightBottom.Y - leftTop.Y;
        }

        public bool IsSquare()
        {
            return Math.Abs(width - height) < Accuracy;
        }

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
