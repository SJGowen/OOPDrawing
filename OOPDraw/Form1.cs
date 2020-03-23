using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ColourBtn.BackColor = Turtle.DefaultColor;
            ActionCombo.SelectedIndex = 0;
        }

        private List<Shape> Shapes = new List<Shape>();

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedItem = (string)ActionCombo.SelectedItem;
            var xOrigin = e.X - Width / 2 + 8;
            var yOrigin = Height / 2 - e.Y - 19;

            if (selectedItem.StartsWith("Draw "))
            {
                AddShape(shapeToAdd(xOrigin, yOrigin, selectedItem));
            }
            else if (selectedItem == "Move Shape")
            {
                ActiveShape().MoveTo(xOrigin, yOrigin);
            }
            else if (selectedItem == "Resize Shape")
            {
                ActiveShape().ResizeAbsolute(xOrigin, yOrigin);
            }

            DrawAll();
        }

        private Shape shapeToAdd(int xOrigin, int yOrigin, string selectedItem)
        {
            var colour = ColourBtn.BackColor;
            var penSize = (float)PenSizeSpin.Value;
            var angle = (float)AngleSpin.Value;
            switch (selectedItem)
            {
                case "Draw Circle": return new Circle(xOrigin, yOrigin, colour, penSize, 100);
                case "Draw Isosceles Triangle": return new IsoscelesRightAngledTriangle(xOrigin, yOrigin, colour, penSize, 100);
                case "Draw Equilateral Triangle": return new EquilateralTriangle(xOrigin, yOrigin, colour, penSize, 100);
                case "Draw Square": return new Square(xOrigin, yOrigin, colour, penSize, 90);
                case "Draw Pentagon": return new Pentagon(xOrigin, yOrigin, colour, penSize, 80);
                case "Draw Hexagon": return new Hexagon(xOrigin, yOrigin, colour, penSize, 70);
                case "Draw Heptagon": return new Heptagon(xOrigin, yOrigin, colour, penSize, 60);
                case "Draw Octagon": return new Octagon(xOrigin, yOrigin, colour, penSize, 50);
                case "Draw Rectangle": return new Rectangle(xOrigin, yOrigin, colour, penSize, 100, 50);
                case "Draw House": return new House(xOrigin, yOrigin, colour, penSize, 100, 80);
                case "Draw Arrow": return new Arrow(xOrigin, yOrigin, colour, penSize, 100, angle);
                default: return new Line(xOrigin, yOrigin, colour, penSize, 100, angle);
            }
        }

        private void AddShape(Shape shape)
        {
            if (Shapes.Count > 0)
            {
                ActiveShape().Unselect();
            }
            Shapes.Add(shape);
            activeShapeNumber = Shapes.Count - 1;
            ActiveShape().Select();
        }

        public void DrawAll()
        {
            Turtle.Dispose();
            foreach (var shape in Shapes)
            {
                shape.Draw();
            }
        }

        private int activeShapeNumber = 0;

        private Shape ActiveShape()
        {
            return Shapes[activeShapeNumber];
        }

        private void NextShape_Click(object sender, System.EventArgs e)
        {
            ActiveShape().Unselect();
            activeShapeNumber++;
            if (activeShapeNumber >= Shapes.Count) activeShapeNumber = 0;
            ActiveShape().Select();
            DrawAll();
        }

        private void PreviousShape_Click(object sender, System.EventArgs e)
        {
            ActiveShape().Unselect();
            activeShapeNumber--;
            if (activeShapeNumber < 0) activeShapeNumber = Shapes.Count - 1;
            ActiveShape().Select();
            DrawAll();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (string)ActionCombo.SelectedItem;
            var visible = selectedItem == "Draw Line" || selectedItem == "Draw Arrow";
            AngleSpin.Visible = visible;
            angleLabel.Visible = visible;
            degreesLabel.Visible = visible;
        }

        private void colourBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColourBtn.BackColor = colorDialog1.Color;
            }
        }
    }
}
