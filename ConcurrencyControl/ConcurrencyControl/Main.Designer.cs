
namespace ConcurrencyControl
{
    partial class Main
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
            this.LUButton = new System.Windows.Forms.Button();
            this.PButton = new System.Windows.Forms.Button();
            this.URButton = new System.Windows.Forms.Button();
            this.DButton = new System.Windows.Forms.Button();
            this.DRButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LUButton
            // 
            this.LUButton.Location = new System.Drawing.Point(37, 59);
            this.LUButton.Name = "LUButton";
            this.LUButton.Size = new System.Drawing.Size(100, 50);
            this.LUButton.TabIndex = 0;
            this.LUButton.Text = "Lost Update";
            this.LUButton.UseVisualStyleBackColor = true;
            this.LUButton.Click += new System.EventHandler(this.LUButton_Click);
            // 
            // PButton
            // 
            this.PButton.Location = new System.Drawing.Point(325, 59);
            this.PButton.Name = "PButton";
            this.PButton.Size = new System.Drawing.Size(100, 50);
            this.PButton.TabIndex = 1;
            this.PButton.Text = "Phantom";
            this.PButton.UseVisualStyleBackColor = true;
            this.PButton.Click += new System.EventHandler(this.PButton_Click);
            // 
            // URButton
            // 
            this.URButton.Location = new System.Drawing.Point(105, 155);
            this.URButton.Name = "URButton";
            this.URButton.Size = new System.Drawing.Size(110, 50);
            this.URButton.TabIndex = 2;
            this.URButton.Text = "Unrepeatable Read";
            this.URButton.UseVisualStyleBackColor = true;
            this.URButton.Click += new System.EventHandler(this.URButton_Click);
            // 
            // DButton
            // 
            this.DButton.Location = new System.Drawing.Point(258, 155);
            this.DButton.Name = "DButton";
            this.DButton.Size = new System.Drawing.Size(100, 50);
            this.DButton.TabIndex = 3;
            this.DButton.Text = "Deadlock";
            this.DButton.UseVisualStyleBackColor = true;
            this.DButton.Click += new System.EventHandler(this.DButton_Click);
            // 
            // DRButton
            // 
            this.DRButton.Location = new System.Drawing.Point(180, 59);
            this.DRButton.Name = "DRButton";
            this.DRButton.Size = new System.Drawing.Size(100, 50);
            this.DRButton.TabIndex = 4;
            this.DRButton.Text = "Dirty Read";
            this.DRButton.UseVisualStyleBackColor = true;
            this.DRButton.Click += new System.EventHandler(this.DRButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 263);
            this.Controls.Add(this.DRButton);
            this.Controls.Add(this.DButton);
            this.Controls.Add(this.URButton);
            this.Controls.Add(this.PButton);
            this.Controls.Add(this.LUButton);
            this.MaximumSize = new System.Drawing.Size(485, 310);
            this.MinimumSize = new System.Drawing.Size(485, 310);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concurrency Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LUButton;
        private System.Windows.Forms.Button PButton;
        private System.Windows.Forms.Button URButton;
        private System.Windows.Forms.Button DButton;
        private System.Windows.Forms.Button DRButton;
    }
}

