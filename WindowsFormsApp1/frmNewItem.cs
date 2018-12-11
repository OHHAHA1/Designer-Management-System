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
    public partial class frmNewItem : Form
    {
        ProjectCEntities db;

        public frmNewItem(Order obj)
        {
            InitializeComponent();
            db = new ProjectCEntities();
            if(obj == null)
            {
                orderBindingSource.DataSource = new Order();
                db.Orders.Add(orderBindingSource.Current as Order);
            }
            else
            {
                orderBindingSource.DataSource = obj;
                db.Orders.Attach(orderBindingSource.Current as Order);
            }
        }

        private void frmNewItem_Load(object sender, EventArgs e)
        {

        }

        private void frmNewItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtCustomerName.Text))
                {
                    MessageBox.Show("Please enter a Customer name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerName.Focus();
                    e.Cancel = true;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
