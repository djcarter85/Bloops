namespace Bloops
{
    using System.Collections.Generic;
    using System.Linq;

    class World
    {
        public const int Width = 250;
        public const int Height = 250;

        private const int MinSize = 2;
        private const int MaxSize = 30;

        private List<Bloop> bloops;
        private List<Vector> foods;

        public World(int numBloops, int numFood)
        {
            this.bloops = Enumerable.Repeat(0, numBloops)
                .Select(i => RandomBloop())
                .ToList();

            this.foods = Enumerable.Repeat(0, numFood)
                .Select(i => RandomFood())
                .ToList();
        }

        public IEnumerable<Bloop> Bloops
        {
            get { return this.bloops; }
        }

        public IEnumerable<Vector> Foods
        {
            get { return this.foods; }
        }

        public void Update()
        {
            foreach (Bloop bloop in this.bloops)
            {
                bloop.Update();
            }

            this.bloops.RemoveAll(b => b.Dead);

            foreach (Vector food in this.foods.ToArray())
            {
                if (this.bloops.Any(b => b.Eat(food)))
                {
                    this.foods.Remove(food);
                }
            }
        }

        private static Bloop RandomBloop()
        {
            return new Bloop(Helpers.NextInt(MinSize, MaxSize), Helpers.NextRandom(1, 5), default(Vector));
        }

        private static Vector RandomFood()
        {
            return new Vector
            {
                X = Helpers.NextInt(-Width, Width),
                Y = Helpers.NextInt(-Height, Height)
            };
        }
    }
}
