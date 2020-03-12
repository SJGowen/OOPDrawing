using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colourBtn.BackColor = Turtle.DefaultColor;
        }

        private List<Shape> Shapes = new List<Shape>();

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var turtleX = e.X - Width / 2 + 8;
            var turtleY = Height / 2 - e.Y - 19;
            var selectedItem = (string)actionCombo.SelectedItem;
            var colour = colourBtn.BackColor;
            var lineWidth = (float)spinLineWidth.Value;
            if (selectedItem == "Draw Line")
            {
                AddShape(new Line(turtleX, turtleY, colour, lineWidth, 100, (float)angle.Value));
            }
            else if (selectedItem == "Draw Circle")
            {
                AddShape(new Circle(turtleX, turtleY, colour, lineWidth, 100));
            }
            else if (selectedItem == "Draw Equilateral Triangle")
            {
                AddShape(new EquilateralTriangle(turtleX, turtleY, colour, lineWidth, 100));
            }
            else if (selectedItem == "Draw Isosceles Triangle")
            {
                AddShape(new IsoscelesRightAngledTriangle(turtleX, turtleY, colour, lineWidth, 100));
            }
            else if (selectedItem == "Draw Square")
            {
                AddShape(new Rectangle(turtleX, turtleY, colour, lineWidth, 100, 100));
            }
            else if (selectedItem == "Draw Rectangle")
            {
                AddShape(new Rectangle(turtleX, turtleY, colour, lineWidth, 100, 50));
            }
            else if (selectedItem == "Draw House")
            {
                AddShape(new House(turtleX, turtleY, colour, lineWidth, 100, 80));
            }
            else if (selectedItem == "Draw Arrow")
            {
                AddShape(new Arrow(turtleX, turtleY, colour, lineWidth, 100, (float)angle.Value));
            }
            else if (selectedItem == "Move Shape")
            {
                ActiveShape().MoveTo(turtleX, turtleY);
            }
            else if (selectedItem == "Resize Shape")
            {
                ActiveShape().ResizeAbsolute(turtleX, turtleY);
            }

            DrawAll();
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
            var selectedItem = (string)actionCombo.SelectedItem;
            var visible = selectedItem == "Draw Line" || selectedItem == "Draw Arrow";
            angle.Visible = visible;
            angleLabel.Visible = visible;
            degreesLabel.Visible = visible;
        }

        private void colourBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colourBtn.BackColor = colorDialog1.Color;
            }
        }
    }
}
