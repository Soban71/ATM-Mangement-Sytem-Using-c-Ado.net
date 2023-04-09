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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATMMangementSystem
{
    public partial class Balancechecking : Form
    {
        public Balancechecking()
        {
            InitializeComponent();
        }

        private void Balancedisplayerbutton_Click(object sender, EventArgs e)
        {
            String accountnumber = AccountNotextBox.Text;


            string connectionString = "data source= .; database=AtmMangementSystem; Integrated Security=true";
            string query = "SELECT Amount FROM Signup WHERE  Accountno = '" + accountnumber + "'";
            SqlConnection con = new SqlConnection(connectionString);
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show (reader["Amount"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Account not found");
                        }
                    }


                }
            }

        }

        private void Deposistsbutton_Click(object sender, EventArgs e)
        {
            Deposists obj = new Deposists();
            obj.Show();
            this.Close();
        }

        private void Withdrawbutton_Click(object sender, EventArgs e)
        {
            Withdraw obj = new Withdraw();
            obj.Show();
            this.Close();
        }

        private void balancecheckingbutton_Click(object sender, EventArgs e)
        {
            Balancechecking obj = new Balancechecking();
            obj.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewRegistration3 obj = new NewRegistration3();
            obj.Show();
            this.Close();
        }

        private void changepinbutton_Click(object sender, EventArgs e)
        {
            changepin obj = new changepin();
            obj.Show();
            this.Close();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            Delete_Account obj = new Delete_Account();
            obj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountDetailscs obj = new AccountDetailscs();
            obj.Show();
            this.Close();
        }
    }
}