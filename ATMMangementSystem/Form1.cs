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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            CardNumtextBox.Clear();
            PinNumtextBox.Clear();
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {

            NewRegistration3 obj1 = new NewRegistration3();
            obj1.Show();


        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("data source= .; database=AtmMangementSystem; Integrated Security=true"))
            {
                connection.Open();

             
   using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Admin WHERE Email = @Email AND Password = @Password", connection))
                {
                    command.Parameters.AddWithValue("@Email", CardNumtextBox.Text);
                    command.Parameters.AddWithValue("@Password", PinNumtextBox.Text);

                   
                    int rows = (int)command.ExecuteScalar();
                    if (rows > 0)
                    {
                       
                        MessageBox.Show("Welcome!");
                        Menu obj3 = new Menu();
                        obj3.Show();
                    }
                    else
                    {
                        
                        MessageBox.Show("Incorrect email or password.");
                    }
                }
            }
        }
    }
    }

