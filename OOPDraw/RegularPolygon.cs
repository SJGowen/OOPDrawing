using Nakov.TurtleGraphics;
using System;
using System.Drawing;

namespace OOPDraw
{
    public class RegularPolygon : Shape
    {
        public float SideLength { get; set; }
        public int Sides { get; set; }

        public RegularPolygon(float xOrigin, float yOrigin, Color colour, float lineWidth, float sideLength, int sides) : base(xOrigin, yOrigin, colour, lineWidth)
        {
            SideLength = sideLength;
            Sides = sides;
        }

        public override void Draw()
        {
            ResetTurtle();
            Turtle.Rotate(270);
            Turtle.PenColor = Colour;
            for (int i = 0; i < Sides; i++)
            {
                Turtle.Rotate((float)360 / Sides);
                Turtle.Forward(SideLength);
            }
        }

        public override void Resize(float xUnits, float yUnits)
        {
            SideLength = xUnits;
        }
    }
}
