namespace Bloops
{
    class Step : IActivator
    {
        public double Activate(double number)
        {
            return number >= 0 ? 1 : -1;
        }
    }
}
