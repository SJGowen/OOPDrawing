using Nakov.TurtleGraphics;
using System.Drawing;

namespace OOPDraw
{
    public class Circle : Shape
    {
        private float BaseLenth { get; set; }

        public Circle(float xOrigin, float yOrigin, Color colour, float penSize, float baseLength) : base(xOrigin, yOrigin, colour, penSize)
        {
            BaseLenth = baseLength;
        }

        public override void Draw()
        {
            ResetTurtle();
            Turtle.PenColor = Colour;
            for (int i = 0; i < 72; i++)
            {
                Turtle.Forward(BaseLenth);
                Turtle.Rotate(5);
            }
        }

        public override void Resize(float xUnits, float yUnits)
        {
            BaseLenth = xUnits / 10;
        }
    }
}
