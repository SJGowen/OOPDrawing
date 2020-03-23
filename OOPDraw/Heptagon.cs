using System.Drawing;

namespace OOPDraw
{
    internal class Heptagon : RegularPolygon
    {
        public Heptagon(int xOrigin, int yOrigin, Color colour, float penSize, float sideLength) : base(xOrigin, yOrigin, colour, penSize, sideLength, 7)
        {
        }
    }
}