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
                AddShape(new EquilateralTriangle(turtleX, turtleY, 100));
            }
            else if (selectedItem == "Draw Rectangle")
            {
                AddShape(new Rectangle(turtleX, turtleY, 100, 50));
            }
            else if (selectedItem == "Move Shape")
            {
                ActiveShape().MoveTo(turtleX, turtleY);
            }
            else if (selectedItem == "Resize Shape")
            {
                ActiveShape().Resize(turtleX, turtleY);
            }

            DrawAll();
        }

        private void AddShape(Shape shape)
        {
            if (shapes.Count > 0) ActiveShape().Unselect();
            shapes.Add(shape);
            activeShapeNumber = shapes.Count - 1;
            ActiveShape().Select();
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
            ActiveShape().Unselect();
            activeShapeNumber++;
            if (activeShapeNumber >= shapes.Count) activeShapeNumber = 0;
            ActiveShape().Select();
            DrawAll();
        }

        private void PreviousShape_Click(object sender, System.EventArgs e)
        {
            ActiveShape().Unselect();
            activeShapeNumber--;
            if (activeShapeNumber < 0) activeShapeNumber = shapes.Count - 1;
            ActiveShape().Select();
            DrawAll();
        }
    }
}
