namespace Bloops
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void SimpleBloopsButton_Click(object sender, EventArgs e)
        {
            using (BloopsForm form = new BloopsForm())
            {
                form.ShowDialog(this);
            }
        }

        private void NeuralGraphButton_Click(object sender, EventArgs e)
        {
            using (GraphForm form = new GraphForm())
            {
                form.ShowDialog(this);
            }
        }

        private void XorButton_Click(object sender, EventArgs e)
        {
            using (XorForm form = new XorForm())
            {
                form.ShowDialog(this);
            }
        }
    }
}
