namespace Bloops
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class BloopsForm : Form
    {
        private World world;
        private bool running;

        public BloopsForm()
        {
            this.InitializeComponent();

            this.map.Width = World.Width * 2;
            this.map.Height = World.Height * 2;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (this.world == null)
            {
                Parameters parameters = new Parameters(
                    (int)this.bloopsUpDown.Value,
                    (int)this.foodUpDown.Value,
                    (double)this.mutationRateUpDown.Value,
                    (int)this.ticksPerGenerationUpDown.Value);

                this.world = new World(parameters);

                this.timer.Start();
                this.running = true;
                this.startButton.Text = "Pause";
                this.stepButton.Enabled = false;
                this.stepButton.Visible = true;

                this.bloopsUpDown.Enabled =
                    this.foodUpDown.Enabled =
                    this.mutationRateUpDown.Enabled =
                    this.ticksPerGenerationUpDown.Enabled =
                    false;
            }
            else if (this.running)
            {
                this.timer.Stop();
                this.running = false;
                this.startButton.Text = "Continue";
                this.stepButton.Enabled = true;
            }
            else
            {
                this.timer.Start();
                this.running = true;
                this.startButton.Text = "Pause";
                this.stepButton.Enabled = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.TimeStep();
        }

        private void StepButton_Click(object sender, EventArgs e)
        {
            this.TimeStep();
        }

        private void TimeStep()
        {
            this.world.Tick();
            this.map.Invalidate();

            this.statusLabel.Text = string.Format(
                "Generation: {0}\r\n" +
                "Ticks: {1}\r\n" +
                "Bloops: {2}\r\n" +
                "Max food eaten: {3}\r\n" +
                "Mean food eaten: {4}\r\n" +
                "Mean radius: {5:0.000}\r\n" +
                "Mean max speed: {6:0.000}",
                this.world.Generation,
                this.world.Ticks,
                this.world.BloopCount,
                this.world.MaxFoodEaten,
                this.world.MeanFoodEaten,
                this.world.MeanRadius,
                this.world.MeanMaxSpeed);

            this.resultsTextBox.Text = CreateResultsText();
        }

        private string CreateResultsText()
        {
            string resultsText = "Gen\tMax food\tMean food\tMean radius\tMean max speed\r\n";

            foreach (var result in this.world.Results)
            {
                resultsText += result.GenerationIndex + "\t";
                resultsText += result.MaxFoodEaten + "\t";
                resultsText += result.MeanFoodEaten + "\t";
                resultsText += result.MeanRadius + "\t";
                resultsText += result.MeanMaxSpeed;

                resultsText += "\r\n";
            }

            return resultsText;
        }

        private void Map_Paint(object sender, PaintEventArgs e)
        {
            if (this.world != null)
            {
                foreach (Bloop bloop in this.world.Bloops)
                {
                    DrawBloop(bloop, e.Graphics);
                }

                foreach (Vector food in this.world.Foods)
                {
                    DrawFood(food, e.Graphics);
                }
            }
        }

        private static void DrawBloop(Bloop bloop, Graphics graphics)
        {
            Rectangle rect = new Rectangle(
                Convert.ToInt32(bloop.Location.X - bloop.Radius) + World.Width,
                Convert.ToInt32(bloop.Location.Y - bloop.Radius) + World.Height,
                Convert.ToInt32(2 * bloop.Radius),
                Convert.ToInt32(2 * bloop.Radius));

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(100, 127, 127, 127)))
            {
                graphics.FillEllipse(brush, rect);
            }

            using (SolidBrush brush = new SolidBrush(Color.Black))
            {
                graphics.DrawString(bloop.FoodEaten.ToString(), new Font("Verdana", 10), brush, rect.Location);
            }
        }

        private static void DrawFood(Vector food, Graphics graphics)
        {
            using (Pen pen = new Pen(Brushes.Red))
            {
                graphics.DrawRectangle(
                    pen,
                    new Rectangle(
                        Convert.ToInt32(food.X - 1) + World.Width,
                        Convert.ToInt32(food.Y - 1) + World.Height,
                        3,
                        3));
            }
        }
    }
}
