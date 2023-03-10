using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Creating_Expections
{
    internal class InvalidRadius:Exception
    {
        private double radius;
        public double Radius { get { return radius; } }
        public InvalidRadius(double radius, string message) : base($"{message}: {radius}")
        {
            this.radius = radius;
        }
    }
}
