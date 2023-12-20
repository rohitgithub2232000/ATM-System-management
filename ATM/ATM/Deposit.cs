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
using System.Xml;

namespace ATM
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dxcDemo;Integrated Security=True");
        string Acc = Login.AccountNo;
        string Trtype = "Deposite";
        private void addtransation()
        {
            try
            {
                Con.Open();
                string query = "insert into TransationTbl values('" + Acc + "','" + Trtype + "','" + DepoAmtTbl.Text + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account created Successfully");
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (DepoAmtTbl.Text == "" || Convert.ToInt32(DepoAmtTbl.Text) <= 0)
            {
                MessageBox.Show("Enter the Amount to Deposit");
            }
            else
            {
                newbalance = oldbalance + Convert.ToInt32(DepoAmtTbl.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + "where AccountNo='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Deposite");
                    Con.Close();
                    addtransation();
                    Home home = new Home();
                    home.Show();
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
        int oldbalance, newbalance;
        private void getbalance()
        {
            Con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select Balance from AccountTbl where [Account Number]='" + AccountNumlbl.Text + "'", Con);
            SqlCommand cmd = new("Select Balance from AccountTbl where [AccountNo]=@AccountNo", Con);
            cmd.Parameters.AddWithValue("@AccountNo", Acc);
            SqlDataAdapter sda = new(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
