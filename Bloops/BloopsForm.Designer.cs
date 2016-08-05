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
            System.Windows.Forms.Label startingFoodLabel;
            this.map = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.bloopsUpDown = new System.Windows.Forms.NumericUpDown();
            this.foodUpDown = new System.Windows.Forms.NumericUpDown();
            bloopNumberLabel = new System.Windows.Forms.Label();
            startingFoodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloopsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodUpDown)).BeginInit();
            this.SuspendLayout();
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
            // bloopNumberLabel
            // 
            bloopNumberLabel.AutoSize = true;
            bloopNumberLabel.Location = new System.Drawing.Point(12, 142);
            bloopNumberLabel.Name = "bloopNumberLabel";
            bloopNumberLabel.Size = new System.Drawing.Size(107, 17);
            bloopNumberLabel.TabIndex = 4;
            bloopNumberLabel.Text = "Starting bloops:";
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
            // startingFoodLabel
            // 
            startingFoodLabel.AutoSize = true;
            startingFoodLabel.Location = new System.Drawing.Point(12, 205);
            startingFoodLabel.Name = "startingFoodLabel";
            startingFoodLabel.Size = new System.Drawing.Size(93, 17);
            startingFoodLabel.TabIndex = 6;
            startingFoodLabel.Text = "Starting food:";
            // 
            // BloopsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 600);
            this.Controls.Add(this.foodUpDown);
            this.Controls.Add(startingFoodLabel);
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
    }
}

