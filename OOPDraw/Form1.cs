using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            float turtleX = e.X - Width / 2 + 8;
            float turtleY = Height / 2 - e.Y - 19;
            string selectedItem = (string)comboBox1.SelectedItem;
            if (selectedItem == "Draw Triangle")
            {
                var triangle = new EquilateralTriangle(turtleX, turtleY, 100);
                DrawTriangle(triangle);
            }

            if (selectedItem == "Draw Rectangle")
            {
                var rectangle = new Rectangle(turtleX, turtleY, 100, 50);
                DrawRectangle(rectangle);
            }
        }

        private void DrawTriangle(EquilateralTriangle triangle)
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;
            Turtle.X = triangle.XOrigin;
            Turtle.Y = triangle.YOrigin;
            Turtle.Rotate(30);
            for (int i = 0; i < 3; i++)
            {
                Turtle.Forward(triangle.SideLength);
                Turtle.Rotate(120);
            }
        }
 
        private void DrawRectangle(Rectangle rectangle)
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;
            Turtle.X = rectangle.XOrigin;
            Turtle.Y = rectangle.YOrigin;
            for (int i = 0; i < 2; i++)
            {
                Turtle.Forward(rectangle.Height);
                Turtle.Rotate(90);
                Turtle.Forward(rectangle.Width);
                Turtle.Rotate(90);
            }
        }
   }
}
