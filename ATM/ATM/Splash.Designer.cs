namespace ATM
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            MyProgress = new ProgressBar();
            Percentage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Location = new Point(309, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(235, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MyProgress
            // 
            MyProgress.BackColor = Color.Black;
            MyProgress.ForeColor = SystemColors.MenuHighlight;
            MyProgress.Location = new Point(-2, 309);
            MyProgress.Name = "MyProgress";
            MyProgress.Size = new Size(725, 22);
            MyProgress.TabIndex = 4;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.BackColor = Color.Black;
            Percentage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Percentage.Location = new Point(338, 278);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(29, 28);
            Percentage.TabIndex = 5;
            Percentage.Text = "%";
            Percentage.Click += label3_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 51);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.BackColor = Color.DimGray;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(136, 3);
            label2.Name = "label2";
            label2.Size = new Size(467, 43);
            label2.TabIndex = 4;
            label2.Text = "ATM SYSTEM MANAGEMENT";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(726, 335);
            Controls.Add(panel1);
            Controls.Add(Percentage);
            Controls.Add(MyProgress);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private ProgressBar MyProgress;
        private Label Percentage;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label label2;
    }
}