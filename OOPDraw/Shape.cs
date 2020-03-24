using Nakov.TurtleGraphics;
using System;
using System.Drawing;

namespace OOPDraw
{
    public abstract class Shape
    {
        private float XOrigin { get; set; }
        private float YOrigin { get; set; }
        private float PenSize { get; set; }
        public Color Colour { get; set; }
        public float Orientation { get; set; }
        
        private float OriginalPenSize;


        public Shape(float xOrigin, float yOrigin, Color colour, float penSize, float orientation)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
            Colour = colour;
            PenSize = penSize;
            Orientation = orientation;
        }

        public virtual void Select()
        {
            OriginalPenSize = PenSize;
            PenSize = 4;
        }

        public virtual void Unselect()
        {
            PenSize = OriginalPenSize;
        }

        protected void ResetTurtle()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = PenSize;
            Turtle.Angle = Orientation;
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

        public void Rotate(float degrees)
        {
            Orientation = degrees;
            Draw();
        }
    }
}
