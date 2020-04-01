using Nakov.TurtleGraphics;
using System.Diagnostics;
using System.Drawing;

namespace OOPDraw
{
    public class Arrow : Shape, IColourable
    {
        private Line Shaft { get; set; }
        private Line LeftTip { get; set; }
        private Line RightTip { get; set; }

        public Arrow(float xOrigin, float yOrigin, Color colour, float penSize, float length, float angle) : base(xOrigin, yOrigin, colour, penSize, angle)
        {
            Shaft = new Line(xOrigin, yOrigin, colour, penSize, length, angle);
            LeftTip = new Line(xOrigin, yOrigin, colour, penSize, 20, angle - 30);
            RightTip = new Line(xOrigin, yOrigin, colour, penSize, 20, angle + 30);
        }

        public override void Draw(float xMove, float yMove)
        {
            Shaft.Draw(xMove, yMove);
            LeftTip.Draw(xMove, yMove);
            RightTip.Draw(xMove, yMove);
        }

        public override void MoveTo(float xOrigin, float yOrigin)
        {
            base.MoveTo(xOrigin, yOrigin);
            Shaft.MoveTo(xOrigin, yOrigin);
            LeftTip.MoveTo(xOrigin, yOrigin);
            RightTip.MoveTo(xOrigin, yOrigin);
        }

        public override void Resize(float xUnits, float yUnits)
        {
            Shaft.Resize(xUnits, yUnits);
            Select();
        }

        public override void Select()
        {
            Shaft.Select();
            LeftTip.Select();
            RightTip.Select();
        }

        public override void Unselect()
        {
            Shaft.Unselect();
            LeftTip.Unselect();
            RightTip.Unselect();
        }

        public override void Colourise(Color colour)
        {
            base.Colour = colour;
            Shaft.Colourise(colour);
            LeftTip.Colourise(colour);
            RightTip.Colourise(colour);
        }

        public override void Rotate(float degrees)
        {
            //Debug.WriteLine($"Arrow Rotate called with argument degrees = {degrees}");
            base.Rotate(degrees);
            Shaft.Rotate(degrees);
            LeftTip = new Line(base.XOrigin, base.YOrigin, base.Colour, base.PenSize, 20, base.Orientation - 30);
            RightTip = new Line(base.XOrigin, base.YOrigin, base.Colour, base.PenSize, 20, base.Orientation + 30);
        }
    }
}
