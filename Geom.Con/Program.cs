// See https://aka.ms/new-console-template for more information
using System;
using Geom.Models;

namespace Geom.Con // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle(10);
            System.Console.WriteLine(cir.ToString());

            cir.Radius = 15;
            System.Console.WriteLine(cir.ToString());

            Cylinder cyl = new Cylinder(23.5, 12.24);
            System.Console.WriteLine(cyl.returnArea());

            Square squ = new Square(10);
            System.Console.WriteLine(squ.returnArea());

            Cuboid cub = new Cuboid(10, 12.4, 2.1);
            System.Console.WriteLine(cub.returnArea());
            System.Console.WriteLine(cub.returnVolume());

        }
    }
}
