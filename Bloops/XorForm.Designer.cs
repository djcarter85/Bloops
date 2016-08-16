namespace Bloops
{
    partial class XorForm
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
            this.evolveButton = new System.Windows.Forms.Button();
            this.networkLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // evolveButton
            // 
            this.evolveButton.Location = new System.Drawing.Point(27, 31);
            this.evolveButton.Name = "evolveButton";
            this.evolveButton.Size = new System.Drawing.Size(128, 30);
            this.evolveButton.TabIndex = 0;
            this.evolveButton.Text = "Evolve";
            this.evolveButton.UseVisualStyleBackColor = true;
            this.evolveButton.Click += new System.EventHandler(this.EvolveButton_Click);
            // 
            // networkLabel
            // 
            this.networkLabel.AutoSize = true;
            this.networkLabel.Location = new System.Drawing.Point(24, 96);
            this.networkLabel.Name = "networkLabel";
            this.networkLabel.Size = new System.Drawing.Size(0, 17);
            this.networkLabel.TabIndex = 1;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(24, 268);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(0, 17);
            this.resultsLabel.TabIndex = 3;
            // 
            // XorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 416);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.networkLabel);
            this.Controls.Add(this.evolveButton);
            this.Name = "XorForm";
            this.Text = "XorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button evolveButton;
        private System.Windows.Forms.Label networkLabel;
        private System.Windows.Forms.Label resultsLabel;
    }
}
