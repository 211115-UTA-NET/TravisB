using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
        public float sideLength;

        public Square(float side, string name, int numSides) : base(name, numSides)
        {
            this.sideLength = side;
        }

        public override float SetArea()
        {
            this.area = sideLength * sideLength;
            return this.area;
        }
    }
}
