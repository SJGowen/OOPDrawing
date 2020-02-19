using Nakov.TurtleGraphics;
using System;

namespace OOPDraw
{
    public abstract class Shape
    {
        private float XOrigin { get; set; }
        private float YOrigin { get; set; }
        private float LineWidth { get; set; }

        public Shape(float xOrigin, float yOrigin)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
        }

        public virtual void Select()
        {
            LineWidth = 4;
        }

        public virtual void Unselect()
        {
            LineWidth = 2;
        }

        protected void ResetTurtle()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = LineWidth;
            Turtle.Angle = 0;
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;
        }

        public abstract void Draw();

        public virtual void MoveTo(float x, float y)
        {
            XOrigin = x;
            YOrigin = y;
        }

        public virtual void MoveBy(float x, float y)
        {
            XOrigin += x;
            YOrigin += y;
        }

        public abstract void Resize(float x, float y);

        public void ResizeAbsolute(float x, float y)
        {
            Resize(Math.Abs(x - XOrigin), Math.Abs(y - YOrigin));
        }
    }
}
