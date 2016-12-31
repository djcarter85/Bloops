namespace Bloops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NeuralNetwork
    {
        private readonly NeuralDna dna;
        private readonly int numInputs;
        private readonly int[] layerNums;
        private readonly IEnumerable<NeuronLayer> layers;

        public NeuralNetwork(NeuralDna dna, int numInputs, params int[] layerNums)
        {
            this.dna = dna;
            this.numInputs = numInputs;
            this.layerNums = layerNums;

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

        public NeuralDna Dna
        {
            get { return this.dna; }
        }

        public int NumInputs
        {
            get { return this.numInputs; }
        }

        public int[] LayerNums
        {
            get { return this.layerNums; }
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
