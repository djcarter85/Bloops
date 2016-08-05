namespace Bloops
{
    class Dna
    {
        private Dna(double gene)
        {
            this.Gene = gene;
        }

        public double Gene { get; private set; }

        public static Dna Random()
        {
            return new Dna(Helpers.NextRandom(0, 1));
        }

        public Dna Copy()
        {
            return new Dna(this.Gene);
        }

        public void Mutate()
        {
            this.Gene = Helpers.NextRandom(0, 1);
        }
    }
}
