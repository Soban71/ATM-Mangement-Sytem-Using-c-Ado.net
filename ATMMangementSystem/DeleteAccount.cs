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

namespace ATMMangementSystem
{
    public partial class Delete_Account : Form
    {
        public Delete_Account()
        {
            InitializeComponent();
        }

        private void DeleteAccountButtonbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "data source= .; database=AtmMangementSystem; Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL command to delete account
                string deleteCommand = "DELETE FROM Signup WHERE Accountno = @AccountNumber";

                using (SqlCommand command = new SqlCommand(deleteCommand, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", DeleteAccounttxtBox.Text);
                    command.ExecuteNonQuery();

                }
                connection.Close();
                MessageBox.Show("Account Deleted Successfully");
                Menu obj = new Menu();
                obj.Show();
                this.Close();
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

        private void DeleteButton_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteAccounttxtBox.Clear();
        }
    }
}
