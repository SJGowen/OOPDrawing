﻿using Nakov.TurtleGraphics;
using System;
using System.Drawing;

namespace OOPDraw
{
    internal class IsoscelesRightAngledTriangle : Shape
    {
        private float BaseLength { get; set; }

        public IsoscelesRightAngledTriangle(float xOrigin, float yOrigin, Color colour, float lineWidth, float baseLength) : base(xOrigin, yOrigin, colour, lineWidth)
        {
            BaseLength = baseLength;
        }

        public override void Draw()
        {
            ResetTurtle();
            Turtle.PenColor = Colour;
            Turtle.Rotate(45);
            Turtle.Forward((float)Math.Sqrt(BaseLength * BaseLength / 2));
            Turtle.Rotate(90);
            Turtle.Forward((float)Math.Sqrt(BaseLength * BaseLength / 2));
            Turtle.Rotate(135);
            Turtle.Forward(BaseLength);
        }

        public override void Resize(float xUnits, float yUnits)
        {
            BaseLength = xUnits;
        }
    }
}