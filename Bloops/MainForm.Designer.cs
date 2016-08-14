namespace Bloops
{
    partial class MainForm
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
            this.simpleBloopsButton = new System.Windows.Forms.Button();
            this.neuralGraphButton = new System.Windows.Forms.Button();
            this.xorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simpleBloopsButton
            // 
            this.simpleBloopsButton.Location = new System.Drawing.Point(12, 12);
            this.simpleBloopsButton.Name = "simpleBloopsButton";
            this.simpleBloopsButton.Size = new System.Drawing.Size(258, 39);
            this.simpleBloopsButton.TabIndex = 0;
            this.simpleBloopsButton.Text = "Simple bloops";
            this.simpleBloopsButton.UseVisualStyleBackColor = true;
            this.simpleBloopsButton.Click += new System.EventHandler(this.SimpleBloopsButton_Click);
            // 
            // neuralGraphButton
            // 
            this.neuralGraphButton.Location = new System.Drawing.Point(12, 57);
            this.neuralGraphButton.Name = "neuralGraphButton";
            this.neuralGraphButton.Size = new System.Drawing.Size(258, 39);
            this.neuralGraphButton.TabIndex = 1;
            this.neuralGraphButton.Text = "Neural graph";
            this.neuralGraphButton.UseVisualStyleBackColor = true;
            this.neuralGraphButton.Click += new System.EventHandler(this.NeuralGraphButton_Click);
            // 
            // xorButton
            // 
            this.xorButton.Location = new System.Drawing.Point(12, 102);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(258, 39);
            this.xorButton.TabIndex = 2;
            this.xorButton.Text = "XOR";
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Click += new System.EventHandler(this.XorButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 152);
            this.Controls.Add(this.xorButton);
            this.Controls.Add(this.neuralGraphButton);
            this.Controls.Add(this.simpleBloopsButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button simpleBloopsButton;
        private System.Windows.Forms.Button neuralGraphButton;
        private System.Windows.Forms.Button xorButton;
    }
}