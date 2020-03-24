using Nakov.TurtleGraphics;
using System.Drawing;

namespace OOPDraw
{
    public class Rectangle : Shape
    {
        private float Width { get; set; }
        private float Height { get; set; }

        public Rectangle(float xOrigin, float yOrigin, Color colour, float penSize, float width, float height, float orientation) : base(xOrigin, yOrigin, colour, penSize, orientation)
        {
            Width = width;
            Height = height;
        }
 
        public override void Draw()
        {
            ResetTurtle();
            for (int i = 0; i < 2; i++)
            {
                Turtle.Forward(Height);
                Turtle.Rotate(90);
                Turtle.Forward(Width);
                Turtle.Rotate(90);
            }
        }

        public override void Resize(float xUnits, float yUnits)
        {
            Width = xUnits;
            Height = yUnits;
        }
    }
}
