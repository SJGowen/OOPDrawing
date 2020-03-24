using System.Drawing;

namespace OOPDraw
{
    internal class EquilateralTriangle : RegularPolygon
    {
        public EquilateralTriangle(float xOrigin, float yOrigin, Color colour, float penSize, float sideLength, float orientation) : base(xOrigin, yOrigin, colour, penSize, sideLength, 3, orientation)
        {
        }
    }
}
