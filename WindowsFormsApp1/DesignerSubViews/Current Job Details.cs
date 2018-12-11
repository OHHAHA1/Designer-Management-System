using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DesignerSubViews
{
    public partial class CurrentJobDetails : Form
    {
        public CurrentJobDetails(string order_id)
        {
            InitializeComponent();
            string productType = Database.getProductType(order_id);
            string customerID = Database.getCustomerID(order_id);
            string customerName = Database.getCustomerName(customerID);
            string description = Database.getDescription(order_id);
            txtOrderID.Text = order_id;
            txtProductType.Text = productType;
            txtCustomerID.Text = customerID;
            txtCustomerName.Text = customerName;
            txtDescription.Text = description;
        }

        private void CurrentJobDetails_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
