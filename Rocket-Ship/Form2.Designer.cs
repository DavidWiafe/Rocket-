namespace Rocket_Ship
{
    partial class Form2
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
            this.RedBlockPanel1 = new System.Windows.Forms.Panel();
            this.blueBlockPanel = new System.Windows.Forms.Panel();
            this.redProgressBar = new System.Windows.Forms.ProgressBar();
            this.blueProgressBar = new System.Windows.Forms.ProgressBar();
            this.stratButton = new System.Windows.Forms.Button();
            this.redTextBox = new System.Windows.Forms.TextBox();
            this.blueTextBox = new System.Windows.Forms.TextBox();
            this.redPopulationBlockLabel = new System.Windows.Forms.Label();
            this.bluePopulationBlockLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RedBlockPanel1
            // 
            this.RedBlockPanel1.BackColor = System.Drawing.Color.DarkRed;
            this.RedBlockPanel1.Location = new System.Drawing.Point(31, 168);
            this.RedBlockPanel1.Name = "RedBlockPanel1";
            this.RedBlockPanel1.Size = new System.Drawing.Size(37, 100);
            this.RedBlockPanel1.TabIndex = 0;
            this.RedBlockPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.RedBlockPanel1_Paint);
            // 
            // blueBlockPanel
            // 
            this.blueBlockPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.blueBlockPanel.Location = new System.Drawing.Point(724, 168);
            this.blueBlockPanel.Name = "blueBlockPanel";
            this.blueBlockPanel.Size = new System.Drawing.Size(40, 100);
            this.blueBlockPanel.TabIndex = 1;
            // 
            // redProgressBar
            // 
            this.redProgressBar.Location = new System.Drawing.Point(31, 304);
            this.redProgressBar.Name = "redProgressBar";
            this.redProgressBar.Size = new System.Drawing.Size(100, 23);
            this.redProgressBar.TabIndex = 2;
            // 
            // blueProgressBar
            // 
            this.blueProgressBar.Location = new System.Drawing.Point(664, 304);
            this.blueProgressBar.Name = "blueProgressBar";
            this.blueProgressBar.Size = new System.Drawing.Size(100, 23);
            this.blueProgressBar.TabIndex = 3;
            // 
            // stratButton
            // 
            this.stratButton.Location = new System.Drawing.Point(354, 73);
            this.stratButton.Name = "stratButton";
            this.stratButton.Size = new System.Drawing.Size(75, 23);
            this.stratButton.TabIndex = 4;
            this.stratButton.Text = "Start Battle";
            this.stratButton.UseVisualStyleBackColor = true;
            this.stratButton.Click += new System.EventHandler(this.stratButton_Click);
            // 
            // redTextBox
            // 
            this.redTextBox.Location = new System.Drawing.Point(31, 110);
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.Size = new System.Drawing.Size(100, 20);
            this.redTextBox.TabIndex = 5;
            // 
            // blueTextBox
            // 
            this.blueTextBox.Location = new System.Drawing.Point(664, 110);
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.Size = new System.Drawing.Size(100, 20);
            this.blueTextBox.TabIndex = 6;
            // 
            // redPopulationBlockLabel
            // 
            this.redPopulationBlockLabel.AutoSize = true;
            this.redPopulationBlockLabel.Location = new System.Drawing.Point(62, 73);
            this.redPopulationBlockLabel.Name = "redPopulationBlockLabel";
            this.redPopulationBlockLabel.Size = new System.Drawing.Size(57, 13);
            this.redPopulationBlockLabel.TabIndex = 7;
            this.redPopulationBlockLabel.Text = "Population";
            // 
            // bluePopulationBlockLabel
            // 
            this.bluePopulationBlockLabel.AutoSize = true;
            this.bluePopulationBlockLabel.Location = new System.Drawing.Point(694, 73);
            this.bluePopulationBlockLabel.Name = "bluePopulationBlockLabel";
            this.bluePopulationBlockLabel.Size = new System.Drawing.Size(57, 13);
            this.bluePopulationBlockLabel.TabIndex = 8;
            this.bluePopulationBlockLabel.Text = "Population";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(31, 137);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(27, 13);
            this.redLabel.TabIndex = 9;
            this.redLabel.Text = "Red";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(737, 137);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(28, 13);
            this.blueLabel.TabIndex = 10;
            this.blueLabel.Text = "Blue";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.bluePopulationBlockLabel);
            this.Controls.Add(this.redPopulationBlockLabel);
            this.Controls.Add(this.blueTextBox);
            this.Controls.Add(this.redTextBox);
            this.Controls.Add(this.stratButton);
            this.Controls.Add(this.blueProgressBar);
            this.Controls.Add(this.redProgressBar);
            this.Controls.Add(this.blueBlockPanel);
            this.Controls.Add(this.RedBlockPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RedBlockPanel1;
        private System.Windows.Forms.Panel blueBlockPanel;
        private System.Windows.Forms.ProgressBar redProgressBar;
        private System.Windows.Forms.ProgressBar blueProgressBar;
        private System.Windows.Forms.Button stratButton;
        private System.Windows.Forms.TextBox redTextBox;
        private System.Windows.Forms.TextBox blueTextBox;
        private System.Windows.Forms.Label redPopulationBlockLabel;
        private System.Windows.Forms.Label bluePopulationBlockLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
    }
}