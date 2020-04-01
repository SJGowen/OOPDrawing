using Nakov.TurtleGraphics;
using System;
using System.Drawing;

namespace OOPDraw
{
    public abstract class Shape
    {
        protected float XOrigin { get; set; }
        protected float YOrigin { get; set; }
        public Color Colour { get; set; }
        protected float PenSize { get; set; }
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

        private void ResetTurtle()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenColor = Colour;
            Turtle.PenSize = PenSize;
            Turtle.Angle = Orientation;
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;
        }

        protected virtual void PrepareForDrawing(float xMove, float yMove)
        {
            ResetTurtle();
            Turtle.PenUp();
            Turtle.Rotate(90);
            Turtle.Forward(xMove);
            Turtle.Rotate(-90);
            Turtle.Forward(yMove);
            Turtle.PenDown();
        }

        public abstract void Draw(float xMove = 0, float yMove = 0);

        public virtual void MoveTo(float xOrigin, float yOrigin)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
        }

        public abstract void Resize(float xUnits, float yUnits);

        public virtual void ResizeAbsolute(float xUnits, float yUnits)
        {
            Resize(Math.Abs(xUnits - XOrigin), Math.Abs(yUnits - YOrigin));
        }

        public virtual void Rotate(float degrees)
        {
            //Debug.WriteLine($"Shape Rotate called with argument degrees = {degrees}");
            Orientation = degrees;
            Draw();
        }

        public virtual void Colourise(Color colour)
        {
            Colour = colour;
        }
    }
}
