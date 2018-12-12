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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class AddCust : Form
    {
        public AddCust()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = Database.connectDB();
           
            
                string query = "INSERT INTO CUSTOMERS (f_name, l_name, email, address, mobile_no) VALUES('"+txtName.Text+"','"+txtLname.Text+"','"+txtEmail.Text+"','"+txtAddress.Text+"','"+txtMobile.Text+"')";
                SqlDataAdapter sad = new SqlDataAdapter(query, con);
                sad.SelectCommand.ExecuteNonQuery();
            // frmManager.dataGridViewCustomer.DataSource = Database.populateCustomers();

            con.Close();
            this.Close();
        }
    }
}
