namespace Bloops
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class XorForm : Form
    {
        private XorTrainer trainer = new XorTrainer();
        private NeuralNetwork network;

        public XorForm()
        {
            this.InitializeComponent();
        }

        private string NetworkDescription
        {
            get
            {
                string description = null;

                foreach (NeuronLayer layer in this.network.Layers)
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
        }

        private void NewNetworkButton_Click(object sender, EventArgs e)
        {
            this.network = new NeuralNetwork(NeuralDna.Random(-1, 1, 9), 2, 2, 1);
            this.networkLabel.Text = this.NetworkDescription;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Tuple<XorTrainer.TestCase, double>> results;

            double error = this.trainer.Error(this.network, out results);

            string answers = null;

            foreach (var result in results)
            {
                answers += string.Format(
                    "{0}, {1}, {2}, {3}\r\n", result.Item1.A, result.Item1.B, result.Item1.Expected, result.Item2);
            }

            answers += "Error: " + error;

            this.testLabel.Text = answers;
        }
    }
}
