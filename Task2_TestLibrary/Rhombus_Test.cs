using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task2_TestLibrary
{
    public class Rhombus_Test
    {
        [Test, TestCase(1, 2, 3, 4, Result = 6.0)]
        [TestCase(1, 2, -3, 4, ExpectedException = typeof(ArgumentException))]
        [TestCase(1, 2, 3, -4, ExpectedException = typeof(ArgumentException))]
        public double Square_TestMethod(int x, int y, int width, int height)
        {
            return new Rhombus(x, y, width, height).Square();
        }

        [Test, TestCase(1, 2, 6, 8, Result = 20)]
        public double Perimetr_TestMethod(int x, int y, int width, int height)
        {
            return new Rhombus(x, y, width, height).Perimetr();
        }
    }
}
