﻿namespace Bloops
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class BloopsForm : Form
    {
        private World world = new World(10, 4);

        public BloopsForm()
        {
            this.InitializeComponent();

            this.map.Width = World.Width * 2;
            this.map.Height = World.Height * 2;
        }

        private static void DrawBloop(Bloop bloop, Graphics graphics)
        {
            using (Pen pen = new Pen(Brushes.Red))
            {
                graphics.DrawEllipse(
                    pen,
                    new Rectangle(
                        Convert.ToInt32(bloop.Location.X - bloop.Radius) + World.Width,
                        Convert.ToInt32(bloop.Location.Y - bloop.Radius) + World.Height,
                        Convert.ToInt32(2 * bloop.Radius),
                        Convert.ToInt32(2 * bloop.Radius)));
            }
        }

        private static void DrawFood(Vector food, Graphics graphics)
        {
            using (Pen pen = new Pen(Brushes.Blue))
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

        private void TimeStep()
        {
            this.world.Update();
            this.map.Invalidate();
        }

        private void Map_Paint(object sender, PaintEventArgs e)
        {
            foreach (Bloop bloop in this.world.Bloops)
            {
                DrawBloop(bloop, e.Graphics);
            }

            foreach (Vector food in this.world.Food)
            {
                DrawFood(food, e.Graphics);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.TimeStep();
        }
    }
}
