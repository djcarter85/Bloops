namespace Bloops
{
    class Bloop
    {
        private Vector velocity;
        private double maxSpeed;

        public Bloop(double radius, double maxSpeed, Vector initialPosition)
        {
            this.Radius = radius;
            this.maxSpeed = maxSpeed;
            this.Location = initialPosition;
        }

        public Vector Location { get; private set; }
        public double Radius { get; private set; }

        public int Health { get; private set; } = 100;

        public bool Dead
        {
            get { return this.Health <= 0; }
        }

        public void Update()
        {
            this.velocity += new Vector
            {
                X = Helpers.NextRandom(-5, 5),
                Y = Helpers.NextRandom(-5, 5)
            };

            if (this.velocity.Length > this.maxSpeed)
            {
                this.velocity *= this.maxSpeed / this.velocity.Length;
            }

            this.Location += this.velocity;

            this.Health--;
        }
    }
}
