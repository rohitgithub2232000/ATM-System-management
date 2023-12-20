using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dxcDemo;Integrated Security=True");


        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccountNoTbl.Text == "" || NameTbl.Text == "" || FatherNameTbl.Text == "" || PhoneTbl.Text == "" || AddressTbl.Text == "" ||
                EducationTbl.Text == "" || OccupationTbl.Text == "" || PinTbl.Text == "" || DobTbl.Text == "")
            {
                MessageBox.Show("Misssing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTbl values('" + AccountNoTbl.Text + "','" + NameTbl.Text + "','" + FatherNameTbl.Text + "','" + DobTbl.Text + "','" + PhoneTbl.Text + "','" + AddressTbl.Text + "'+'" + EducationTbl.SelectedItem.ToString() + "','" + OccupationTbl.Text + "', " + PinTbl.Text + "," + bal + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created Successfully");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
