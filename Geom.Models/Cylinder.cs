using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Geom.Con;

namespace Geom.Models
{
    public class Cylinder : Circle
    {
        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private double CalcArea()
        {
            return Area * Height; 
        }

        public Cylinder(double radius, double height) : base(radius)
        {
            Height = height;
        }

        public string returnArea()
        {
            return "Cylinder: " + CalcArea();
        }
    }
}
