using Nakov.TurtleGraphics;
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
                activeShapeNumber = shapes.Count - 1;
            }
            else if (selectedItem == "Draw Rectangle")
            {
                var rectangle = new Rectangle(turtleX, turtleY, 100, 50);
                shapes.Add(rectangle);
            }
            else if (selectedItem == "Move Shape")
            {
                ActiveShape().MoveTo(turtleX, turtleY);
                activeShapeNumber = shapes.Count - 1;
            }

            DrawAll();
        }

        public void DrawAll()
        {
            Turtle.Dispose();
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

        private int activeShapeNumber = 0;

        private Shape ActiveShape()
        {
            return shapes[activeShapeNumber];
        }

        private void NextShape_Click(object sender, System.EventArgs e)
        {
            activeShapeNumber++;
            if (activeShapeNumber >= shapes.Count) activeShapeNumber = 0;
        }

        private void PreviousShape_Click(object sender, System.EventArgs e)
        {
            activeShapeNumber--;
            if (activeShapeNumber < 0) activeShapeNumber = shapes.Count - 1;

        }
    }
}
