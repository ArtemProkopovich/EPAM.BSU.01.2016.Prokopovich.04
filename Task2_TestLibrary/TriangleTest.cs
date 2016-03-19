using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task2_TestLibrary
{
    [TestFixture]
    class TriangleTest
    {
        [Test, TestCase(0, 0, 0, 4, 3, 0, Result = 6.0)]
        public double Square_TestMethod(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            return new Triangle(x1, y1, x2, y2, x3, y3).Square();
        }

        [Test, TestCase(0, 0, 0, 4, 3, 0, Result = 12.0)]
        public double Perimetr_TestMethod(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            return new Triangle(x1, y1, x2, y2, x3, y3).Perimetr();
        }
    }
}
