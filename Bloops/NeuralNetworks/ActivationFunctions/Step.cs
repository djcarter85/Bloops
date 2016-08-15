namespace Bloops
{
    class Step : IActivator
    {
        private double min;
        private double max;

        public Step(double min, double max)
        {
            this.min = min;
            this.max = max;
        }

        public double Activate(double number)
        {
            return number >= 0 ? this.max : this.min;
        }
    }
}
