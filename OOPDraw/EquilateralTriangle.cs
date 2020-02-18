using Nakov.TurtleGraphics;

namespace OOPDraw
{
    public class EquilateralTriangle : Shape
    {
        private float SideLength { get; set; }

        public EquilateralTriangle(float xOrigin, float yOrigin, float sideLength) : base(xOrigin, yOrigin)
        {
            SideLength = sideLength;
        }

        public override void Draw()
        {
            ResetTurtle();
            Turtle.Rotate(30);
            for (int i = 0; i < 3; i++)
            {
                Turtle.Forward(SideLength);
                Turtle.Rotate(120);
            }
        }
    }
}
