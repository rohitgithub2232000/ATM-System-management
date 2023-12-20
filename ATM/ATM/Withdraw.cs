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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dxcDemo;Integrated Security=True");
        string Acc = Login.AccountNo;
        int bal;
        private void getbalance()
        {
            Con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select Balance from AccountTbl where [Account Number]='" + AccountNumlbl.Text + "'", Con);
            SqlCommand cmd = new("Select Balance from AccountTbl where [AccountNo]=@AccountNo", Con);
            cmd.Parameters.AddWithValue("@AccountNo", Acc);
            SqlDataAdapter sda = new(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelbl.Text = "Balance Rs " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void Withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        int newbalance;
        string Trtype = "Withdraw";
        private void addtransation()
        {
            try
            {
                Con.Open();
                string query = "insert into TransationTbl values('" + Acc + "','" + Trtype + "','" + wdamtTbl.Text + "','" + DateTime.Today.Date.ToString() + "')";
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
            if (wdamtTbl.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Convert.ToInt32(wdamtTbl.Text) <= 0)
            {
                MessageBox.Show("Enter a valid Amount");
            }
            else if (Convert.ToInt32(wdamtTbl.Text) > bal)
            {
                MessageBox.Show("balance can not be negative");
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(wdamtTbl.Text);
                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where AccountNo='" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Withdraw Success");
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
