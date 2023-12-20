using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dxcDemo;Integrated Security=True");
        string Acc = Login.AccountNo;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1Tbl.Text == "" || Pin2Tbl.Text == "")
            {
                MessageBox.Show("Enter and Confirm the new PIN");
            }
            else if (Pin2Tbl.Text != Pin1Tbl.Text)
            {
                MessageBox.Show("Pin1 and Pin2 do not match! Please enter correct Pin");
            }
            else
            {
                //newbalance = oldbalance + Convert.ToInt32(DepoAmtTbl.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Pin=" + Pin1Tbl.Text + "where AccountNo='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin Successfully changed");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }
    }
}
