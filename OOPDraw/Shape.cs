namespace OOPDraw
{
    public abstract class Shape
    {
        protected float XOrigin { get; set; }
        protected float YOrigin { get; set; }

        public abstract void Draw();

        public void MoveTo(float x, float y)
        {
            XOrigin = x;
            YOrigin = y;
        }
    }
}
