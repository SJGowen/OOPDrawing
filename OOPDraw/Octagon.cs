using System.Drawing;

namespace OOPDraw
{
    internal class Octagon : RegularPolygon
    {
        public Octagon(int xOrigin, int yOrigin, Color colour, float penSize, float sideLength, float orientation) : base(xOrigin, yOrigin, colour, penSize, sideLength, 8, orientation)
        {
        }
    }
}