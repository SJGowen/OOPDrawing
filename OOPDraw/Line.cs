using Nakov.TurtleGraphics;
using System.Drawing;

namespace OOPDraw
{
    public class Line : Shape
    {
        protected float Length { get; set; }
        protected float Angle { get; set; }

        public Line(float xOrigin, float yOrigin, Color colour, float penSize, float length, float angle) : base(xOrigin, yOrigin, colour, penSize, angle)
        {
            Length = length;
            Angle = angle;
        }

        public override void Draw(float xMove, float yMove)
        {
            base.PrepareForDrawing(xMove, yMove);
            Turtle.Forward(Length);
        }

        public override void Resize(float xUnits, float yUnits)
        {
            Length = xUnits;
        }
    }
}
