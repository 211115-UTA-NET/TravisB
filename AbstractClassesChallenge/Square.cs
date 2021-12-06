using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
        public float sideLength;

        public Square(float side) : base(name, numSides)
        {
            this.sideLength = side;
            this.name = "Square";
            this.numSides = 4;
        }

        public override float SetArea()
        {
            this.area = sideLength * sideLength;
            return this.area;
        }
    }
}
