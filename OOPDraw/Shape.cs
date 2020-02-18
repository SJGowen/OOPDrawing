using Nakov.TurtleGraphics;

namespace OOPDraw
{
    public abstract class Shape
    {
        protected float XOrigin { get; set; }
        protected float YOrigin { get; set; }

        public Shape(float xOrigin, float yOrigin)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
        }

        protected void ResetTurtle()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;
        }

        public abstract void Draw();

        public void MoveTo(float x, float y)
        {
            XOrigin = x;
            YOrigin = y;
        }
    }
}
