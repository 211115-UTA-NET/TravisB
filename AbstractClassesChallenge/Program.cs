using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rectangle newR = new Rectangle(4.2, 3.0);
            newR.SetArea();
            Console.WriteLine($"The area of this {name} is {area}");

            Square newSq = new Square(14.2);
            newSq.SetArea();
            Console.WriteLine($"The area of this {name} is {area}");

            Triangle newT = new Triangle(17.2, 1.3, 10.0);
            newT.SetArea();
            Console.WriteLine($"The area of this {name} is {area}");

        }
    }
}
