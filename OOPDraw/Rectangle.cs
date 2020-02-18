using Nakov.TurtleGraphics;

namespace OOPDraw
{
    public class Rectangle : Shape
    {
        private float XOrigin { get; set; }
        private float YOrigin { get; set; }
        private float Width { get; set; }
        private float Height { get; set; }

        public Rectangle(float xOrigin, float yOrigin, float width, float height)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
            Width = width;
            Height = height;
        }
 
        public void Draw()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;
            for (int i = 0; i < 2; i++)
            {
                Turtle.Forward(Height);
                Turtle.Rotate(90);
                Turtle.Forward(Width);
                Turtle.Rotate(90);
            }
        }
    }
}
