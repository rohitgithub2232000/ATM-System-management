namespace ATM
{
    partial class MiniStatement
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
            button7 = new Button();
            panel2 = new Panel();
            MinistatementGVS = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinistatementGVS).BeginInit();
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
            panel1.Size = new Size(688, 58);
            panel1.TabIndex = 39;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(646, 0);
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
            label2.Location = new Point(134, 9);
            label2.Name = "label2";
            label2.Size = new Size(417, 43);
            label2.TabIndex = 3;
            label2.Text = "ATM MANAGEMENT SYSTEM";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(243, 62);
            label3.Name = "label3";
            label3.Size = new Size(191, 35);
            label3.TabIndex = 41;
            label3.Text = "MINI STATEMENT";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // button7
            // 
            button7.AutoEllipsis = true;
            button7.BackColor = SystemColors.ControlDark;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(285, 334);
            button7.Name = "button7";
            button7.Size = new Size(118, 35);
            button7.TabIndex = 48;
            button7.Text = "BACK";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 376);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(688, 21);
            panel2.TabIndex = 49;
            // 
            // MinistatementGVS
            // 
            MinistatementGVS.BackgroundColor = SystemColors.ControlLight;
            MinistatementGVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MinistatementGVS.Location = new Point(12, 100);
            MinistatementGVS.Name = "MinistatementGVS";
            MinistatementGVS.RowHeadersWidth = 51;
            MinistatementGVS.RowTemplate.Height = 29;
            MinistatementGVS.Size = new Size(664, 228);
            MinistatementGVS.TabIndex = 50;
            MinistatementGVS.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MiniStatement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 397);
            Controls.Add(MinistatementGVS);
            Controls.Add(panel2);
            Controls.Add(button7);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MiniStatement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniStatement";
            Load += MiniStatement_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MinistatementGVS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button7;
        private Panel panel2;
        private DataGridView MinistatementGVS;
    }
}