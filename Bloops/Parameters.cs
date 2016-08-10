namespace Bloops
{
    class Parameters
    {
        private readonly int startingBloops;
        private readonly int numFood;
        private readonly double reproductionRate;
        private readonly double mutationRate;

        public Parameters(int startingBloops, int numFood, double reproductionRate, double mutationRate)
        {
            this.startingBloops = startingBloops;
            this.numFood = numFood;
            this.reproductionRate = reproductionRate;
            this.mutationRate = mutationRate;
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
    }
}
