using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    public class EquilateralTriangle
    {
        public float XOrigin { get; private set; }
        public float YOrigin { get; private set; }
        public float SideLength { get; private set; }

        public EquilateralTriangle(float xOrigin, float yOrigin, float sideLength)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
            SideLength = sideLength;
        }
    }
}
