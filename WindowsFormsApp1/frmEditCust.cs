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
    public partial class frmEditCust : Form
    {

        int cust_id;
        
        public frmEditCust(int cust_id)
        {
            InitializeComponent();
            this.cust_id = cust_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = Database.connectDB();
            if (txtName.Text.Length > 0)
            {
                string query = "UPDATE CUSTOMERS set f_name='" + txtName.Text + "' WHERE cust_id ='"+cust_id+"'";
                SqlDataAdapter sad = new SqlDataAdapter(query, con);
                sad.SelectCommand.ExecuteNonQuery();

            }
            if (txtLname.Text.Length > 0)
            {
                string query = "UPDATE CUSTOMERS set l_name='" + txtLname.Text + "' WHERE cust_id ='" + cust_id + "'";
                SqlDataAdapter sad = new SqlDataAdapter(query, con);
                sad.SelectCommand.ExecuteNonQuery();

            }
            if (txtAddress.Text.Length > 0)
            {
                string query = "UPDATE CUSTOMERS set address='" + txtAddress.Text + "' WHERE cust_id ='" + cust_id + "'";
                SqlDataAdapter sad = new SqlDataAdapter(query, con);
                sad.SelectCommand.ExecuteNonQuery();

            }
            if (txtMobile.Text.Length > 0)
            {
                string query = "UPDATE CUSTOMERS set mobile_no='" + txtMobile.Text + "' WHERE cust_id ='" + cust_id + "'";
                SqlDataAdapter sad = new SqlDataAdapter(query, con);
                sad.SelectCommand.ExecuteNonQuery();

            }
            if (txtEmail.Text.Length > 0)
            {
                string query = "UPDATE CUSTOMERS set email='" + txtEmail.Text + "' WHERE cust_id ='" + cust_id + "'";
                SqlDataAdapter sad = new SqlDataAdapter(query, con);
                sad.SelectCommand.ExecuteNonQuery();

            }

           // frmManager.dataGridViewCustomer.DataSource = Database.populateCustomers();

            con.Close();
            this.Close();

        }

        private void frmEditCust_Load(object sender, EventArgs e)
        {

        }
    }
    }

