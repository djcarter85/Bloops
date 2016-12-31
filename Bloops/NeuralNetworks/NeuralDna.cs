namespace Bloops
{
    public class NeuralDna
    {
        private double[] genes;

        public NeuralDna(double[] genes)
        {
            this.genes = genes;
        }

        public double[] Genes
        {
            get { return this.genes; }
        }

        public static NeuralDna Random(int geneCount)
        {
            return new NeuralDna(Helpers.Repeat(() => Helpers.NextDouble(-1, 1), geneCount));
        }

        public NeuralDna Crossover(NeuralDna partner)
        {
            int crossoverPoint = Helpers.NextInt(0, this.genes.Length);

            double[] newGenes = new double[this.genes.Length];

            for (int i = 0; i < this.genes.Length; i++)
            {
                newGenes[i] = i < crossoverPoint ? this.genes[i] : partner.genes[i];
            }

            return new NeuralDna(newGenes);
        }

        public void Mutate(double mutationRate)
        {
            for (int i = 0; i < this.genes.Length; i++)
            {
                if (Helpers.EventOccurs(mutationRate))
                {
                    this.genes[i] = Helpers.NextDouble(-1, 1);
                }
            }
        }
    }
}
