using System.Drawing;

namespace OOPDraw
{
    public class House : Shape, IColourable
    {
        private float WallWidth { get; set; }
        private float WallHeight { get; set; }
        private float DoorWidth { get => WallWidth / 5; }
        private float DoorHeight { get => WallHeight / 2 - WallHeight / 10; }
        private float WindowWidth { get => WallWidth / 4; }
        private float WindowHeight { get => WallHeight / 4; }
        private Rectangle Walls { get; set; }
        private IsoscelesRightAngledTriangle Roof { get; set; }
        private Rectangle Door { get; set; }
        private Rectangle WindowDownstairsLeft { get; set; }
        private Rectangle WindowUpstairsLeft { get; set; }
        private Rectangle WindowDownstairsRight { get; set; }
        private Rectangle WindowUpstairsRight { get; set; }

        public House(float xOrigin, float yOrigin, Color colour, float penSize, float wallWidth, float wallHeight, float orientation) : base(xOrigin, yOrigin, colour, penSize, orientation)
        {
            //Debug.WriteLine($"House Constructor called with arguments {xOrigin}, {yOrigin}, {colour}, {penSize}, {wallWidth}, {wallHeight}, {orientation}");
            WallWidth = wallWidth;
            WallHeight = wallHeight;
            Walls = new Rectangle(xOrigin, yOrigin, colour, penSize, WallWidth, WallHeight, orientation);
            Roof = new IsoscelesRightAngledTriangle(xOrigin, yOrigin, colour, penSize, WallWidth, orientation);
            Door = new Rectangle(xOrigin, yOrigin, colour, penSize, DoorWidth, DoorHeight, orientation);
            WindowDownstairsLeft = new Rectangle(xOrigin, yOrigin, colour, penSize, WindowWidth, WindowHeight, orientation);
            WindowUpstairsLeft = new Rectangle(xOrigin, yOrigin, colour, penSize, WindowWidth, WindowHeight, orientation);
            WindowDownstairsRight = new Rectangle(xOrigin, yOrigin, colour, penSize, WindowWidth, WindowHeight, orientation);
            WindowUpstairsRight = new Rectangle(xOrigin, yOrigin, colour, penSize, WindowWidth, WindowHeight, orientation);
        }

        public override void Draw(float xMove, float yMove)
        {
            //Debug.WriteLine($"House Draw called with arguments {xMove}, {yMove}");
            Walls.Draw(xMove, yMove);
            Roof.Draw(0, WallHeight);
            Door.Draw(WallWidth / 2 - WallWidth / 10, 0);
            WindowDownstairsLeft.Draw(WallWidth / 12, WallHeight / 8);
            WindowUpstairsLeft.Draw(WallWidth / 12, WallHeight / 8 * 5);
            WindowDownstairsRight.Draw(WallWidth / 12 * 8, WallHeight / 8);
            WindowUpstairsRight.Draw(WallWidth / 12 * 8, WallHeight / 8 * 5);
        }

        public override void MoveTo(float xOrigin, float yOrigin)
        {
            //Debug.WriteLine($"House MoveTo called with arguments {xOrigin}, {yOrigin}");
            Walls.MoveTo(xOrigin, yOrigin);
            Roof.MoveTo(xOrigin, yOrigin);
            Door.MoveTo(xOrigin, yOrigin);
            WindowDownstairsLeft.MoveTo(xOrigin, yOrigin);
            WindowUpstairsLeft.MoveTo(xOrigin, yOrigin);
            WindowDownstairsRight.MoveTo(xOrigin, yOrigin);
            WindowUpstairsRight.MoveTo(xOrigin, yOrigin);
            base.MoveTo(xOrigin, yOrigin);
        }

        public override void Resize(float xUnits, float yUnits)
        {
            WallWidth = xUnits;
            WallHeight = yUnits;
            Walls.Resize(WallWidth, WallHeight);
            Roof = new IsoscelesRightAngledTriangle(base.XOrigin, base.YOrigin, base.Colour, base.PenSize, WallWidth, base.Orientation);
            Door = new Rectangle(base.XOrigin, base.YOrigin, base.Colour, base.PenSize, DoorWidth, DoorHeight, base.Orientation);
            WindowDownstairsLeft = new Rectangle(base.XOrigin, base.YOrigin, base.Colour, base.PenSize, WindowWidth, WindowHeight, base.Orientation);
            WindowUpstairsLeft = new Rectangle(base.XOrigin, base.YOrigin, base.Colour, base.PenSize, WindowWidth, WindowHeight, base.Orientation);
            WindowDownstairsRight = new Rectangle(base.XOrigin, base.YOrigin, base.Colour, base.PenSize, WindowWidth, WindowHeight, base.Orientation);
            WindowUpstairsRight = new Rectangle(base.XOrigin, base.YOrigin, base.Colour, base.PenSize, WindowWidth, WindowHeight, base.Orientation);
            Select();
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
            base.IsSelected = true;
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
            base.IsSelected = false;
        }

        public override void Colourise(Color colour)
        {
            Walls.Colourise(colour);
            Roof.Colourise(colour);
            Door.Colourise(colour);
            WindowDownstairsLeft.Colourise(colour);
            WindowUpstairsLeft.Colourise(colour);
            WindowDownstairsRight.Colourise(colour);
            WindowUpstairsRight.Colourise(colour);
            base.Colour = colour;
        }

        public override void Rotate(float degrees)
        {
            Walls.Rotate(degrees);
            Roof.Rotate(degrees);
            Door.Rotate(degrees);
            WindowDownstairsLeft.Rotate(degrees);
            WindowUpstairsLeft.Rotate(degrees);
            WindowDownstairsRight.Rotate(degrees);
            WindowUpstairsRight.Rotate(degrees);
            base.Rotate(degrees);
        }
    }
}
