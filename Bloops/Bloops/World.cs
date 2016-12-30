namespace Bloops
{
    using System;
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

            this.bloops = Helpers.Repeat(() => this.RandomBloop(), this.parameters.StartingBloops).ToList();

            this.foods = Helpers.Repeat(() => RandomLocation(), this.parameters.NumFood).ToList();
        }

        public IEnumerable<Bloop> Bloops
        {
            get { return this.bloops; }
        }

        public IEnumerable<Vector> Foods
        {
            get { return this.foods; }
        }

        public double MeanRadius
        {
            get { return this.bloops.Select(b => b.Radius).Average(); }
        }

        public double MeanMaxSpeed
        {
            get { return this.bloops.Select(b => b.MaxSpeed).Average(); }
        }

        public int Generation { get; private set; }

        public int Ticks { get; private set; }

        public int BloopCount
        {
            get { return this.bloops.Count; }
        }

        public int MaxFoodEaten
        {
            get { return this.bloops.Max(b => b.FoodEaten); }
        }

        public double MeanFoodEaten
        {
            get { return this.bloops.Select(b => b.FoodEaten).Average(); }
        }

        public void Tick()
        {
            if (this.Ticks > this.parameters.TicksPerGeneration)
            {
                this.Generation++;
                this.Ticks = 0;

                this.bloops = this.NextGeneration().ToList();
            }
            else
            {
                foreach (Bloop bloop in this.bloops)
                {
                    bloop.Tick(Width, Height);
                }

                foreach (Vector food in this.foods.ToArray())
                {
                    if (this.bloops.Any(b => b.Eat(food)))
                    {
                        this.foods.Remove(food);
                        this.foods.Add(RandomLocation());
                    }
                }

                this.Ticks++;
            }
        }

        private IEnumerable<Bloop> NextGeneration()
        {
            for (int i = 0; i < this.parameters.StartingBloops; i++)
            {
                var father = this.bloops.Random(b => b.FoodEaten);
                var mother = this.bloops.Random(b => b.FoodEaten);

                var childDna = father.Dna.Crossover(mother.Dna);

                childDna.Mutate(this.parameters.MutationRate);

                yield return new Bloop(childDna, this.parameters, RandomLocation());
            }
        }

        private Bloop RandomBloop()
        {
            return new Bloop(Dna.Random(2), this.parameters, RandomLocation());
        }

        private static Vector RandomLocation()
        {
            return new Vector
            {
                X = Helpers.NextInt(-Width, Width),
                Y = Helpers.NextInt(-Height, Height)
            };
        }
    }
}
