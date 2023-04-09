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
    public partial class changepin : Form
    {
        public changepin()
        {
            InitializeComponent();
        }

        private void ChangePINbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "data source= .; database=AtmMangementSystem; Integrated Security=true";
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            string updatePinQuery = "UPDATE Signup SET Pincode = @newPin WHERE  Accountno== @accountNumber";
            using (SqlCommand command = new SqlCommand(updatePinQuery, con))
            { 
            command.Parameters.AddWithValue("@newPin", NewpintextBox.Text);
            command.Parameters.AddWithValue("@accountNumber", AccountNumtextBox.Text);
            command.ExecuteNonQuery();
                MessageBox.Show("pin updated Successfully");
                NewpintextBox.Clear();
                AccountNumtextBox.Clear();
        } 
                con.Close();
            }

        private void Clearpinbutton_Click(object sender, EventArgs e)
        {
            NewpintextBox.Clear();
            AccountNumtextBox.Clear();
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

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            AccountDetailscs obj = new AccountDetailscs();
            obj.Show();
            this.Close();
        }
    }
    
}
