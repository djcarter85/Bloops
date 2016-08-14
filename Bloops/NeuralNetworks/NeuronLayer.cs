namespace Bloops
{
    using System.Collections.Generic;
    using System.Linq;

    class NeuronLayer
    {
        private IEnumerable<Neuron> neurons;

        public NeuronLayer(IEnumerable<Neuron> neurons)
        {
            this.neurons = neurons;
        }

        public IEnumerable<Neuron> Neurons
        {
            get { return this.neurons; }
        }

        public double[] Outputs(double[] inputs)
        {
            return this.neurons.Select(n => n.FeedForward(inputs)).ToArray();
        }
    }
}
