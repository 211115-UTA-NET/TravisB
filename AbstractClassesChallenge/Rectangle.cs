using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        // Implement your Rectangle class here.
        public float length;
        public float width;

        public Rectangle(float Length, float Width, string name, int numSides) : base(name, numSides)
        {
            this.length = Length;
            this.width = Width;
        }

        public override float SetArea()
        {
            this.area = length * width;
            return this.area;
        }
        
    }
}
