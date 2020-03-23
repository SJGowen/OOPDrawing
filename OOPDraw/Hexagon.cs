using System.Drawing;

namespace OOPDraw
{
    internal class Hexagon : RegularPolygon
    {
        public Hexagon(int xOrigin, int yOrigin, Color colour, float penSize, int sideLength) : base(xOrigin, yOrigin, colour, penSize, sideLength, 6)
        {
        }
    }
}