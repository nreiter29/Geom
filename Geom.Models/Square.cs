using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Models
{
    public class Square
    {
        private double _length;

        public double Length { 
            get { return _length; }
            set { _length = value; } 
        }

        private double CalcArea()
        {
            return Length * Length;
        }

        public Square(double length)
        {
            Length = length;
        }

        public string returnArea()
        {
            return "Square: " + CalcArea();
        }
    }
}
