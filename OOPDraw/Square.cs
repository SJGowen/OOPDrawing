using System.Drawing;

namespace OOPDraw
{
    internal class Square : RegularPolygon
    {
        public Square(int xOrigin, int yOrigin, Color colour, float penSize, float sideLength, float orientation) : base(xOrigin, yOrigin, colour, penSize, sideLength, 4, orientation)
        {
        }
    }
}