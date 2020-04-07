using Nakov.TurtleGraphics;
using System;
using System.Diagnostics;
using System.Drawing;

namespace OOPDraw
{
    public abstract class Shape
    {
        public float XOrigin { get; set; }
        public float YOrigin { get; set; }
        protected float PenSize { get; set; }
        public Color Colour { get; set; }
        public float Orientation { get; set; }
        public bool IsSelected { get; protected set; }


        public Shape(float xOrigin, float yOrigin, Color colour, float penSize, float orientation)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
            Colour = colour;
            PenSize = penSize;
            Orientation = orientation;
            IsSelected = true;
        }

        public abstract void Select();

        public abstract void Unselect();

        private void ResetTurtle()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenColor = Colour;
            Turtle.Angle = Orientation;
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;
        }

        protected virtual void PrepareForDrawing(float xMove, float yMove)
        {
            ResetTurtle();
            Debug.WriteLine($"Drawing called on Shape {this.GetType().Name} - IsSelected {IsSelected} - Called From {new System.Diagnostics.StackTrace(true)}.");
            Turtle.PenSize = IsSelected ? 4 : 2;
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
            if (IsSelected)
            {
                XOrigin = xOrigin;
                YOrigin = yOrigin;
            }
        }

        public abstract void Resize(float xUnits, float yUnits);

        public virtual void ResizeAbsolute(float xUnits, float yUnits)
        {
            if (IsSelected) Resize(Math.Abs(xUnits - XOrigin), Math.Abs(yUnits - YOrigin));
        }

        public virtual void Rotate(float degrees)
        {
            //Debug.WriteLine($"Shape Rotate called on shape that has selected = {IsSelected} with argument degrees = {degrees}");
            if (IsSelected) Orientation = degrees;
            Draw();
        }

        public virtual void Colourise(Color colour)
        {
            if (IsSelected) Colour = colour;
        }
    }
}
