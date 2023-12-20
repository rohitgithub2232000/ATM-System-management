namespace ATM
{
    partial class Account
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            AccountNoTbl = new TextBox();
            NameTbl = new TextBox();
            FatherNameTbl = new TextBox();
            AddressTbl = new TextBox();
            PhoneTbl = new TextBox();
            PinTbl = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            DobTbl = new DateTimePicker();
            EducationTbl = new ComboBox();
            button7 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            OccupationTbl = new TextBox();
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
            panel1.Size = new Size(958, 69);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(919, 0);
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
            label2.Location = new Point(290, 9);
            label2.Name = "label2";
            label2.Size = new Size(417, 43);
            label2.TabIndex = 3;
            label2.Text = "ATM MANAGEMENT SYSTEM";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(69, 109);
            label3.Name = "label3";
            label3.Size = new Size(141, 29);
            label3.TabIndex = 7;
            label3.Text = "ACCOUNT NO";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(69, 157);
            label4.Name = "label4";
            label4.Size = new Size(141, 29);
            label4.TabIndex = 8;
            label4.Text = "NAME";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(69, 203);
            label5.Name = "label5";
            label5.Size = new Size(141, 29);
            label5.TabIndex = 9;
            label5.Text = "FATHER NAME";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Enabled = false;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(69, 248);
            label6.Name = "label6";
            label6.Size = new Size(141, 29);
            label6.TabIndex = 10;
            label6.Text = "ADDRESS";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Enabled = false;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(530, 158);
            label7.Name = "label7";
            label7.Size = new Size(131, 29);
            label7.TabIndex = 11;
            label7.Text = "PHONE";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AccountNoTbl
            // 
            AccountNoTbl.Location = new Point(215, 115);
            AccountNoTbl.Name = "AccountNoTbl";
            AccountNoTbl.Size = new Size(203, 27);
            AccountNoTbl.TabIndex = 12;
            // 
            // NameTbl
            // 
            NameTbl.Location = new Point(215, 160);
            NameTbl.Name = "NameTbl";
            NameTbl.Size = new Size(203, 27);
            NameTbl.TabIndex = 13;
            // 
            // FatherNameTbl
            // 
            FatherNameTbl.Location = new Point(215, 205);
            FatherNameTbl.Name = "FatherNameTbl";
            FatherNameTbl.Size = new Size(203, 27);
            FatherNameTbl.TabIndex = 14;
            // 
            // AddressTbl
            // 
            AddressTbl.Location = new Point(215, 252);
            AddressTbl.Multiline = true;
            AddressTbl.Name = "AddressTbl";
            AddressTbl.Size = new Size(203, 65);
            AddressTbl.TabIndex = 15;
            // 
            // PhoneTbl
            // 
            PhoneTbl.Location = new Point(690, 161);
            PhoneTbl.Name = "PhoneTbl";
            PhoneTbl.Size = new Size(203, 27);
            PhoneTbl.TabIndex = 16;
            // 
            // PinTbl
            // 
            PinTbl.Location = new Point(690, 111);
            PinTbl.Name = "PinTbl";
            PinTbl.Size = new Size(203, 27);
            PinTbl.TabIndex = 22;
            // 
            // label8
            // 
            label8.Enabled = false;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(530, 288);
            label8.Name = "label8";
            label8.Size = new Size(154, 29);
            label8.TabIndex = 21;
            label8.Text = "DOB";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Enabled = false;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(530, 245);
            label9.Name = "label9";
            label9.Size = new Size(154, 29);
            label9.TabIndex = 20;
            label9.Text = "OCCUPATION";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Enabled = false;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(530, 201);
            label10.Name = "label10";
            label10.Size = new Size(154, 29);
            label10.TabIndex = 19;
            label10.Text = "EDUCATION";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Enabled = false;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(530, 108);
            label12.Name = "label12";
            label12.Size = new Size(154, 29);
            label12.TabIndex = 17;
            label12.Text = "PIN";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DobTbl
            // 
            DobTbl.Location = new Point(690, 292);
            DobTbl.Name = "DobTbl";
            DobTbl.Size = new Size(203, 27);
            DobTbl.TabIndex = 27;
            DobTbl.Value = new DateTime(2023, 12, 6, 22, 11, 30, 0);
            // 
            // EducationTbl
            // 
            EducationTbl.FormattingEnabled = true;
            EducationTbl.Items.AddRange(new object[] { "10th", "12th", "Under Graduate", "Graduate", "Post Graduate" });
            EducationTbl.Location = new Point(690, 203);
            EducationTbl.Name = "EducationTbl";
            EducationTbl.Size = new Size(203, 28);
            EducationTbl.TabIndex = 28;
            // 
            // button7
            // 
            button7.AutoEllipsis = true;
            button7.BackColor = SystemColors.ControlDarkDark;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(510, 343);
            button7.Name = "button7";
            button7.Size = new Size(91, 35);
            button7.TabIndex = 30;
            button7.Text = "SUBMIT";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 399);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 21);
            panel2.TabIndex = 31;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(368, 343);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 32;
            button1.Text = "LOGOUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OccupationTbl
            // 
            OccupationTbl.Location = new Point(690, 245);
            OccupationTbl.Name = "OccupationTbl";
            OccupationTbl.Size = new Size(203, 27);
            OccupationTbl.TabIndex = 33;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Control;
            ClientSize = new Size(958, 420);
            Controls.Add(OccupationTbl);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(button7);
            Controls.Add(EducationTbl);
            Controls.Add(DobTbl);
            Controls.Add(PinTbl);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(PhoneTbl);
            Controls.Add(AddressTbl);
            Controls.Add(FatherNameTbl);
            Controls.Add(NameTbl);
            Controls.Add(AccountNoTbl);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            Load += Account_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox AccountNoTbl;
        private TextBox NameTbl;
        private TextBox FatherNameTbl;
        private TextBox AddressTbl;
        private TextBox PhoneTbl;
        private TextBox PinTbl;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private DateTimePicker DobTbl;
        private ComboBox EducationTbl;
        private Button button7;
        private Panel panel2;
        private Button button1;
        private TextBox OccupationTbl;
    }
}