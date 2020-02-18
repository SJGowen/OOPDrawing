using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    public class Rectangle
    {
        public float XOrigin { get; private set; }
        public float YOrigin { get; private set; }
        public float Width { get; private set; }
        public float Height { get; private set; }

        public Rectangle(float xOrigin, float yOrigin, float width, float height)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
            Width = width;
            Height = height;
        }
    }
}
