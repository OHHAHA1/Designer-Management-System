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

namespace WindowsFormsApp1.DesignerSubViews
{
    public partial class frmSubmiting : Form
    {

        BackgroundWorker worker = new BackgroundWorker();
        string inputFile = null;
        string outputFile = null;

        public frmSubmiting(string inputFile, string outputFile)
        {
            InitializeComponent();
            this.inputFile = inputFile;
            this.outputFile = outputFile;
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;
        }

        private void copyFile (string source, string destination, DoWorkEventArgs e)
        {
            Console.WriteLine(source);
            Console.WriteLine(destination);

            FileStream fsout = new FileStream(destination,FileMode.Create);
            FileStream fsin = new FileStream(source, FileMode.Open);
            byte[] buffer = new byte[1048756];//1mb
            int readBytes;
            while ((readBytes=fsin.Read(buffer,0,buffer.Length))> 0) {

                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    worker.ReportProgress(0);
                    fsin.Close();
                    fsout.Close();
                    return;
                }
                else
                {
                    fsout.Write(buffer, 0, readBytes);
                    worker.ReportProgress((int)(fsin.Position * 100 / fsin.Length));
                }   
            }
            fsin.Close();
            fsout.Close();
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblProgress.Text = progressBar1.Value.ToString() + "%" ;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progressBar1.Visible = false;
                DialogResult result = MessageBox.Show("Operation is aborted", "abort", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                progressBar1.Visible = false;
                DialogResult result = MessageBox.Show("Operation is Completed", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            copyFile(inputFile, outputFile,e);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void frmSubmiting_Load(object sender, EventArgs e)
        {
            if (worker.IsBusy)
            {
                
            }
            else
            {
                progressBar1.Visible = true;
                worker.RunWorkerAsync();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker.CancelAsync();
            
        }
    }
}
