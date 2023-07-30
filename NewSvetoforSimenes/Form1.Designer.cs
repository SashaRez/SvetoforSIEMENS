namespace NewSvetoforSimenes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            svetoforOff = new PictureBox();
            RedLight = new PictureBox();
            YellowLight = new PictureBox();
            GreenLight = new PictureBox();
            redLabel = new Label();
            greenLabel = new Label();
            powerSvetofor = new Button();
            ((System.ComponentModel.ISupportInitialize)svetoforOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YellowLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreenLight).BeginInit();
            SuspendLayout();
            // 
            // svetoforOff
            // 
            svetoforOff.Dock = DockStyle.Fill;
            svetoforOff.Image = Properties.Resources.light;
            svetoforOff.Location = new Point(0, 0);
            svetoforOff.Name = "svetoforOff";
            svetoforOff.Size = new Size(1298, 778);
            svetoforOff.SizeMode = PictureBoxSizeMode.AutoSize;
            svetoforOff.TabIndex = 8;
            svetoforOff.TabStop = false;
            // 
            // RedLight
            // 
            RedLight.Dock = DockStyle.Fill;
            RedLight.Image = Properties.Resources.RedLight2;
            RedLight.Location = new Point(0, 0);
            RedLight.Name = "RedLight";
            RedLight.Size = new Size(1298, 778);
            RedLight.SizeMode = PictureBoxSizeMode.AutoSize;
            RedLight.TabIndex = 9;
            RedLight.TabStop = false;
            // 
            // YellowLight
            // 
            YellowLight.Dock = DockStyle.Fill;
            YellowLight.Image = Properties.Resources.YellowLight2;
            YellowLight.Location = new Point(0, 0);
            YellowLight.Name = "YellowLight";
            YellowLight.Size = new Size(1298, 778);
            YellowLight.SizeMode = PictureBoxSizeMode.AutoSize;
            YellowLight.TabIndex = 10;
            YellowLight.TabStop = false;
            // 
            // GreenLight
            // 
            GreenLight.Dock = DockStyle.Fill;
            GreenLight.Image = Properties.Resources.GreenLight2;
            GreenLight.Location = new Point(0, 0);
            GreenLight.Name = "GreenLight";
            GreenLight.Size = new Size(1298, 778);
            GreenLight.SizeMode = PictureBoxSizeMode.AutoSize;
            GreenLight.TabIndex = 11;
            GreenLight.TabStop = false;
            // 
            // redLabel
            // 
            redLabel.BackColor = Color.Transparent;
            redLabel.Font = new Font("Digital-7", 71.25F, FontStyle.Bold, GraphicsUnit.Point);
            redLabel.Location = new Point(801, 162);
            redLabel.Name = "redLabel";
            redLabel.Size = new Size(139, 98);
            redLabel.TabIndex = 12;
            redLabel.Text = "28";
            redLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // greenLabel
            // 
            greenLabel.BackColor = Color.Transparent;
            greenLabel.Font = new Font("Digital-7", 71.25F, FontStyle.Bold, GraphicsUnit.Point);
            greenLabel.Location = new Point(801, 622);
            greenLabel.Name = "greenLabel";
            greenLabel.Size = new Size(139, 98);
            greenLabel.TabIndex = 13;
            greenLabel.Text = "28";
            greenLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // powerSvetofor
            // 
            powerSvetofor.BackColor = Color.Transparent;
            powerSvetofor.BackgroundImage = Properties.Resources.Без_названия;
            powerSvetofor.BackgroundImageLayout = ImageLayout.Zoom;
            powerSvetofor.Location = new Point(12, 685);
            powerSvetofor.Name = "powerSvetofor";
            powerSvetofor.Size = new Size(84, 81);
            powerSvetofor.TabIndex = 14;
            powerSvetofor.UseVisualStyleBackColor = false;
            powerSvetofor.Click += startSvetofor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 778);
            Controls.Add(powerSvetofor);
            Controls.Add(greenLabel);
            Controls.Add(redLabel);
            Controls.Add(GreenLight);
            Controls.Add(YellowLight);
            Controls.Add(RedLight);
            Controls.Add(svetoforOff);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Traffic Light (Siemens)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)svetoforOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)YellowLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreenLight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox svetoforOff;
        private PictureBox RedLight;
        private PictureBox YellowLight;
        private PictureBox GreenLight;
        private Label redLabel;
        private Label greenLabel;
        private Button powerSvetofor;
    }
}