using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Ellipse : Rectangle
    {
        public Ellipse(double x, double y, double width, double height) : base(x, y, width, height)
        {
        }

        public Ellipse(Point p, double width, double height) : base(p, width, height)
        {
        }

        public Ellipse(Point leftTop, Point rightBottom) : base(leftTop, rightBottom)
        {
        }

        public bool IsCircle()
        {
            return Math.Abs(Width - Height) < Accuracy;
        }

        private new void IsSquare()
        {
        }

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
