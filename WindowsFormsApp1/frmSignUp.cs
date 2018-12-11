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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String fname, lname, uname, category, pword, cpword;

            fname = txtFname.Text;
            lname = txtLname.Text;
            uname = txtUname.Text;
            pword = txtPw.Text;
            cpword = txtCPw.Text;

            if (radMgr.Checked)
            {
                category = "Manager";
            } else if (radDesigner.Checked)
            {
                category = "Designer";
            } else
            {
                category = "";
            }

            if (fname == "" || lname == "" || uname == "" || category == "" || pword == "" || cpword == "")
            {
                MessageBox.Show("Empty Fields are Available", "Error");
            } else
            {
                if(pword != cpword)
                {
                    MessageBox.Show("Passwords doesn't match each other", "Password Error");
                } else
                {
                    //insert into database
                    MessageBox.Show("Success");
                }
            }
        }
    }
}
