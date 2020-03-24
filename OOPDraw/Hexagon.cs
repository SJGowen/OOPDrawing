using System.Drawing;

namespace OOPDraw
{
    internal class Hexagon : RegularPolygon
    {
        public Hexagon(int xOrigin, int yOrigin, Color colour, float penSize, float sideLength, float orientation) : base(xOrigin, yOrigin, colour, penSize, sideLength, 6, orientation)
        {
        }
    }
}