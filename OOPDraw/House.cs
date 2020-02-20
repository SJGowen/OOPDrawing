namespace OOPDraw
{
    public class House : Shape
    {
        private float Width { get; set; }
        private float WallHeight { get; set; }
        private Rectangle Walls { get; set; }
        private EquilateralTriangle Roof { get; set; }

        public House(float xOrigin, float yOrigin, float width, float wallHeight) : base(xOrigin, yOrigin)
        {
            Width = width;
            WallHeight = wallHeight;
            Walls = new Rectangle(xOrigin, yOrigin, width, wallHeight);
            Roof = new EquilateralTriangle(xOrigin, yOrigin + wallHeight, width);
        }

        public override void Draw()
        {
            Walls.Draw();
            Roof.Draw();
        }

        public override void MoveTo(float xOrigin, float yOrigin)
        {
            base.MoveTo(xOrigin, yOrigin);
            Walls.MoveTo(xOrigin, yOrigin);
            Roof.MoveTo(xOrigin, yOrigin + WallHeight);
        }

        public override void Resize(float xUnits, float yUnits)
        {
            Width = xUnits;
            var yDiff = yUnits - WallHeight;
            WallHeight = yUnits;
            Walls.Resize(Width, WallHeight);
            Roof.Resize(Width, 0);
            Roof.MoveBy(0, yDiff);
        }

        public override void Select()
        {
            Walls.Select();
            Roof.Select();
        }

        public override void Unselect()
        {
            Walls.Unselect();
            Roof.Unselect();
        }
    }
}
