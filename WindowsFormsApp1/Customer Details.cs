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
    public partial class frmCustomer_Details : Form
    {
        int cust_id;
        public frmCustomer_Details(int cust_id)
        {
            InitializeComponent();
            this.cust_id = cust_id;
        }

        private void frmCustomer_Details_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Database.connectDB();
            string query = "select * from CUSTOMERS WHERE cust_id = '" + cust_id + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read())
            {
                lblName.Text = dt["f_name"].ToString();
                lbll_name.Text = dt["l_name"].ToString();
                lblAddress.Text = dt["address"].ToString();
                lblPhone.Text = dt["mobile_no"].ToString();
                lblEmail.Text = dt["email"].ToString();
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditCust edit = new frmEditCust(cust_id);
            this.Hide();
            edit.ShowDialog();
        }
    }
}
