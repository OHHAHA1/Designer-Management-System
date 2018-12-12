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
    public partial class invoice : Form

    {
        string cust_id;
        public invoice(string cust_id)
        {
            InitializeComponent();
            this.cust_id = cust_id;

        }

        private void invoice_Load(object sender, EventArgs e)

        {
            dataGridOrders.DataSource = Database.populateOrders(lblCustID.Text);
            lbl_total.Text = Database.total.ToString();
        }

        private void comboBoxCustID_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridOrders.DataSource = Database.populateOrders(cust_id);
        }
    }
}
