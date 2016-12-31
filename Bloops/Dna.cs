namespace Bloops
{
    using System;

    public class Dna
    {
        private readonly double[] genes;

        private Dna(double[] genes)
        {
            this.genes = genes;
        }

        public double[] Genes
        {
            get { return this.genes; }
        }

        public static Dna Random(int numberOfGenes)
        {
            var genes = Helpers.Repeat(() => Helpers.NextDouble(0, 1), numberOfGenes);

            return new Dna(genes);
        }

        public Dna Crossover(Dna otherDna)
        {
            var numberOfGenes = this.genes.Length;

            if (this.genes.Length != otherDna.genes.Length)
            {
                throw new InvalidOperationException("Genes must have the same length to be crossed over.");
            }

            int crossoverPoint = Helpers.NextInt(0, numberOfGenes);

            var newGenes = new double[numberOfGenes];

            for (int i = 0; i < numberOfGenes; i++)
            {
                if (i < crossoverPoint)
                {
                    newGenes[i] = this.genes[i];
                }
                else
                {
                    newGenes[i] = otherDna.genes[i];
                }
            }

            return new Dna(newGenes);
        }

        public void Mutate(double mutationRate)
        {
            for (int i = 0; i < this.genes.Length; i++)
            {
                if (Helpers.EventOccurs(mutationRate))
                {
                    this.genes[i] = Helpers.NextDouble(0, 1);
                }
            }
        }
    }
}
