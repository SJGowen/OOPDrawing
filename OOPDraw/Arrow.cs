using System.Drawing;

namespace OOPDraw
{
    public class Arrow : Shape
    {
        private Line Shaft { get; set; }
        private Line LeftTip { get; set; }
        private Line RightTip { get; set; }

        public Arrow(float xOrigin, float yOrigin, Color colour, float lineWidth, float length, float angle) : base(xOrigin, yOrigin, colour, lineWidth)
        {
            Shaft = new Line(xOrigin, yOrigin, colour, lineWidth, length, angle);
            LeftTip = new Line(xOrigin, yOrigin, colour, lineWidth, 20, angle - 30);
            RightTip = new Line(xOrigin, yOrigin, colour, lineWidth, 20, angle + 30);
        }

        public override void Draw()
        {
            Shaft.Draw();
            LeftTip.Draw();
            RightTip.Draw();
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

    }
}
