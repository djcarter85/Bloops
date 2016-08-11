namespace Bloops
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GraphForm : Form
    {
        private const int NumPoints = 100;
        private Neuron neuron;

        public GraphForm()
        {
            this.InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            this.neuron = Neuron.Random(2);
            this.graph.Invalidate();
            this.weightsLabel.Text = string.Join("\r\n", this.neuron.Weights);
        }

        private Vector RandomVector()
        {
            return new Vector
            {
                X = Helpers.NextInt(-World.Width, World.Width),
                Y = Helpers.NextInt(-World.Height, World.Height)
            };
        }

        private void Graph_Paint(object sender, PaintEventArgs e)
        {
            if (this.neuron != null)
            {
                IEnumerable<Vector> points = Enumerable.Repeat(0, NumPoints).Select(i => RandomVector()).ToArray();

                foreach (Vector point in points)
                {
                    double value = this.neuron.FeedForward(new[] { point.X, point.Y });

                    Color colour = value >= 0 ? Color.Red : Color.Blue;

                    Helpers.DrawRectangle(e.Graphics, point, 1, colour);
                }
            }
        }
    }
}
