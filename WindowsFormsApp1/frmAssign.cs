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
    public partial class frmAssign : Form
    {
        public frmAssign()
        {
            InitializeComponent();
        }

        private void frmAssign_Load(object sender, EventArgs e)
        {
           


        }

        private void btnAssgin_Click(object sender, EventArgs e)
        {

            DialogResult logout = MessageBox.Show("Do you Want to Assign Job " + "", "Assign", MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes)
            {
                //set to accepted order
                Database.assgin(textBox1.Text, textBox2.Text);

            }
            

        }
    }
}
