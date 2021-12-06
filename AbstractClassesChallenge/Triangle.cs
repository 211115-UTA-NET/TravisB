using System;
using System.Math;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
        // Implement your Triangle class here.
        // HINT: Use Herons Formula to calculate and set the area.

        public double side1;
        public double side2;
        public double side3;
        public Triangle(double side1, double side2, double side3) : base(name, numSides)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.name = "triangle";
            this.numSides = 3;
        }

        public override double SetArea()
        {
            public double s = (side1 / 2)  + (side2 / 2) + (side3 / 2);
            public double heronSquared = s * (s - side1) * (s - side2) * (s - side3);
            this.area = Math.Sqrt(heronSquared);
            return this.area;
        }
    }
}