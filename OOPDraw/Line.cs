using Nakov.TurtleGraphics;
using System;

namespace OOPDraw
{
    public class Line : Shape
    {
        protected float Length { get; set; }
        protected float Angle { get; set; }

        public Line(float xOrigin, float yOrigin, float length, float angle) : base(xOrigin, yOrigin)
        {
            Length = length;
            Angle = angle;
        }

        public override void Draw()
        {
            ResetTurtle();
            Turtle.Rotate(Angle);
            Turtle.Forward(Length);
        }

        public override void Resize(float xUnits, float yUnits)
        {
            Length = xUnits;
        }
    }
}
