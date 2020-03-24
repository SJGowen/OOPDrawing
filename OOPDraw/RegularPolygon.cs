﻿using Nakov.TurtleGraphics;
using System.Drawing;

namespace OOPDraw
{
    public class RegularPolygon : Shape
    {
        public float SideLength { get; set; }
        public int Sides { get; set; }

        public RegularPolygon(float xOrigin, float yOrigin, Color colour, float penSize, float sideLength, int sides, float orientation) : base(xOrigin, yOrigin, colour, penSize, orientation)
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
