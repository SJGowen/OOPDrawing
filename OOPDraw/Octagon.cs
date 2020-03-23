using System.Drawing;

namespace OOPDraw
{
    internal class Octagon : RegularPolygon
    {
        public Octagon(int xOrigin, int yOrigin, Color colour, float lineWidth, int sideLength) : base(xOrigin, yOrigin, colour, lineWidth, sideLength, 8)
        {
        }
    }
}