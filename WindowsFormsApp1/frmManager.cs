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

namespace WindowsFormsApp1
{
    public partial class frmManager : Form
    {

        int selectedRow;
        public frmManager(string username)
        {
            InitializeComponent();
            lblUsername.Text =  username;
            lblLogName.Text = Database.getName(username);
            
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

            AddCust addcust = new AddCust();
            addcust.Show();

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

            dataGridOrder.DataSource = Database.populateOrders();
            dataGridViewCustomer.DataSource = Database.populateCustomers();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            frmChatInterface chat = new frmChatInterface(lblUsername.Text);
            chat.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewCustomer.Rows[selectedRow];
            frmCustomer_Details chat = new frmCustomer_Details((int)(row.Cells[0].Value));
            chat.Show();
        }

        private void dataGridViewCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // selectedRow = e.RowIndex;
        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void dataGridViewCustomer_Click(object sender, EventArgs e)
        {
            //dataGridViewCustomer.DataSource = Database.populateCustomers();
        }

        private void frmManager_MouseClick(object sender, MouseEventArgs e)
        {
         // 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewCustomer.Rows[selectedRow];
            invoice invoice = new invoice(row.Cells["Customer ID"].Value.ToString());
            invoice.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridViewCustomer.DataSource = Database.populateCustomers();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            frmAssign ass = new frmAssign();

        }
    }
}
