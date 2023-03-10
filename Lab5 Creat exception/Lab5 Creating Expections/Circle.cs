using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Creating_Expections
{
    internal class Circle
    {
        public double radius;
        public double Radius
        {
            get
            { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new InvalidRadius(value, "Radius value is not valid");
                }

            }
        }
        public double Area
        {
            get { return (Math.Pow(Radius, 2) * Math.PI); }
        }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override string ToString()
        {
            return $"Radius: {this.Radius}";
        }
    }
}
