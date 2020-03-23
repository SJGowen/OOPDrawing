using System.Drawing;

namespace OOPDraw
{
    internal class EquilateralTriangle : RegularPolygon
    {
        public EquilateralTriangle(float xOrigin, float yOrigin, Color colour, float lineWidth, float sideLength) : base(xOrigin, yOrigin, colour, lineWidth, sideLength, 3)
        {
        }
    }
}
