namespace Bloops
{
    class NeuralDna
    {
        public NeuralDna(double[] genes)
        {
            this.Genes = genes;
        }

        public double[] Genes { get; private set; }

        public static NeuralDna Random(double min, double max, int geneCount)
        {
            return new NeuralDna(Helpers.Repeat(() => Helpers.NextRandom(min, max), geneCount));
        }
    }
}
