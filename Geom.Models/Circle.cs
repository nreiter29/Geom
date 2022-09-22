﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Con {
    public class Circle {
        public double Radius { get; set; }

        private double _circumference;

        public double Circumference {
            get {
                CalcCircumference();
                return _circumference;
            }
            private set { _circumference = value; }
        }

        private double _area;

        public double Area {
            get {
                CalcArea();
                return _area;
            }
            private set { _area = value; }
        }

        public static int CircleCount { get; private set; }


        public Circle(double radius) {
            Radius = radius;
            CircleCount++;
        }

        public void CalcArea() {
            Area = Math.PI * Math.Pow(Radius, 2);
        }

        private void CalcCircumference() {
            Circumference = 2 * Math.PI * Radius;
        }

        public override string ToString() {
            return $"Area: {Area}\n\rCircumference: {Circumference}";
        }
    }
}
