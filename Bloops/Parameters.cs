namespace Bloops
{
    class Parameters
    {
        private readonly int startingBloops;
        private readonly int numFood;
        private readonly double reproductionRate;
        private readonly double mutationRate;
        private readonly int startingHealth;

        public Parameters(int startingBloops, int numFood, double reproductionRate, double mutationRate, int startingHealth)
        {
            this.startingBloops = startingBloops;
            this.numFood = numFood;
            this.reproductionRate = reproductionRate;
            this.mutationRate = mutationRate;
            this.startingHealth = startingHealth;
        }

        public int StartingBloops
        {
            get { return this.startingBloops; }
        }

        public int NumFood
        {
            get { return this.numFood; }
        }

        public double ReproductionRate
        {
            get { return this.reproductionRate; }
        }

        public double MutationRate
        {
            get { return this.mutationRate; }
        }

        public int StartingHealth
        {
            get { return this.startingHealth; }
        }
    }
}
