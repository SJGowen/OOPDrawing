using Nakov.TurtleGraphics;
using System.Drawing;


namespace OOPDraw
{
    public class Circle : Shape
    {
        private float Increment { get; set; }

        public Circle(float xOrigin, float yOrigin, Color colour, float lineWidth, float increment) : base(xOrigin, yOrigin, colour, lineWidth)
        {
            Increment = increment / 10;
        }

        public override void Draw()
        {
            ResetTurtle();
            Turtle.PenColor = Colour;
            for (int i = 0; i < 36; i++)
            {
                Turtle.Forward(Increment);
                Turtle.Rotate(10);
            }
        }

        public override void Resize(float xUnits, float yUnits)
        {
            Increment = xUnits / 10;
        }
    }
}
