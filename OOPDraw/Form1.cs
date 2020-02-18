﻿using Nakov.TurtleGraphics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Shape> shapes = new List<Shape>();

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            float turtleX = e.X - Width / 2 + 8;
            float turtleY = Height / 2 - e.Y - 19;
            string selectedItem = (string)comboBox1.SelectedItem;
            if (selectedItem == "Draw Triangle")
            {
                var triangle = new EquilateralTriangle(turtleX, turtleY, 100);
                shapes.Add(triangle);
            }

            if (selectedItem == "Draw Rectangle")
            {
                var rectangle = new Rectangle(turtleX, turtleY, 100, 50);
                shapes.Add(rectangle);
            }

            DrawAll();
        }

        public void DrawAll()
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
   }
}
