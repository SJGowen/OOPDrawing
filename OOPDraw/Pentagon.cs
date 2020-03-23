using System.Drawing;

namespace OOPDraw
{
    internal class Pentagon : RegularPolygon
    {
        public Pentagon(int xOrigin, int yOrigin, Color colour, float lineWidth, int sideLength) : base(xOrigin, yOrigin, colour, lineWidth, sideLength, 5)
        {
        }
    }
}