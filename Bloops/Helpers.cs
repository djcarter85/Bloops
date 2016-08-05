namespace Bloops
{
    using System;

    static class Helpers
    {
        private static readonly Random random = new Random();

        public static double NextRandom(double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }

        public static int NextInt(int min, int max)
        {
            return random.Next(min, max);
        }

        public static bool EventOccurs(double rate)
        {
            return random.NextDouble() < rate;
        }
    }
}
