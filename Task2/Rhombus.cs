using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Task2
{
    public class Rhombus : Rectangle
    {
        public Rhombus(double x, double y, double width, double height) : base(x, y, width, height)
        {
        }

        public Rhombus(Point p, double width, double height) : base(p, width, height)
        {
        }

        public Rhombus(Point leftTop, Point rightBottom) : base(leftTop, rightBottom)
        {
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
