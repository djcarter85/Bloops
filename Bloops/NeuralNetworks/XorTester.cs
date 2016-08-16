namespace Bloops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class XorTester
    {
        public double Fitness(NeuralNetwork network)
        {
            IEnumerable<Tuple<TestCase, double>> dummy;
            return 1 / Error(network, out dummy);
        }

        public double Error(NeuralNetwork network, out IEnumerable<Tuple<TestCase, double>> results)
        {
            results = TestCase.All.Select(tc => Tuple.Create(tc, network.Outputs(new[] { tc.A, tc.B }).Single())).ToArray();
            return results.Select(r => Math.Abs(r.Item1.Expected - r.Item2)).Sum();
        }

        public class TestCase
        {
            private static readonly IEnumerable<TestCase> all =
                new[]
                {
                    new TestCase { A = 0, B = 0, Expected = 0 },
                    new TestCase { A = 0, B = 1, Expected = 1 },
                    new TestCase { A = 1, B = 0, Expected = 1 },
                    new TestCase { A = 1, B = 1, Expected = 0 },
                };

            public double A { get; set; }
            public double B { get; set; }
            public double Expected { get; set; }

            public static IEnumerable<TestCase> All
            {
                get { return all; }
            }
        }
    }
}
