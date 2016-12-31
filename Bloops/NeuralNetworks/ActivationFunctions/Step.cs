namespace Bloops
{
    public class Step : IActivator
    {
        private double min;
        private double max;
        private double activationWeight;

        public Step(double min, double max, double activationWeight)
        {
            this.min = min;
            this.max = max;
            this.activationWeight = activationWeight;
        }

        public double Activate(double number)
        {
            return number >= activationWeight ? this.max : this.min;
        }
    }
}
