namespace Rocket_Ship
{
    partial class Form1
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
            this.status = new System.Windows.Forms.ProgressBar();
            this.rocket = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Rockect_Ship = new System.Windows.Forms.GroupBox();
            this.Lanuch_BTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.counter = new System.Windows.Forms.Label();
            this.Lanchpanel = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.testButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Rockect_Ship.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(546, 704);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(147, 23);
            this.status.TabIndex = 0;
            this.status.Value = 100;
            // 
            // rocket
            // 
            this.rocket.AutoSize = true;
            this.rocket.Location = new System.Drawing.Point(205, 503);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(35, 13);
            this.rocket.TabIndex = 1;
            this.rocket.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(85, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 110);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Green-Star";
            // 
            // Rockect_Ship
            // 
            this.Rockect_Ship.Controls.Add(this.panel1);
            this.Rockect_Ship.Location = new System.Drawing.Point(508, 552);
            this.Rockect_Ship.Name = "Rockect_Ship";
            this.Rockect_Ship.Size = new System.Drawing.Size(228, 144);
            this.Rockect_Ship.TabIndex = 3;
            this.Rockect_Ship.TabStop = false;
            // 
            // Lanuch_BTN
            // 
            this.Lanuch_BTN.Location = new System.Drawing.Point(49, 704);
            this.Lanuch_BTN.Name = "Lanuch_BTN";
            this.Lanuch_BTN.Size = new System.Drawing.Size(75, 23);
            this.Lanuch_BTN.TabIndex = 4;
            this.Lanuch_BTN.Text = "Launch";
            this.Lanuch_BTN.UseVisualStyleBackColor = true;
            this.Lanuch_BTN.Click += new System.EventHandler(this.lanuching);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(159, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 333);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 333);
            this.panel3.TabIndex = 6;
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(12, 359);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(0, 13);
            this.counter.TabIndex = 7;
            // 
            // Lanchpanel
            // 
            this.Lanchpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lanchpanel.Location = new System.Drawing.Point(78, 593);
            this.Lanchpanel.Name = "Lanchpanel";
            this.Lanchpanel.Size = new System.Drawing.Size(21, 91);
            this.Lanchpanel.TabIndex = 8;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(177, 682);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 5;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(178, 394);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 10;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.test);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 739);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Lanchpanel);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Lanuch_BTN);
            this.Controls.Add(this.Rockect_Ship);
            this.Controls.Add(this.rocket);
            this.Controls.Add(this.status);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Rockect_Ship.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar status;
        private System.Windows.Forms.Label rocket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Rockect_Ship;
        private System.Windows.Forms.Button Lanuch_BTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Lanchpanel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button testButton;
    }
}

