using System.Drawing;

namespace OOPDraw
{
    internal class Heptagon : RegularPolygon
    {
        public Heptagon(int xOrigin, int yOrigin, Color colour, float lineWidth, int sideLength) : base(xOrigin, yOrigin, colour, lineWidth, sideLength, 7)
        {
        }
    }
}