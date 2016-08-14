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
            this.newNetworkButton = new System.Windows.Forms.Button();
            this.networkLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newNetworkButton
            // 
            this.newNetworkButton.Location = new System.Drawing.Point(27, 31);
            this.newNetworkButton.Name = "newNetworkButton";
            this.newNetworkButton.Size = new System.Drawing.Size(128, 30);
            this.newNetworkButton.TabIndex = 0;
            this.newNetworkButton.Text = "New network";
            this.newNetworkButton.UseVisualStyleBackColor = true;
            this.newNetworkButton.Click += new System.EventHandler(this.NewNetworkButton_Click);
            // 
            // networkLabel
            // 
            this.networkLabel.AutoSize = true;
            this.networkLabel.Location = new System.Drawing.Point(24, 96);
            this.networkLabel.Name = "networkLabel";
            this.networkLabel.Size = new System.Drawing.Size(0, 17);
            this.networkLabel.TabIndex = 1;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(27, 199);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(128, 30);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(24, 268);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(0, 17);
            this.testLabel.TabIndex = 3;
            // 
            // XorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 416);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.networkLabel);
            this.Controls.Add(this.newNetworkButton);
            this.Name = "XorForm";
            this.Text = "XorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newNetworkButton;
        private System.Windows.Forms.Label networkLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label testLabel;
    }
}