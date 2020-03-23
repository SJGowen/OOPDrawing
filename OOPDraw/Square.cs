using System.Drawing;

namespace OOPDraw
{
    internal class Square : RegularPolygon
    {
        public Square(int xOrigin, int yOrigin, Color colour, float lineWidth, int sideLength) : base(xOrigin, yOrigin, colour, lineWidth, sideLength, 4)
        {
        }
    }
}