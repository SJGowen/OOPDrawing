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
            string selectedItem = (string) comboBox1.SelectedItem;
            if (selectedItem == "Draw Triangle")
            {
                Turtle.Rotate(30);
                for (int i = 0; i < 3; i++)
                {
                    Turtle.Forward(50);
                    Turtle.Rotate(120);
                }
            }
        }
    }
}
