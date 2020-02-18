using Nakov.TurtleGraphics;

namespace OOPDraw
{
    public class EquilateralTriangle : Shape
    {
        private float SideLength { get; set; }

        public EquilateralTriangle(float xOrigin, float yOrigin, float sideLength)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
            SideLength = sideLength;
        }

        public override void Draw()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;
            Turtle.Rotate(30);
            for (int i = 0; i < 3; i++)
            {
                Turtle.Forward(SideLength);
                Turtle.Rotate(120);
            }
        }
    }
}
