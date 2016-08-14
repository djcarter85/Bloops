namespace Bloops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class XorForm : Form
    {
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
            NeuronLayer hiddenLayer = new NeuronLayer(new[] { Neuron.Random(2), Neuron.Random(2) });
            NeuronLayer outputLayer = new NeuronLayer(new[] { Neuron.Random(2) });

            this.network = new NeuralNetwork(new[] { hiddenLayer, outputLayer });

            this.networkLabel.Text = this.NetworkDescription;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            string answers = null;

            foreach (Test testCase in Test.Cases)
            {
                double[] output = this.network.Outputs(new[] { testCase.A, testCase.B });
                answers += string.Format("{0}, {1}, {2}, {3}\r\n", testCase.A, testCase.B, testCase.Expected, output.Single());
            }

            this.testLabel.Text = answers;
        }

        private class Test
        {
            private static readonly IEnumerable<Test> cases =
                new[]
                {
                    new Test { A = 0, B = 0, Expected = 0},
                    new Test { A = 0, B = 1, Expected = 1},
                    new Test { A = 1, B = 0, Expected = 1},
                    new Test { A = 1, B = 1, Expected = 0},
                };

            public double A { get; set; }
            public double B { get; set; }
            public double Expected { get; set; }

            public static IEnumerable<Test> Cases
            {
                get { return cases; }
            }
        }
    }
}
