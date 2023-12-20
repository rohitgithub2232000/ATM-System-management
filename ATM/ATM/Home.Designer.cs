namespace ATM
{
    partial class Home
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            button7 = new Button();
            AccountNumlbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(574, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 43);
            label1.TabIndex = 3;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(109, 9);
            label2.Name = "label2";
            label2.Size = new Size(389, 43);
            label2.TabIndex = 3;
            label2.Text = "Select Your Transaction Please";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            button6.AutoEllipsis = true;
            button6.BackColor = SystemColors.ControlDark;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(365, 117);
            button6.Name = "button6";
            button6.Size = new Size(161, 39);
            button6.TabIndex = 16;
            button6.Text = "WITHDRAW";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(83, 117);
            button2.Name = "button2";
            button2.Size = new Size(161, 39);
            button2.TabIndex = 17;
            button2.Text = "DEPOSIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(83, 176);
            button1.Name = "button1";
            button1.Size = new Size(161, 39);
            button1.TabIndex = 18;
            button1.Text = "FAST CASH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.AutoEllipsis = true;
            button3.BackColor = SystemColors.ControlDark;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(365, 176);
            button3.Name = "button3";
            button3.Size = new Size(161, 39);
            button3.TabIndex = 19;
            button3.Text = "MINI STATEMENT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AutoEllipsis = true;
            button4.BackColor = SystemColors.ControlDark;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(365, 236);
            button4.Name = "button4";
            button4.Size = new Size(161, 39);
            button4.TabIndex = 20;
            button4.Text = "BALANCE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.AutoEllipsis = true;
            button5.BackColor = SystemColors.ControlDark;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(83, 236);
            button5.Name = "button5";
            button5.Size = new Size(161, 39);
            button5.TabIndex = 21;
            button5.Text = "CHANGE PIN";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 346);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 21);
            panel2.TabIndex = 23;
            // 
            // button7
            // 
            button7.AutoEllipsis = true;
            button7.BackColor = SystemColors.ControlDarkDark;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(253, 299);
            button7.Name = "button7";
            button7.Size = new Size(99, 35);
            button7.TabIndex = 24;
            button7.Text = "LOGOUT";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // AccountNumlbl
            // 
            AccountNumlbl.Enabled = false;
            AccountNumlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AccountNumlbl.Location = new Point(83, 60);
            AccountNumlbl.Name = "AccountNumlbl";
            AccountNumlbl.Size = new Size(441, 43);
            AccountNumlbl.TabIndex = 4;
            AccountNumlbl.Text = "Account Number";
            AccountNumlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 367);
            Controls.Add(AccountNumlbl);
            Controls.Add(button7);
            Controls.Add(panel2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button6;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel2;
        private Button button7;
        private Label AccountNumlbl;
    }
}