namespace Bloops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Neuron
    {
        private static readonly IActivator activator = new Sigmoid();

        private readonly double[] weights;

        public Neuron(double[] weights)
        {
            this.weights = weights;
        }

        public IEnumerable<double> Weights
        {
            get { return this.weights; }
        }

        public static Neuron Random(int numInputs)
        {
            return new Neuron(Helpers.Repeat(() => Helpers.NextDouble(-1, 1), numInputs + 1));
        }

        public double FeedForward(double[] inputs)
        {
            if (inputs.Length + 1 != this.weights.Length)
            {
                throw new ArgumentException("The wrong number of inputs has been used.", "inputs");
            }

            double sum = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i] * weights[i];
            }

            // Add bias term
            sum += weights.Last();

            return activator.Activate(sum);
        }
    }
}
