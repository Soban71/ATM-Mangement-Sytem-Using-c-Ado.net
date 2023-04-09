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
using static System.Net.Mime.MediaTypeNames;

namespace ATMMangementSystem
{
    public partial class AccountDetailscs : Form
    {
        public AccountDetailscs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentLoad(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccountDetailscs_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("data source= ; database=AtmMangementSystem; Integrated Security=true");
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM signup", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
