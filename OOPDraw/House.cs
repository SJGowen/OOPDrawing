namespace OOPDraw
{
    public class House : Shape
    {
        private float WallWidth { get; set; }
        private float WallHeight { get; set; }
        private Rectangle Walls { get; set; }
        private EquilateralTriangle Roof { get; set; }
        private Rectangle Door { get; set; }
        private Rectangle WindowDownstairsLeft { get; set; }
        private Rectangle WindowUpstairsLeft { get; set; }
        private Rectangle WindowDownstairsRight { get; set; }
        private Rectangle WindowUpstairsRight { get; set; }

        public House(float xOrigin, float yOrigin, float width, float wallHeight) : base(xOrigin, yOrigin)
        {
            WallWidth = width;
            WallHeight = wallHeight;
            Walls = new Rectangle(xOrigin, yOrigin, WallWidth, WallHeight);
            Roof = new EquilateralTriangle(xOrigin, yOrigin + WallHeight, WallWidth);
            Door = new Rectangle(xOrigin + WallWidth / 2 - WallWidth / 10, yOrigin, WallWidth / 5, WallHeight / 2 - WallHeight / 8);
            WindowDownstairsLeft = new Rectangle(xOrigin + WallWidth / 12, yOrigin + WallHeight / 8, WallWidth / 4, WallHeight / 4);
            WindowUpstairsLeft = new Rectangle(xOrigin + WallWidth / 12, yOrigin + WallHeight / 8 * 5, WallWidth / 4, WallHeight / 4);
            WindowDownstairsRight = new Rectangle(xOrigin + WallWidth / 12 * 8, yOrigin + WallHeight / 8, WallWidth / 4, WallHeight / 4);
            WindowUpstairsRight = new Rectangle(xOrigin + WallWidth / 12 * 8, yOrigin + WallHeight / 8 * 5, WallWidth / 4, WallHeight / 4);
        }

        public override void Draw()
        {
            Walls.Draw();
            Roof.Draw();
            Door.Draw();
            WindowDownstairsLeft.Draw();
            WindowUpstairsLeft.Draw();
            WindowDownstairsRight.Draw();
            WindowUpstairsRight.Draw();
        }

        public override void MoveTo(float xOrigin, float yOrigin)
        {
            base.MoveTo(xOrigin, yOrigin);
            Walls.MoveTo(xOrigin, yOrigin);
            Roof.MoveTo(xOrigin, yOrigin + WallHeight);
            Door.MoveTo(xOrigin + WallWidth / 2 - WallWidth / 10, yOrigin);
            WindowDownstairsLeft.MoveTo(xOrigin + WallWidth / 12, yOrigin + WallHeight / 8);
            WindowUpstairsLeft.MoveTo(xOrigin + WallWidth / 12, yOrigin + WallHeight / 8 * 5);
            WindowDownstairsRight.MoveTo(xOrigin + WallWidth / 12 * 8, yOrigin + WallHeight / 8);
            WindowUpstairsRight.MoveTo(xOrigin + WallWidth / 12 * 8, yOrigin + WallHeight / 8 * 5);
        }

        public override void Resize(float xUnits, float yUnits)
        {
            var xDiff = xUnits - WallWidth;
            WallWidth = xUnits;
            var yDiff = yUnits - WallHeight;
            WallHeight = yUnits;
            Walls.Resize(WallWidth, WallHeight);
            Roof.Resize(WallWidth, 0);
            Roof.MoveBy(0, yDiff);
            Door.Resize(WallWidth / 5, WallHeight / 2 - WallHeight / 8);
            Door.MoveBy(xDiff / 2 - xDiff / 10, 0);
            WindowDownstairsLeft.Resize(WallWidth / 4, WallHeight / 4);
            WindowDownstairsLeft.MoveBy(xDiff / 12, yDiff / 8);
            WindowUpstairsLeft.Resize(WallWidth / 4, WallHeight / 4);
            WindowUpstairsLeft.MoveBy(xDiff / 12, yDiff / 8 * 5);
            WindowDownstairsRight.Resize(WallWidth / 4, WallHeight / 4);
            WindowDownstairsRight.MoveBy(xDiff / 12 * 8, yDiff / 8);
            WindowUpstairsRight.Resize(WallWidth / 4, WallHeight / 4);
            WindowUpstairsRight.MoveBy(xDiff / 12 * 8, yDiff / 8 * 5);
        }

        public override void Select()
        {
            Walls.Select();
            Roof.Select();
            Door.Select();
            WindowDownstairsLeft.Select();
            WindowUpstairsLeft.Select();
            WindowDownstairsRight.Select();
            WindowUpstairsRight.Select();
        }

        public override void Unselect()
        {
            Walls.Unselect();
            Roof.Unselect();
            Door.Unselect();
            WindowDownstairsLeft.Unselect();
            WindowUpstairsLeft.Unselect();
            WindowDownstairsRight.Unselect();
            WindowUpstairsRight.Unselect();
        }
    }
}
