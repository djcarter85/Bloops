namespace Bloops
{
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

        public Dna Clone()
        {
            return new Dna(this.genes);
        }
    }
}
