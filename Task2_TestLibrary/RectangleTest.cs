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
    public class RectangleTest
    {
        [Test, TestCase(1, 2, 3, 4, Result = 12.0)]
        [TestCase(1, 2, -3, 4, ExpectedException = typeof(ArgumentException))]
        [TestCase(1, 2, 3, -4, ExpectedException = typeof(ArgumentException))]
        public double Square_TestMethod(int x, int y, int width, int height)
        {
            return new Rectangle(x, y, width, height).Square();
        }

        [Test, TestCase(1, 2, 3, 4, Result = false)]
        [TestCase(1, 2, 3, 3, Result = true)]
        public bool IsSquare_TestMethod(int x, int y, int width, int height)
        {
            return new Rectangle(x, y, width, height).IsSquare();
        }

        [Test, TestCase(1, 2, 3, 4, Result = 14)]
        [TestCase(1, 2, 3, 3, Result = 12)]
        public double Perimetr_TestMethod(int x, int y, int width, int height)
        {
            return new Rectangle(x, y, width, height).Perimetr();
        }
    }
}
