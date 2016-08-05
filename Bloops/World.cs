namespace Bloops
{
    using System.Collections.Generic;
    using System.Linq;

    class World
    {
        public const int Width = 250;
        public const int Height = 250;

        private List<Bloop> bloops;

        public World(int numBloops)
        {
            this.bloops = Enumerable.Repeat(0, 10)
                .Select(i => RandomBloop())
                .ToList();
        }

        public IEnumerable<Bloop> Bloops
        {
            get { return this.bloops; }
        }

        public void Update()
        {
            foreach (Bloop bloop in this.bloops)
            {
                bloop.Update();
            }

            this.bloops.RemoveAll(b => b.Dead);
        }

        private static Bloop RandomBloop()
        {
            Vector initialLocation = new Vector
            {
                X = Helpers.NextInt(-Width, Width),
                Y = Helpers.NextInt(-Height, Height)
            };

            return new Bloop(Helpers.NextInt(2, 10), Helpers.NextRandom(1, 5), initialLocation);
        }
    }
}
