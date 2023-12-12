namespace JengoEngine
{
    public class CircleCollider
    {
        private double radius;    // Радиус круга

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public CircleCollider(double radius)
        {
            this.radius = radius;
        }

        public bool isCollidesWithOtherCircle(Vector2 position, Circle other)
        {
            double deltaX = position.CordX - other.Position.CordX;
            double deltaY = position.CordY - other.Position.CordY;

            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            double radiusSum = this.radius + other.Collider.Radius;

            return radiusSum > distance;
        }
    }
}
