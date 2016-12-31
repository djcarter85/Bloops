namespace Bloops
{
    using System.Collections.Generic;
    using System.Linq;

    public class NeuronLayer
    {
        private IEnumerable<Neuron> neurons;

        public NeuronLayer(Queue<double> genes, int layerNum, int previousLayer)
        {
            this.neurons = Helpers.Repeat(() => new Neuron(genes.Dequeue(previousLayer + 1)), layerNum);
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
