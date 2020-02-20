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

        public virtual void MoveTo(float xOrigin, float yOrigin)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
        }

        public virtual void MoveBy(float xUnits, float yUnits)
        {
            XOrigin += xUnits;
            YOrigin += yUnits;
        }

        public abstract void Resize(float xUnits, float yUnits);

        public void ResizeAbsolute(float xUnits, float yUnits)
        {
            Resize(Math.Abs(xUnits - XOrigin), Math.Abs(yUnits - YOrigin));
        }
    }
}
