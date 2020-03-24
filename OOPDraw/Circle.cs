using Nakov.TurtleGraphics;
using System.Drawing;

namespace OOPDraw
{
    public class Circle : Shape
    {
        private float BaseLenth { get; set; }

        public Circle(float xOrigin, float yOrigin, Color colour, float penSize, float baseLength, float orientation) : base(xOrigin, yOrigin, colour, penSize, orientation)
        {
            BaseLenth = baseLength;
        }

        public override void Draw()
        {
            ResetTurtle();
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
