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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dxcDemo;Integrated Security=True");

        private void getbalance()
        {
            Con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select Balance from AccountTbl where [Account Number]='" + AccountNumlbl.Text + "'", Con);
            SqlCommand cmd = new("Select Balance from AccountTbl where [AccountNo]=@AccountNo", Con);
            cmd.Parameters.AddWithValue("@AccountNo", AccountNumlbl.Text);
            SqlDataAdapter sda = new(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "Rs " + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            AccountNumlbl.Text = Home.AccountNo;
            getbalance();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }


        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Balancelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
