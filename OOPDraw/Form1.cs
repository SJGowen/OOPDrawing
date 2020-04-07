using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public bool MousePressed { get; set; }
        public bool MouseMoved { get; set; }
        public Point MouseDragStart { get; set; }
        public Point MouseDragStop { get; set; }

        public Form1()
        {
            InitializeComponent();
            ColourBtn.BackColor = Turtle.DefaultColor;
            ActionCombo.SelectedIndex = 0;
        }

        private readonly List<Shape> Shapes = new List<Shape>();

        private void DrawShape(MouseEventArgs e)
        {
            var selectedItem = (string)ActionCombo.SelectedItem;
            var xOrigin = leftToCentralPosition(e.X);
            int yOrigin = bottomToCentralPosition(e.Y);

            if (selectedItem.StartsWith("Draw "))
            {
                AddShape(shapeToAdd(xOrigin, yOrigin, selectedItem));
            }
            else if (selectedItem == "Move Shape")
            {
                ShapesMoveTo(xOrigin, yOrigin);
            }
            else if (selectedItem == "Resize Shape")
            {
                ShapesResizeAbsolute(xOrigin, yOrigin);
            }

            DrawAll();
        }

        private void ShapesResizeAbsolute(int xOrigin, int yOrigin)
        {
            foreach (var shape in Shapes)
            {
                shape.ResizeAbsolute(xOrigin, yOrigin);
            }
        }

        private void ShapesMoveTo(int xOrigin, int yOrigin)
        {
            foreach (var shape in Shapes)
            {
                shape.MoveTo(xOrigin, yOrigin);
            }
        }

        private int bottomToCentralPosition(int verticlePosition)
        {
            return Height / 2 - verticlePosition - 19;
        }

        private int leftToCentralPosition(int horizontalPosition)
        {
            return horizontalPosition - Width / 2 + 8;
        }

        private Shape shapeToAdd(int xOrigin, int yOrigin, string selectedItem)
        {
            var colour = ColourBtn.BackColor;
            var penSize = (float)PenSizeSpin.Value;
            var sideLength = (float)SideLengthSpin.Value;
            var orientation = (float)OrientationSpin.Value;
            switch (selectedItem)
            {
                case "Draw Circle":
                    return new Circle(xOrigin, yOrigin, colour, penSize, sideLength, orientation);
                case "Draw Isosceles Triangle":
                    return new IsoscelesRightAngledTriangle(xOrigin, yOrigin, colour, penSize, sideLength, orientation);
                case "Draw Equilateral Triangle":
                    return new EquilateralTriangle(xOrigin, yOrigin, colour, penSize, sideLength, orientation);
                case "Draw Square":
                    return new Square(xOrigin, yOrigin, colour, penSize, sideLength, orientation);
                case "Draw Pentagon":
                    return new Pentagon(xOrigin, yOrigin, colour, penSize, sideLength, orientation);
                case "Draw Hexagon":
                    return new Hexagon(xOrigin, yOrigin, colour, penSize, sideLength, orientation);
                case "Draw Heptagon":
                    return new Heptagon(xOrigin, yOrigin, colour, penSize, sideLength, orientation);
                case "Draw Octagon":
                    return new Octagon(xOrigin, yOrigin, colour, penSize, sideLength, orientation);
                case "Draw Rectangle":
                    return new Rectangle(xOrigin, yOrigin, colour, penSize, sideLength, sideLength / 2, orientation);
                case "Draw House":
                    return new House(xOrigin, yOrigin, colour, penSize, sideLength, sideLength / 10 * 8, orientation);
                case "Draw Arrow":
                    return new Arrow(xOrigin, yOrigin, colour, penSize, sideLength, orientation);
                default: // "Draw Line":
                    return new Line(xOrigin, yOrigin, colour, penSize, sideLength, orientation);
            }
        }

        private void AddShape(Shape shape)
        {
            ShapesUnselectAll();
            Shapes.Add(shape);
        }

        public void DrawAll()
        {
            Turtle.Dispose();
            foreach (var shape in Shapes)
            {
                shape.Draw();
            }
        }

        private void UpdateGuiToMatchObjectSelected()
        {
            var shapeSelectedIndex = 0;
            var shapeSelectedCount = 0;
            for (int i = 0; i < Shapes.Count; i++)
            {
                if (Shapes[i].IsSelected) 
                {
                    shapeSelectedCount += 1;
                    shapeSelectedIndex = i;
                }
            }

            if (shapeSelectedCount == 1) 
            {
                if (ColourBtn.BackColor != Shapes[shapeSelectedIndex].Colour) ColourBtn.BackColor = Shapes[shapeSelectedIndex].Colour;
                if (OrientationSpin.Value != (decimal)Shapes[shapeSelectedIndex].Orientation) OrientationSpin.Value = (decimal)Shapes[shapeSelectedIndex].Orientation;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SideLengthSpin.Value = getSideLengthValue((string)ActionCombo.SelectedItem);
        }

        private decimal getSideLengthValue(string selectedItem)
        {
            switch (selectedItem)
            {
                case "Draw Circle":
                    return 5;
                case "Draw Square":
                    return 90;
                case "Draw Pentagon":
                    return 80;
                case "Draw Hexagon":
                    return 70;
                case "Draw Heptagon":
                    return 60;
                case "Draw Octagon":
                    return 50;
                default:
                    return 100;
            }
        }

        private void ColourBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColourBtn.BackColor = colorDialog1.Color;
                foreach (var shape in Shapes)
                {
                    shape.Colourise(colorDialog1.Color);
                }

                DrawAll();
            }
        }

        private void OrientationSpin_ValueChanged(object sender, EventArgs e)
        {
            //Debug.WriteLine($"SpinValueChanged event fired");
            foreach (var shape in Shapes)
            {
                shape.Rotate((float)OrientationSpin.Value);
            }

            DrawAll();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you wish to delete the Active Object(s)", "Delete Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = Shapes.Count - 1; i > -1; i--)
                {
                    if (Shapes[i].IsSelected) Shapes.Remove(Shapes[i]);
                }
            }
        }

        private void ShapesUnselectAll()
        {
            foreach (var shape in Shapes)
            {
                shape.Unselect();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MousePressed)
            {
                if (!MouseMoved)
                {
                    MouseMoved = true;
                    MouseDragStart = new Point(e.X, e.Y);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MousePressed = true;
            MouseMoved = false;
            ShapesUnselectAll();
            //Debug.WriteLine($"MouseDown event fired with mouse co-ords [{e.X}, {e.Y}]");
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MousePressed = false;
            MouseDragStop = new Point(e.X, e.Y);
            //Debug.WriteLine($"MouseUp event fired [{MouseDragStart.X}, {MouseDragStart.Y}] [{MouseDragStop.X}, {MouseDragStop.Y}]");
            SelectShapes(MouseDragStart.X, MouseDragStart.Y, MouseDragStop.X, MouseDragStop.Y);
            if (!MouseMoved) DrawShape(e); else DrawAll();
            UpdateGuiToMatchObjectSelected();
        }

        public void SelectShapes(int startX, int startY, int stopX, int stopY)
        {
            //Debug.WriteLine($"SelectShapes called with Params [{minX}, {minY}] [{maxX}, {maxY}]");
            var nakovMinX = Math.Min(leftToCentralPosition(startX), leftToCentralPosition(stopX));
            var nakovMaxX = Math.Max(leftToCentralPosition(startX), leftToCentralPosition(stopX));
            var nakovMinY = Math.Min(bottomToCentralPosition(startY), bottomToCentralPosition(stopY));
            var nakovMaxY = Math.Max(bottomToCentralPosition(startY), bottomToCentralPosition(stopY));
            //Debug.WriteLine($"SelectShapes called with Nakov Params [{nakovMinX}, {nakovMinY}] [{nakovMaxX}, {nakovMaxY}]");
            foreach (var shape in Shapes)
            {
                if (shape.XOrigin >= nakovMinX && shape.YOrigin >= nakovMinY && shape.XOrigin <= nakovMaxX && shape.YOrigin <= nakovMaxY)
                    shape.Select();
                //Debug.WriteLine($"Shape selected = {shape.Selected} as it has co-ords X = {shape.XOrigin}, Y = {shape.YOrigin}");
            }
        }
    }
}
