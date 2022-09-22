using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Models
{
    public class Cuboid : Square
    {
        private double _secondLength;
        private double _thirdLength;

        public double SecondLength
        {
            get { return _secondLength; }
            set { _secondLength = value; }
        }

        public double ThirdLength
        {
            get { return _thirdLength; }
            set { _thirdLength = value; }
        }

        public Cuboid(double length, double secondLength, double thirdLength) : base(length)
        {
            SecondLength = secondLength;
            ThirdLength = thirdLength;
        }

        private double CalcArea()
        {
            return 2 * Length * SecondLength + 2 * Length * ThirdLength + 2 * SecondLength * ThirdLength;
        }

        private double CalcVolume()
        {
            return Length * SecondLength * ThirdLength;
        }

        public string returnArea()
        {
            return "Cuboid Area: " + CalcArea();
        }

        public string returnVolume()
        {
            return "Cuboid Volume: " + CalcVolume();
        }
    }
}
