﻿using Nakov.TurtleGraphics;
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
            var sideLength = (float)SideLengthSpin.Value;
            switch (selectedItem)
            {
                case "Draw Circle": 
                     return new Circle(xOrigin, yOrigin, colour, penSize, sideLength);
                case "Draw Isosceles Triangle": 
                    return new IsoscelesRightAngledTriangle(xOrigin, yOrigin, colour, penSize, sideLength);
                case "Draw Equilateral Triangle": 
                    return new EquilateralTriangle(xOrigin, yOrigin, colour, penSize, sideLength);
                case "Draw Square": 
                    return new Square(xOrigin, yOrigin, colour, penSize, sideLength);
                case "Draw Pentagon": 
                    return new Pentagon(xOrigin, yOrigin, colour, penSize, sideLength);
                case "Draw Hexagon": 
                    return new Hexagon(xOrigin, yOrigin, colour, penSize, sideLength);
                case "Draw Heptagon": 
                    return new Heptagon(xOrigin, yOrigin, colour, penSize, sideLength);
                case "Draw Octagon": 
                    return new Octagon(xOrigin, yOrigin, colour, penSize, sideLength);
                case "Draw Rectangle": 
                    return new Rectangle(xOrigin, yOrigin, colour, penSize, sideLength, sideLength / 2);
                case "Draw House": 
                    return new House(xOrigin, yOrigin, colour, penSize, sideLength, sideLength / 10 * 8);
                case "Draw Arrow": 
                    return new Arrow(xOrigin, yOrigin, colour, penSize, sideLength, angle);
                default: 
                    return new Line(xOrigin, yOrigin, colour, penSize, sideLength, angle);
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
            AngleLabel.Visible = visible;
            DegreesLabel.Visible = visible;
            SideLengthSpin.Value = getSideLengthValue(selectedItem);
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

        private void colourBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColourBtn.BackColor = colorDialog1.Color;
            }
        }
    }
}
