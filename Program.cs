using System;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square a = new Square(5);
            Square b = new Square(10);
            Square c = new Square(15);
            Square d = new Square(20);
            Square e = new Square(25);
            a.CalcSides();
            Console.WriteLine(a.CalcSides());
            b.CalcSides();
            Console.WriteLine(b.CalcSides());
            c.CalcSides();
            Console.WriteLine(c.CalcSides());
            d.CalcSides();
            Console.WriteLine(d.CalcSides());
            e.CalcSides();
            Console.WriteLine(e.CalcSides());
            a.SideA = 253.2589;
            a.CalcSides();
            Console.WriteLine(a.CalcSides());
            Console.WriteLine();

            Console.WriteLine("Calculating area");
            a.CalcArea();
            Console.WriteLine(a.CalcArea());
            b.CalcArea();
            Console.WriteLine(b.CalcArea());
            c.CalcArea();
            Console.WriteLine(c.CalcArea());
            d.CalcArea();
            Console.WriteLine(d.CalcArea());
            e.CalcArea();
            Console.WriteLine(e.CalcArea());
            a.SideA = 253.2589;
            a.CalcArea();
            Console.WriteLine(a.CalcArea());
        }
    }
}
