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
    public partial class frmDesigner : Form
    {
        public frmDesigner(string username)
        {
            InitializeComponent();
            lblUsername.Text = username;
            lblName.Text = Database.getName(username);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void frmDesigner_Load(object sender, EventArgs e)
        {

            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           DialogResult logout= MessageBox.Show( "Are You Sure?", "Logout", MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes)
            {
                // should get back to login form
                this.Close();
            }

        }
    }
}
