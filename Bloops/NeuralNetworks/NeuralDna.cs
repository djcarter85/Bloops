namespace Bloops
{
    class NeuralDna
    {
        private double min;
        private double max;

        public NeuralDna(double[] genes, double min, double max)
        {
            this.Genes = genes;
            this.min = min;
            this.max = max;
        }

        public double[] Genes { get; private set; }

        public static NeuralDna Random(double min, double max, int geneCount)
        {
            return new NeuralDna(Helpers.Repeat(() => Helpers.NextDouble(min, max), geneCount), min, max);
        }

        public NeuralDna Crossover(NeuralDna partner)
        {
            int crossoverPoint = Helpers.NextInt(0, this.Genes.Length);

            double[] newGenes = new double[this.Genes.Length];

            for (int i = 0; i < this.Genes.Length; i++)
            {
                newGenes[i] = i < crossoverPoint ? this.Genes[i] : partner.Genes[i];
            }

            return new NeuralDna(newGenes, this.min, this.max);
        }

        public void Mutate(double mutationRate)
        {
            for (int i = 0; i < this.Genes.Length; i++)
            {
                if (Helpers.EventOccurs(mutationRate))
                {
                    this.Genes[i] = Helpers.NextDouble(this.min, this.max);
                }
            }
        }
    }
}
