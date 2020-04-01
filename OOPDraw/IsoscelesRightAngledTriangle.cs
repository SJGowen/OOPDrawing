using Nakov.TurtleGraphics;using System;
using System.Drawing;

namespace OOPDraw
{
    internal class IsoscelesRightAngledTriangle : Shape
    {
        private float BaseLength { get; set; }

        public IsoscelesRightAngledTriangle(float xOrigin, float yOrigin, Color colour, float penSize, float baseLength, float orientation) : base(xOrigin, yOrigin, colour, penSize, orientation)
        {
            BaseLength = baseLength;
        }

        public override void Draw(float xMove, float yMove)
        {
            base.PrepareForDrawing(xMove, yMove);
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