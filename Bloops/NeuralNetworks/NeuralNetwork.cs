namespace Bloops
{
    using System.Collections.Generic;

    class NeuralNetwork
    {
        private IEnumerable<NeuronLayer> layers;

        public NeuralNetwork(IEnumerable<NeuronLayer> layers)
        {
            this.layers = layers;
        }

        public IEnumerable<NeuronLayer> Layers
        {
            get { return this.layers; }
        }

        public double[] Outputs(double[] inputs)
        {
            double[] copy = (double[])inputs.Clone();

            foreach (NeuronLayer layer in this.layers)
            {
                copy = layer.Outputs(copy);
            }

            return copy;
        }
    }
}
