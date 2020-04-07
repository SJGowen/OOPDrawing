using System.Drawing;

namespace OOPDraw
{
    public class Arrow : Shape, IColourable
    {
        private Line Shaft { get; set; }
        private Line LeftTip { get; set; }
        private Line RightTip { get; set; }
        public float Length { get; set; }
        private float TipLength { get; set; }

        public Arrow(float xOrigin, float yOrigin, Color colour, float penSize, float length, float angle) : base(xOrigin, yOrigin, colour, penSize, angle)
        {
            Length = length;
            TipLength = length / 5;
            Shaft = new Line(xOrigin, yOrigin, colour, penSize, length, angle);
            LeftTip = new Line(xOrigin, yOrigin, colour, penSize, TipLength, angle - 30);
            RightTip = new Line(xOrigin, yOrigin, colour, penSize, TipLength, angle + 30);
        }

        public override void Draw(float xMove, float yMove)
        {
            Shaft.Draw(xMove, yMove);
            LeftTip.Draw(xMove, yMove);
            RightTip.Draw(xMove, yMove);
        }

        public override void MoveTo(float xOrigin, float yOrigin)
        {
            Shaft.MoveTo(xOrigin, yOrigin);
            LeftTip.MoveTo(xOrigin, yOrigin);
            RightTip.MoveTo(xOrigin, yOrigin);
            base.MoveTo(xOrigin, yOrigin);
        }

        public override void Resize(float xUnits, float yUnits)
        {
            Length = xUnits;
            TipLength = xUnits / 5;
            Shaft.Resize(xUnits, yUnits);
            LeftTip = new Line(base.XOrigin, base.YOrigin, Shaft.Colour, base.PenSize, TipLength, Shaft.Orientation - 30);
            RightTip = new Line(base.XOrigin, base.YOrigin, Shaft.Colour, base.PenSize, TipLength, Shaft.Orientation + 30);
            Select();
        }

        public override void Select()
        {
            Shaft.Select();
            LeftTip.Select();
            RightTip.Select();
            base.IsSelected = true;
        }

        public override void Unselect()
        {
            Shaft.Unselect();
            LeftTip.Unselect();
            RightTip.Unselect();
            base.IsSelected = false;
        }

        public override void Colourise(Color colour)
        {
            Shaft.Colourise(colour);
            LeftTip.Colourise(colour);
            RightTip.Colourise(colour);
            base.Colour = colour;
        }

        public override void Rotate(float degrees)
        {
            //Debug.WriteLine($"Arrow Rotate called with argument degrees = {degrees}");
            Shaft.Rotate(degrees);
            LeftTip = new Line(base.XOrigin, base.YOrigin, Shaft.Colour, base.PenSize, TipLength, Shaft.Orientation - 30);
            RightTip = new Line(base.XOrigin, base.YOrigin, Shaft.Colour, base.PenSize, TipLength, Shaft.Orientation + 30);
            base.Rotate(degrees);
        }
    }
}
