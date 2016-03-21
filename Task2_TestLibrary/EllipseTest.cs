using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task2_TestLibrary
{
    public class EllipseTest
    {
        [Test, TestCase(1, 2, 6, 4, Result = 18.85)]
        [TestCase(1, 2, -6, 4, ExpectedException = typeof(ArgumentException))]
        [TestCase(1, 2, 3, -4, ExpectedException = typeof(ArgumentException))]
        public double Square_TestMethod(int x, int y, int width, int height)
        {
            string s = String.Format("{0:f2}", new Ellipse(x, y, width, height).Square());
            return double.Parse(s);
        }

        [Test, TestCase(1, 2, 3, 4, Result = false)]
        [TestCase(1, 2, 3, 3, Result = true)]
        public bool IsCircle_TestMethod(int x, int y, int width, int height)
        {
            Ellipse e = new Ellipse(x, y, width, height);
            return new Ellipse(x, y, width, height).IsCircle;
        }

        [Test, TestCase(1, 2, 6, 2, Result = 11.42)]
        [TestCase(1, 2, 6, 6, Result = 18.85)]
        public double Perimetr_TestMethod(int x, int y, int width, int height)
        {
            string s = String.Format("{0:f2}", new Ellipse(x, y, width, height).Perimetr());
            return double.Parse(s);
        }
    }
}
