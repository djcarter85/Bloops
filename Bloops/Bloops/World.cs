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

        private readonly Parameters parameters;

        public World(Parameters parameters)
        {
            this.parameters = parameters;

            this.bloops = Enumerable.Repeat(0, this.parameters.StartingBloops)
                .Select(i => this.RandomBloop())
                .ToList();

            this.foods = Enumerable.Repeat(0, this.parameters.NumFood)
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

        public int Ticks { get; private set; }

        public int BloopCount
        {
            get { return this.bloops.Count; }
        }

        public int MaxFoodEaten
        {
            get { return this.bloops.Max(b => b.FoodEaten); }
        }

        public void Tick()
        {
            foreach (Bloop bloop in this.bloops)
            {
                bloop.Update(Width, Height);
            }

            foreach (Vector food in this.foods.ToArray())
            {
                if (this.bloops.Any(b => b.Eat(food)))
                {
                    this.foods.Remove(food);
                    this.foods.Add(RandomFood());
                }
            }

            this.Ticks++;
        }

        private Bloop RandomBloop()
        {
            return new Bloop(Dna.Random(), this.parameters);
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
