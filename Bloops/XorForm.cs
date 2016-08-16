namespace Bloops
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class XorForm : Form
    {
        private readonly XorEvolver evolver;

        public XorForm()
        {
            this.InitializeComponent();
            this.evolver = new XorEvolver(new XorTester());
        }

        private string NetworkDescription(NeuralNetwork network)
        {
            string description = null;

            foreach (NeuronLayer layer in network.Layers)
            {
                foreach (Neuron neuron in layer.Neurons)
                {
                    description += "(";

                    foreach (var weight in neuron.Weights)
                    {
                        description += weight.ToString("0.00") + ",";
                    }

                    description += ")  ";
                }

                description += "\r\n";
            }

            return description;
        }

        private string TestResults(NeuralNetwork network)
        {
            IEnumerable<Tuple<XorTester.TestCase, double>> results;

            double error = new XorTester().Error(network, out results);

            string answers = null;

            foreach (var result in results)
            {
                answers += string.Format(
                    "{0}, {1}, {2}, {3}\r\n", result.Item1.A, result.Item1.B, result.Item1.Expected, result.Item2);
            }

            answers += "Error: " + error;
            return answers;
        }

        private void EvolveButton_Click(object sender, EventArgs e)
        {
            this.evolver.ProcessGeneration();

            this.networkLabel.Text = this.NetworkDescription(this.evolver.Fittest);
            this.resultsLabel.Text = this.TestResults(this.evolver.Fittest);
        }
    }
}
