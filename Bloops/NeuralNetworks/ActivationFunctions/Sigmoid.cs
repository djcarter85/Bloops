namespace Bloops
{
    using System;

    class Sigmoid : IActivator
    {
        public double Activate(double number)
        {
            return 1 / (1 + Math.Exp(-number));
        }
    }
}
