using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Shape
    {
        protected static double Accuracy { get; }
        public abstract double Square();
        public abstract double Perimetr();
        static Shape()
        {
            double acr;
            Accuracy = Double.TryParse(ConfigurationManager.AppSettings.Get("accuracy"), out acr) ? acr : 0.000001;
        }
    }
}
