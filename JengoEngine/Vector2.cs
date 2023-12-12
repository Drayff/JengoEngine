namespace JengoEngine
{
    public class Vector2
    {
        private double cordX;
        private double cordY;

        public double CordX
        {
            get { return cordX; }
            set { cordX = value; }
        }

        public double CordY
        {
            get { return cordY; }
            set { cordY = value; }
        }

        public Vector2(double cordX, double cordY)
        {
            this.cordX = cordX;
            this.cordY = cordY;
        }

        public static Vector2 operator +(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2(Math.Round(vector1.cordX + vector2.cordX, 2), Math.Round(vector1.cordY + vector2.cordY, 2));
        }

        public static Vector2 operator *(Vector2 vector, float scalar)
        {
            return new Vector2(vector.cordX * scalar, vector.cordY * scalar);
        }

        public override string ToString()
        {
            return $"{{{cordX}, {cordY}}}";
        }

        public double[] ToArray()
        {
            return new double[] { cordX, cordY };
        }
    }
}
