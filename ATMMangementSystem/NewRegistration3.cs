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
    public partial class NewRegistration3 : Form
    {
        public NewRegistration3()
        {
            InitializeComponent();
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source= .; database=AtmMangementSystem; Integrated Security=true");
            con.Open();
            String Name = NametextBox.Text;
            String FatherName = FathertextBox.Text;
            String DOB = DobtextBox.Text;
            String Gender = GendergroupBox.Text;
            String City=CitytextBox.Text;
            String Acctype = AccTypegroupBox.Text;
            String Address= AddresstextBox.Text;
            String AccountNo = AccnotextBox.Text;
            String PinNo = PinNotextBox.Text;
            String Amount=AmounttextBox.Text;
            String Query = "INSERT INTO Signup(Name,FatherName,DOB,Gender,City,AccountType,Address,Accountno,Pincode,Amount )" +
        " VALUES ('" + Name + "', '" + FatherName + "', '" + DOB + "' , '" + Gender + "', '" + City + "', '" + Acctype + "'" +
        " , '" + Address + "' , '" + AccountNo + "' , '" + PinNo + "' , '" + Amount + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account Created Successfully");
            this.Close();
            Menu obj1 = new Menu();
            obj1.Show();
            
           
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Menu obj1 = new Menu();
            obj1.Show();
            this.Close();
        }
    }
}
