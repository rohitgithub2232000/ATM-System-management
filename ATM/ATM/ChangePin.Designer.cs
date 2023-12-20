namespace ATM
{
    partial class ChangePin
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
            label3 = new Label();
            Pin1Tbl = new TextBox();
            Pin2Tbl = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
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
            panel1.Size = new Size(609, 59);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(567, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 43);
            label1.TabIndex = 3;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            label4.Location = new Point(123, 140);
            label4.Name = "label4";
            label4.Size = new Size(150, 29);
            label4.TabIndex = 11;
            label4.Text = "CONFORM PIN:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(123, 85);
            label3.Name = "label3";
            label3.Size = new Size(150, 29);
            label3.TabIndex = 10;
            label3.Text = "NEW PIN:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pin1Tbl
            // 
            Pin1Tbl.Location = new Point(280, 88);
            Pin1Tbl.Name = "Pin1Tbl";
            Pin1Tbl.Size = new Size(203, 27);
            Pin1Tbl.TabIndex = 13;
            // 
            // Pin2Tbl
            // 
            Pin2Tbl.Location = new Point(280, 140);
            Pin2Tbl.Name = "Pin2Tbl";
            Pin2Tbl.Size = new Size(203, 27);
            Pin2Tbl.TabIndex = 14;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(190, 187);
            button1.Name = "button1";
            button1.Size = new Size(101, 35);
            button1.TabIndex = 34;
            button1.Text = "CHANGE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(335, 187);
            button2.Name = "button2";
            button2.Size = new Size(97, 35);
            button2.TabIndex = 35;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 240);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(609, 21);
            panel2.TabIndex = 36;
            // 
            // ChangePin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 261);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Pin2Tbl);
            Controls.Add(Pin1Tbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePin";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox Pin1Tbl;
        private TextBox Pin2Tbl;
        private Button button1;
        private Button button2;
        private Panel panel2;
    }
}