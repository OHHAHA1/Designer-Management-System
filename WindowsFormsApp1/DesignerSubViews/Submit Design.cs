using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1.DesignerSubViews
{

    
    public partial class frmSubmitDesign : Form
    {
        string sourceFileDestination = null;

        public frmSubmitDesign(String order_id, string product)
        {
            InitializeComponent();
            txtOrderID.Text = order_id;
            txtProductType.Text = product;
        }

        private void frmSubmitDesign_Load(object sender, EventArgs e)
        {
            
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtSourcePath.Text = ofd.FileName;
            }
        }

        private void btnAddPreview_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {


                    string path = ofd.FileName;
                    Console.WriteLine(path);
                    picBoxPreview.Image = new Bitmap(path);      
                  //  MessageBox.Show("Please Select A File","No file Found",MessageBoxButtons.OK);


            }
        }

        private void btnSubmitDesign_Click(object sender, EventArgs e)
        {
            sourceFileDestination = @"D:\C#";// this destination should set by manager on first start
            String fileName =Path.GetFileName(txtSourcePath.Text);

            String subFolder = txtOrderID.Text;
            if (subFolder == "")
            {
                 subFolder = Interaction.InputBox("Enter Order ID", "Order ID");
            }
            sourceFileDestination = Path.Combine(sourceFileDestination, subFolder);
            Directory.CreateDirectory(sourceFileDestination);

            frmSubmiting submit = new frmSubmiting(txtSourcePath.Text, Path.Combine(sourceFileDestination, fileName));
            submit.Show();
        }
    }
}
