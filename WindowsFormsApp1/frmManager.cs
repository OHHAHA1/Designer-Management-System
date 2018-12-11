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
    public partial class frmManager : Form
    {

        ProjectCEntities db;
        ProjectC_Cus_DetEntities db1;

        public frmManager()
        {
            InitializeComponent();
            
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (frmCustomer frm = new frmCustomer(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    customerDetBindingSource.DataSource = db1.Customer_Det.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(frmNewItem frm = new frmNewItem(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    orderBindingSource.DataSource = db.Orders.ToList();
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            db = new ProjectCEntities();
            orderBindingSource.DataSource = db.Orders.ToList();

            db1 = new ProjectC_Cus_DetEntities();
            customerDetBindingSource.DataSource = db1.Customer_Det.ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (orderBindingSource.Current == null)
                return;
            using(frmNewItem frm = new frmNewItem(orderBindingSource.Current as Order))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    orderBindingSource.DataSource = db.Orders.ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(orderBindingSource.Current != null)
            {
                if(MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Orders.Remove(orderBindingSource.Current as Order);
                    orderBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (customerDetBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db1.Customer_Det.Remove(customerDetBindingSource.Current as Customer_Det);
                    customerDetBindingSource.RemoveCurrent();
                    db1.SaveChanges();
                }
            }
        }
    }
}
