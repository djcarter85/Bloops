namespace Bloops
{
    class Bloop
    {
        private readonly Parameters parameters;

        private readonly double maxSpeed;
        private readonly Dna dna;

        private Vector velocity;

        public Bloop(Dna dna, Parameters parameters, Vector initialPosition = default(Vector))
        {
            this.dna = dna;
            this.Radius = dna.Gene * 30;
            this.maxSpeed = 10 * (1 - dna.Gene);

            this.parameters = parameters;

            this.Location = initialPosition;
            this.Health = this.parameters.StartingHealth;
        }

        public Vector Location { get; private set; }
        public double Radius { get; private set; }

        public int Health { get; private set; }

        public bool Dead
        {
            get { return this.Health <= 0; }
        }

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
            if (Helpers.EventOccurs(this.parameters.ReproductionRate))
            {
                Dna childDna = dna.Copy();

                if (Helpers.EventOccurs(this.parameters.MutationRate))
                {
                    childDna.Mutate();
                }

                return new Bloop(childDna, this.parameters, initialPosition: this.Location);
            }

            return null;
        }
    }
}
