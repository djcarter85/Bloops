namespace Bloops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class NeuralNetwork
    {
        private IEnumerable<NeuronLayer> layers;

        public NeuralNetwork(NeuralDna dna, int numInputs, params int[] layerNums)
        {
            Queue<double> genes = new Queue<double>(dna.Genes);
            List<NeuronLayer> layers = new List<NeuronLayer>();

            int previousLayer = numInputs;

            foreach (int layerNum in layerNums)
            {
                layers.Add(new NeuronLayer(genes, layerNum, previousLayer));
                previousLayer = layerNum;
            }

            if (genes.Any())
            {
                throw new ArgumentException();
            }

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
