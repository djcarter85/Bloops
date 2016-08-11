namespace Bloops
{
    partial class GraphForm
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
            this.goButton = new System.Windows.Forms.Button();
            this.graph = new System.Windows.Forms.PictureBox();
            this.weightsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(12, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(94, 32);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // graph
            // 
            this.graph.BackColor = System.Drawing.Color.White;
            this.graph.Location = new System.Drawing.Point(177, 12);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(500, 500);
            this.graph.TabIndex = 1;
            this.graph.TabStop = false;
            this.graph.Paint += new System.Windows.Forms.PaintEventHandler(this.Graph_Paint);
            // 
            // weightsLabel
            // 
            this.weightsLabel.AutoSize = true;
            this.weightsLabel.Location = new System.Drawing.Point(12, 63);
            this.weightsLabel.Name = "weightsLabel";
            this.weightsLabel.Size = new System.Drawing.Size(0, 17);
            this.weightsLabel.TabIndex = 2;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 539);
            this.Controls.Add(this.weightsLabel);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.goButton);
            this.Name = "GraphForm";
            this.Text = "NeuralNetworkForm";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.PictureBox graph;
        private System.Windows.Forms.Label weightsLabel;
    }
}