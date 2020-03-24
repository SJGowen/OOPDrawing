using System.Drawing;

namespace OOPDraw
{
    internal class Pentagon : RegularPolygon
    {
        public Pentagon(int xOrigin, int yOrigin, Color colour, float penSize, float sideLength, float orientation) : base(xOrigin, yOrigin, colour, penSize, sideLength, 5, orientation)
        {
        }
    }
}