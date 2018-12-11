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
using WindowsFormsApp1.DesignerSubViews;
using System.IO;



namespace WindowsFormsApp1
{
   
    public partial class frmDesigner : Form
    {
        int selectedRow;
        string username;
        string systermPath = @"D:\C#";
        public frmDesigner(string username)
        {
            InitializeComponent();
            lblUsername.Text = username;
            this.username = username;
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
            CurrentJobDetails details = new CurrentJobDetails(txtOrderNum.Text);
            details.Show();
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
            dataGridJobRequest.DataSource = Database.populateJobRequest(lblUsername.Text);
            populateRevisionRequest();
            string imagePath = Path.Combine(Path.Combine(systermPath, "userpic"),username+".jpg");
            picUser.Image = new Bitmap(imagePath);
        }

        private void populateRevisionRequest()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Order ID", typeof(string));
            table.Columns.Add("Revision", typeof(string));

            table.Rows.Add("ODR-001", "This is fucking change");
            table.Rows.Add("ODR-002", "This is another fucking change");
            table.Rows.Add("ODR-003", "This is one more fucking change");

            dataGridRevision.DataSource = table;
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


        private void btnAcceptJob_Click(object sender, EventArgs e)
        {
            
            DialogResult logout = MessageBox.Show("Do you Want to Accept Job Request"+"", "Logout", MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes)
            {
                //set to accepted order
                DataGridViewRow row = dataGridJobRequest.Rows[selectedRow];
                txtOrderNum.Text= row.Cells[0].Value.ToString();
                txtDesignType.Text = row.Cells[1].Value.ToString();

            }
        }

        private void dataGridJobRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btnSubmitDesign_Click(object sender, EventArgs e)
        {
            frmSubmitDesign submit = new frmSubmitDesign(txtOrderNum.Text,txtDesignType.Text);
            submit.Show();
        }

        private void frmDesigner_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }

        }
        private void btnMessages_Click(object sender, EventArgs e)
        {
            frmChatInterface submit = new frmChatInterface(lblUsername.Text);
            submit.Show();
        }

    }
}
