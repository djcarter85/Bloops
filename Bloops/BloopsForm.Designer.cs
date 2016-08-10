namespace Bloops
{
    partial class BloopsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bloopNumberLabel;
            System.Windows.Forms.Label foodLabel;
            System.Windows.Forms.Label reproductionRateLabel;
            System.Windows.Forms.Label mutationRateLabel;
            System.Windows.Forms.Label startingHealthLabel;
            System.Windows.Forms.Label foodHealthLabel;
            this.map = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.bloopsUpDown = new System.Windows.Forms.NumericUpDown();
            this.foodUpDown = new System.Windows.Forms.NumericUpDown();
            this.reproductionRateUpDown = new System.Windows.Forms.NumericUpDown();
            this.mutationRateUpDown = new System.Windows.Forms.NumericUpDown();
            this.startingHealthUpDown = new System.Windows.Forms.NumericUpDown();
            this.foodHealthUpDown = new System.Windows.Forms.NumericUpDown();
            bloopNumberLabel = new System.Windows.Forms.Label();
            foodLabel = new System.Windows.Forms.Label();
            reproductionRateLabel = new System.Windows.Forms.Label();
            mutationRateLabel = new System.Windows.Forms.Label();
            startingHealthLabel = new System.Windows.Forms.Label();
            foodHealthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloopsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductionRateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationRateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingHealthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodHealthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bloopNumberLabel
            // 
            bloopNumberLabel.AutoSize = true;
            bloopNumberLabel.Location = new System.Drawing.Point(12, 142);
            bloopNumberLabel.Name = "bloopNumberLabel";
            bloopNumberLabel.Size = new System.Drawing.Size(107, 17);
            bloopNumberLabel.TabIndex = 4;
            bloopNumberLabel.Text = "Starting bloops:";
            // 
            // foodLabel
            // 
            foodLabel.AutoSize = true;
            foodLabel.Location = new System.Drawing.Point(12, 205);
            foodLabel.Name = "foodLabel";
            foodLabel.Size = new System.Drawing.Size(44, 17);
            foodLabel.TabIndex = 6;
            foodLabel.Text = "Food:";
            // 
            // reproductionRateLabel
            // 
            reproductionRateLabel.AutoSize = true;
            reproductionRateLabel.Location = new System.Drawing.Point(12, 271);
            reproductionRateLabel.Name = "reproductionRateLabel";
            reproductionRateLabel.Size = new System.Drawing.Size(126, 17);
            reproductionRateLabel.TabIndex = 8;
            reproductionRateLabel.Text = "Reproduction rate:";
            // 
            // mutationRateLabel
            // 
            mutationRateLabel.AutoSize = true;
            mutationRateLabel.Location = new System.Drawing.Point(12, 334);
            mutationRateLabel.Name = "mutationRateLabel";
            mutationRateLabel.Size = new System.Drawing.Size(95, 17);
            mutationRateLabel.TabIndex = 10;
            mutationRateLabel.Text = "Mutation rate:";
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.Color.White;
            this.map.Location = new System.Drawing.Point(206, 37);
            this.map.Margin = new System.Windows.Forms.Padding(4);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(44, 98);
            this.map.TabIndex = 1;
            this.map.TabStop = false;
            this.map.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(86, 30);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 67);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 3;
            // 
            // bloopsUpDown
            // 
            this.bloopsUpDown.Location = new System.Drawing.Point(12, 162);
            this.bloopsUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.bloopsUpDown.Name = "bloopsUpDown";
            this.bloopsUpDown.Size = new System.Drawing.Size(76, 22);
            this.bloopsUpDown.TabIndex = 5;
            this.bloopsUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // foodUpDown
            // 
            this.foodUpDown.Location = new System.Drawing.Point(12, 225);
            this.foodUpDown.Name = "foodUpDown";
            this.foodUpDown.Size = new System.Drawing.Size(76, 22);
            this.foodUpDown.TabIndex = 7;
            this.foodUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // reproductionRateUpDown
            // 
            this.reproductionRateUpDown.DecimalPlaces = 4;
            this.reproductionRateUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            262144});
            this.reproductionRateUpDown.Location = new System.Drawing.Point(12, 291);
            this.reproductionRateUpDown.Name = "reproductionRateUpDown";
            this.reproductionRateUpDown.Size = new System.Drawing.Size(76, 22);
            this.reproductionRateUpDown.TabIndex = 9;
            this.reproductionRateUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            196608});
            // 
            // mutationRateUpDown
            // 
            this.mutationRateUpDown.DecimalPlaces = 3;
            this.mutationRateUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.mutationRateUpDown.Location = new System.Drawing.Point(15, 354);
            this.mutationRateUpDown.Name = "mutationRateUpDown";
            this.mutationRateUpDown.Size = new System.Drawing.Size(76, 22);
            this.mutationRateUpDown.TabIndex = 11;
            this.mutationRateUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // startingHealthUpDown
            // 
            this.startingHealthUpDown.Location = new System.Drawing.Point(15, 418);
            this.startingHealthUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.startingHealthUpDown.Name = "startingHealthUpDown";
            this.startingHealthUpDown.Size = new System.Drawing.Size(76, 22);
            this.startingHealthUpDown.TabIndex = 13;
            this.startingHealthUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // startingHealthLabel
            // 
            startingHealthLabel.AutoSize = true;
            startingHealthLabel.Location = new System.Drawing.Point(12, 398);
            startingHealthLabel.Name = "startingHealthLabel";
            startingHealthLabel.Size = new System.Drawing.Size(104, 17);
            startingHealthLabel.TabIndex = 12;
            startingHealthLabel.Text = "Starting health:";
            // 
            // foodHealthUpDown
            // 
            this.foodHealthUpDown.Location = new System.Drawing.Point(18, 484);
            this.foodHealthUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.foodHealthUpDown.Name = "foodHealthUpDown";
            this.foodHealthUpDown.Size = new System.Drawing.Size(76, 22);
            this.foodHealthUpDown.TabIndex = 15;
            this.foodHealthUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // foodHealthLabel
            // 
            foodHealthLabel.AutoSize = true;
            foodHealthLabel.Location = new System.Drawing.Point(15, 464);
            foodHealthLabel.Name = "foodHealthLabel";
            foodHealthLabel.Size = new System.Drawing.Size(125, 17);
            foodHealthLabel.TabIndex = 14;
            foodHealthLabel.Text = "Food health value:";
            // 
            // BloopsForm
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 600);
            this.Controls.Add(this.foodHealthUpDown);
            this.Controls.Add(foodHealthLabel);
            this.Controls.Add(this.startingHealthUpDown);
            this.Controls.Add(startingHealthLabel);
            this.Controls.Add(this.mutationRateUpDown);
            this.Controls.Add(mutationRateLabel);
            this.Controls.Add(this.reproductionRateUpDown);
            this.Controls.Add(reproductionRateLabel);
            this.Controls.Add(this.foodUpDown);
            this.Controls.Add(foodLabel);
            this.Controls.Add(this.bloopsUpDown);
            this.Controls.Add(bloopNumberLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.map);
            this.Name = "BloopsForm";
            this.Text = "Bloops!";
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloopsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductionRateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationRateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingHealthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodHealthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.NumericUpDown bloopsUpDown;
        private System.Windows.Forms.NumericUpDown foodUpDown;
        private System.Windows.Forms.NumericUpDown reproductionRateUpDown;
        private System.Windows.Forms.NumericUpDown mutationRateUpDown;
        private System.Windows.Forms.NumericUpDown startingHealthUpDown;
        private System.Windows.Forms.NumericUpDown foodHealthUpDown;
    }
}

