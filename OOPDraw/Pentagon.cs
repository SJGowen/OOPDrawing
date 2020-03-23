using System.Drawing;

namespace OOPDraw
{
    internal class Pentagon : RegularPolygon
    {
        public Pentagon(int xOrigin, int yOrigin, Color colour, float penSize, float sideLength) : base(xOrigin, yOrigin, colour, penSize, sideLength, 5)
        {
        }
    }
}