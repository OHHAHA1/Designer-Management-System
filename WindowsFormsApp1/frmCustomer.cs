using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCustomer : Form
    {
        ProjectC_Cus_DetEntities db1;

        public frmCustomer(Customer obj)
        {
            InitializeComponent();
            db1 = new ProjectC_Cus_DetEntities();
            if (obj == null)
            {
                customerDetBindingSource.DataSource = new Customer_Det();
                db1.Customer_Det.Add(customerDetBindingSource.Current as Customer_Det);
            }
            else
            {
                customerDetBindingSource.DataSource = obj;
                db1.Customer_Det.Attach(customerDetBindingSource.Current as Customer_Det);
            }

        }

        private void frnNewCustomer_FormCloasing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtCustomerName.Text))
                {
                    MessageBox.Show("Please enter a Customer name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerName.Focus();
                    e.Cancel = true;
                }
                db1.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
