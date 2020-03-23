using System.Drawing;

namespace OOPDraw
{
    internal class Hexagon : RegularPolygon
    {
        public Hexagon(int xOrigin, int yOrigin, Color colour, float lineWidth, int sideLength) : base(xOrigin, yOrigin, colour, lineWidth, sideLength, 6)
        {
        }
    }
}