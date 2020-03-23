using System.Drawing;

namespace OOPDraw
{
    internal class EquilateralTriangle : RegularPolygon
    {
        public EquilateralTriangle(float xOrigin, float yOrigin, Color colour, float penSize, float sideLength) : base(xOrigin, yOrigin, colour, penSize, sideLength, 3)
        {
        }
    }
}
