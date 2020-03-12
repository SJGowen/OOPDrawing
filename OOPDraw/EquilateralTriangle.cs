using Nakov.TurtleGraphics;
using System.Drawing;

namespace OOPDraw
{
    public class EquilateralTriangle : Shape
    {
        private float SideLength { get; set; }

        public EquilateralTriangle(float xOrigin, float yOrigin, Color colour, float lineWidth, float sideLength) : base(xOrigin, yOrigin, colour, lineWidth)
        {
            SideLength = sideLength;
        }

        public override void Draw()
        {
            ResetTurtle();
            Turtle.PenColor = Colour;
            Turtle.Rotate(30);
            for (int i = 0; i < 3; i++)
            {
                Turtle.Forward(SideLength);
                Turtle.Rotate(120);
            }
        }

        public override void Resize(float xUnits, float yUnits)
        {
            SideLength = xUnits;
        }
    }
}
