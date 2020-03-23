using System.Drawing;

namespace OOPDraw
{
    internal class Octagon : RegularPolygon
    {
        public Octagon(int xOrigin, int yOrigin, Color colour, float penSize, int sideLength) : base(xOrigin, yOrigin, colour, penSize, sideLength, 8)
        {
        }
    }
}