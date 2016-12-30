namespace Bloops
{
    class Bloop
    {
        private const int RadiusIndex = 0;
        private const int SpeedIndex = 1;

        private readonly Parameters parameters;

        private readonly double maxSpeed;
        private readonly Dna dna;

        private Vector velocity;

        public Bloop(Dna dna, Parameters parameters, Vector initialPosition)
        {
            this.dna = dna;
            this.Radius = dna.Genes[RadiusIndex] * 30;
            this.maxSpeed = 10 * (1 - dna.Genes[SpeedIndex]);

            this.parameters = parameters;

            this.Location = initialPosition;
        }

        public Vector Location { get; private set; }
        public double Radius { get; private set; }

        public int FoodEaten { get; private set; }

        public void Update(int maxX, int maxY)
        {
            this.velocity += new Vector
            {
                X = Helpers.NextRandom(-5, 5),
                Y = Helpers.NextRandom(-5, 5)
            };

            this.velocity.Limit(this.maxSpeed);

            this.Location += this.velocity;

            this.Location = this.Location.CheckEdges(maxX, maxY);
        }

        public bool Eat(Vector food)
        {
            if (this.Location.DistanceTo(food) <= this.Radius)
            {
                this.FoodEaten++;
                return true;
            }

            return false;
        }
    }
}
