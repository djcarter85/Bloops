namespace Bloops
{
    class Dna
    {
        public Dna(double gene)
        {
            this.Gene = gene;
        }

        public double Gene { get; private set; }

        public static Dna Random()
        {
            return new Dna(Helpers.NextRandom(0, 1));
        }
    }
}
