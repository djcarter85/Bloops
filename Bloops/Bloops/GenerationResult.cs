namespace Bloops
{
    public class GenerationResult
    {
        private readonly int generationIndex;
        private readonly int maxFoodEaten;
        private readonly double meanFoodEaten;
        private readonly double meanMaxSpeed;
        private readonly double meanRadius;

        public GenerationResult(
            int generationIndex,
            int maxFoodEaten,
            double meanFoodEaten,
            double meanRadius,
            double meanMaxSpeed)
        {
            this.generationIndex = generationIndex;
            this.maxFoodEaten = maxFoodEaten;
            this.meanFoodEaten = meanFoodEaten;
            this.meanRadius = meanRadius;
            this.meanMaxSpeed = meanMaxSpeed;
        }

        public int GenerationIndex
        {
            get { return this.generationIndex; }
        }

        public int MaxFoodEaten
        {
            get { return this.maxFoodEaten; }
        }

        public double MeanFoodEaten
        {
            get { return this.meanFoodEaten; }
        }

        public double MeanRadius
        {
            get { return this.meanRadius; }
        }

        public double MeanMaxSpeed
        {
            get { return this.meanMaxSpeed; }
        }
    }
}
