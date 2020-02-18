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
                triangle.Draw();
            }

            if (selectedItem == "Draw Rectangle")
            {
                var rectangle = new Rectangle(turtleX, turtleY, 100, 50);
                rectangle.Draw();
            }
        }
   }
}
