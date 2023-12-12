namespace JengoEngine
{
    public class Circle
    {
        private Vector2 position; // Позиция игрока
        private CircleCollider collider;

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public CircleCollider Collider
        {
            get { return collider; }
            set { collider = value; }
        }

        public Circle(Vector2 position, double radius) 
        {
            this.position = position;
            this.collider = new CircleCollider(radius);
        }

        public bool Update(Circle other)
        {
            return collider.isCollidesWithOtherCircle(position, other);
        }
    }
}
