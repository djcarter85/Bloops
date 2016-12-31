namespace Bloops
{
    using System.Collections.Generic;
    using System.Linq;

    public class XorEvolver
    {
        private const double MutationRate = 0.01;
        private const int PopulationSize = 100;

        private readonly IFitnessTester fitnessTester;
        private Dictionary<NeuralNetwork, double> population;

        public XorEvolver(IFitnessTester fitnessTester)
        {
            this.fitnessTester = fitnessTester;
            IEnumerable<NeuralNetwork> networks = Helpers.Repeat(
                () => new NeuralNetwork(NeuralDna.Random(9), 2, 2, 1),
                PopulationSize);
            this.population = networks.ToDictionary(nn => nn, nn => this.fitnessTester.Fitness(nn));
        }

        public void ProcessGenerations(int generations)
        {
            for (int i = 0; i < generations; i++)
            {
                this.ProcessGeneration();
            }
        }

        public void ProcessGeneration()
        {
            List<NeuralNetwork> newNetworks = new List<NeuralNetwork>();

            for (int i = 0; i < this.population.Count(); i++)
            {
                NeuralNetwork father = this.population.Keys.Random(nn => this.population[nn]);
                NeuralNetwork mother = this.population.Keys.Except(new[] { father }).Random(nn => this.population[nn]);

                NeuralDna childDna = father.Dna.Crossover(mother.Dna);
                childDna.Mutate(MutationRate);

                NeuralNetwork child = new NeuralNetwork(childDna, father.NumInputs, father.LayerNums);

                newNetworks.Add(child);
            }

            this.population = newNetworks.ToDictionary(nn => nn, nn => this.fitnessTester.Fitness(nn));
        }

        public NeuralNetwork Fittest
        {
            get { return this.population.OrderByDescending(p => p.Value).First().Key; }
        }
    }
}
