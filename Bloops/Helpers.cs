namespace Bloops
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

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

        public static void DrawRectangle(Graphics graphics, Vector point, int radius, Color colour)
        {
            using (Pen pen = new Pen(colour))
            {
                int size = radius * 2 + 1;

                graphics.DrawRectangle(
                    pen,
                    new Rectangle(
                        Convert.ToInt32(point.X - radius) + World.Width,
                        Convert.ToInt32(point.Y - radius) + World.Height,
                        size,
                        size));
            }
        }

        public static T[] Dequeue<T>(this Queue<T> queue, int count)
        {
            return Repeat(() => queue.Dequeue(), count).ToArray();
        }

        public static T[] Repeat<T>(Func<T> func, int count)
        {
            return Enumerable.Repeat(0, count).Select(i => func()).ToArray();
        }
    }
}
