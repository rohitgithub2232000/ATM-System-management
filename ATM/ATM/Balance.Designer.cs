namespace ATM
{
    partial class Balance
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
            label4 = new Label();
            AccountNumlbl = new Label();
            Balancelbl = new Label();
            button1 = new Button();
            panel2 = new Panel();
            label3 = new Label();
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
            panel1.Size = new Size(627, 59);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(582, 0);
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
            label2.Location = new Point(94, 9);
            label2.Name = "label2";
            label2.Size = new Size(417, 43);
            label2.TabIndex = 3;
            label2.Text = "ATM MANAGEMENT SYSTEM";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(125, 168);
            label4.Name = "label4";
            label4.Size = new Size(187, 29);
            label4.TabIndex = 9;
            label4.Text = "YOUR BALANCE:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // AccountNumlbl
            // 
            AccountNumlbl.Enabled = false;
            AccountNumlbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            AccountNumlbl.Location = new Point(319, 113);
            AccountNumlbl.Name = "AccountNumlbl";
            AccountNumlbl.Size = new Size(187, 29);
            AccountNumlbl.TabIndex = 10;
            AccountNumlbl.Text = "AccountNo";
            AccountNumlbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Balancelbl
            // 
            Balancelbl.Enabled = false;
            Balancelbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Balancelbl.Location = new Point(319, 168);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(187, 29);
            Balancelbl.TabIndex = 11;
            Balancelbl.Text = "Balance in Rs";
            Balancelbl.TextAlign = ContentAlignment.MiddleLeft;
            Balancelbl.Click += Balancelbl_Click;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(254, 228);
            button1.Name = "button1";
            button1.Size = new Size(106, 35);
            button1.TabIndex = 33;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 288);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(627, 21);
            panel2.TabIndex = 34;
            // 
            // label3
            // 
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(125, 113);
            label3.Name = "label3";
            label3.Size = new Size(187, 29);
            label3.TabIndex = 35;
            label3.Text = "ACCOUNT NO:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click_2;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 309);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(Balancelbl);
            Controls.Add(AccountNumlbl);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balance";
            Load += Balance_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label AccountNumlbl;
        private Label Balancelbl;
        private Button button1;
        private Panel panel2;
        private Label label3;
    }
}