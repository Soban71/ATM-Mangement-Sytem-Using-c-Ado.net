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
    public partial class Deposists : Form

    {
        public Deposists()
        {
            InitializeComponent();
        }

        private void Deposistdonebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("data source= ; database=AtmMangementSystem; Integrated Security=true");

            int depositAmount = int.Parse(DeposisttextBox.Text);
            int  AccountNumber = int.Parse(AccountNotextBox.Text);
            int currentBalance = 0;
            connection.Open();
            string query = "SELECT Amount FROM Signup WHERE Accountno = @accountNumber";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add(new SqlParameter("@accountNumber", AccountNumber));
            SqlDataReader reader = command.ExecuteReader();
            {

                while (reader.Read())
                {
                    currentBalance = (int)reader["Amount"];
                    MessageBox.Show(currentBalance.ToString());
                }
                reader.Close();
            }
         
                   

            // Update the balance
            int newBalance = currentBalance + depositAmount;
                query = "UPDATE Signup SET Amount = @newBalance WHERE Accountno= @accountNumber";
                SqlCommand com = new SqlCommand(query, connection);
            {
                com.Parameters.Add(new SqlParameter("@newBalance", newBalance));
                com.Parameters.Add(new SqlParameter("@accountNumber", AccountNumber));
                com.ExecuteNonQuery();
                MessageBox.Show("Deposit successful");
            }  

            

            connection.Close();
            this.Close();
            Menu obj1 = new Menu();
            obj1.Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewRegistration3 obj = new NewRegistration3(); 
            obj.Show();
            this.Close();
        }

        private void changepinbutton_Click(object sender, EventArgs e)
        {
            changepin obj=new changepin();
            obj.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete_Account obj = new Delete_Account();
          
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

         private void button1_Click(object sender, EventArgs e)
        {

            AccountDetailscs obj = new AccountDetailscs();
            obj.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeposisttextBox.Clear();
            AccountNotextBox.Clear();

        }
    }
    }        
    

