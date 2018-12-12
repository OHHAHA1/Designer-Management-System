using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //btnLogin.MouseEnter += OnMouseEnterbtnLogin();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Red;
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
  
            if (Database.checkLogin(username,password)) // checking with database password
            {
                string type = Database.getLoginType(username);
                if (type=="Designer")
                {
                    Console.Write("Designer");
                     frmDesigner nextForm = new frmDesigner(username);
                    this.Hide();
                    nextForm.ShowDialog();
                }
                else if (type == "Manager") {
                    Console.Write("Designer");
                    frmManager nextForm = new frmManager(txtUsername.Text);
                    this.Hide();
                    nextForm.ShowDialog();
                }   
                this.Close();
            }
            else {
                MessageBox.Show("Check your username or password", "Login Failed!", MessageBoxButtons.OK);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
