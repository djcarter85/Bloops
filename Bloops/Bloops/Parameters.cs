namespace Bloops
{
    class Parameters
    {
        private readonly int startingBloops;
        private readonly int numFood;
        private readonly double mutationRate;
        private readonly int ticksPerGeneration;

        public Parameters(
            int startingBloops, 
            int numFood, 
            double mutationRate,
            int ticksPerGeneration)
        {
            this.startingBloops = startingBloops;
            this.numFood = numFood;
            this.mutationRate = mutationRate;
            this.ticksPerGeneration = ticksPerGeneration;
        }

        public int StartingBloops
        {
            get { return this.startingBloops; }
        }

        public int NumFood
        {
            get { return this.numFood; }
        }

        public double MutationRate
        {
            get { return this.mutationRate; }
        }

        public int TicksPerGeneration
        {
            get { return this.ticksPerGeneration; }
        }
    }
}
