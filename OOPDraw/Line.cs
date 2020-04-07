using Nakov.TurtleGraphics;
using System.Drawing;

namespace OOPDraw
{
    public class Line : Shape
    {
        protected float Length { get; set; }

        public Line(float xOrigin, float yOrigin, Color colour, float penSize, float length, float angle) : base(xOrigin, yOrigin, colour, penSize, angle)
        {
            Length = length;
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

        public override void Select()
        {
            base.IsSelected = true;
        }

        public override void Unselect()
        {
            base.IsSelected = false;
        }
    }
}
