namespace JengoEngine
{
    public class Player
    {
        private Vector2 position;     // Позиция игрока
        private Vector2 velocity;     // Направление движения игрока
        private Vector2 acceleration; // Ускорение игрока

        // Геттеры и Сеттеры
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Vector2 Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public Vector2 Acceleration
        {
            get { return acceleration; }
            set { acceleration = value; }
        }
        // --------------------

        // Конструктор:
        // Player player = new Player(position, velocity, acceleration);
        public Player(Vector2 position, Vector2 velocity, Vector2 acceleration)
        {
            this.position = position;
            this.velocity = velocity;
            this.acceleration = acceleration;
        }

        // Метод для обновления положения игрока на основе скорости и ускорения
        public void Update(int deltaTime)
        {
            // Обновление скорости на основе ускорения
            velocity = velocity + (acceleration * deltaTime);

            // Обновление положения на основе скорости
            position = position + (velocity * deltaTime);
        }
    }
}
