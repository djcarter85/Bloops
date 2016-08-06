namespace Bloops
{
    class Bloop
    {
        private readonly double reproductionRate;
        private readonly double mutationRate;

        private readonly double maxSpeed;
        private readonly Dna dna;

        private Vector velocity;

        public Bloop(Dna dna, double reproductionRate, double mutationRate, Vector initialPosition = default(Vector))
        {
            this.dna = dna;
            this.Radius = dna.Gene * 30;
            this.maxSpeed = 10 * (1 - dna.Gene);

            this.reproductionRate = reproductionRate;
            this.mutationRate = mutationRate;

            this.Location = initialPosition;
        }

        public Vector Location { get; private set; }
        public double Radius { get; private set; }

        public int Health { get; set; } = 100;

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

        public bool Eat(Vector food)
        {
            if (this.Location.DistanceTo(food) <= this.Radius)
            {
                this.Health += 100;
                return true;
            }

            return false;
        }

        public Bloop Reproduce()
        {
            if (Helpers.EventOccurs(this.reproductionRate))
            {
                Dna childDna = dna.Copy();

                if (Helpers.EventOccurs(this.mutationRate))
                {
                    childDna.Mutate();
                }

                return new Bloop(childDna, this.reproductionRate, this.mutationRate, initialPosition: this.Location);
            }

            return null;
        }
    }
}
