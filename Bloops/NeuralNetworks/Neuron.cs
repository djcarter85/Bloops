namespace Bloops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Neuron
    {
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
            return new Neuron(Enumerable.Repeat(0, numInputs + 1).Select(i => Helpers.NextRandom(-1, 1)).ToArray());
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

            return Activate(sum);
        }

        private static double Activate(double number)
        {
            return number >= 0 ? 1 : -1;
        }
    }
}
