namespace WindowsFormsApp1.DesignerSubViews
{
    partial class frmSubmitDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPreview = new System.Windows.Forms.Button();
            this.btnSubmitDesign = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBoxPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(32, 62);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(383, 20);
            this.txtSourcePath.TabIndex = 0;
            this.txtSourcePath.Text = "C:/Desktop/my.jpg";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(340, 88);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source File";
            // 
            // btnAddPreview
            // 
            this.btnAddPreview.Location = new System.Drawing.Point(32, 124);
            this.btnAddPreview.Name = "btnAddPreview";
            this.btnAddPreview.Size = new System.Drawing.Size(75, 23);
            this.btnAddPreview.TabIndex = 4;
            this.btnAddPreview.Text = "Add Preview";
            this.btnAddPreview.UseVisualStyleBackColor = true;
            this.btnAddPreview.Click += new System.EventHandler(this.btnAddPreview_Click);
            // 
            // btnSubmitDesign
            // 
            this.btnSubmitDesign.Location = new System.Drawing.Point(310, 386);
            this.btnSubmitDesign.Name = "btnSubmitDesign";
            this.btnSubmitDesign.Size = new System.Drawing.Size(105, 23);
            this.btnSubmitDesign.TabIndex = 5;
            this.btnSubmitDesign.Text = "Submit Design";
            this.btnSubmitDesign.UseVisualStyleBackColor = true;
            this.btnSubmitDesign.Click += new System.EventHandler(this.btnSubmitDesign_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(82, 15);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 7;
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(315, 15);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.ReadOnly = true;
            this.txtProductType.Size = new System.Drawing.Size(100, 20);
            this.txtProductType.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Type";
            // 
            // picBoxPreview
            // 
            this.picBoxPreview.Location = new System.Drawing.Point(32, 155);
            this.picBoxPreview.Name = "picBoxPreview";
            this.picBoxPreview.Size = new System.Drawing.Size(383, 213);
            this.picBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPreview.TabIndex = 3;
            this.picBoxPreview.TabStop = false;
            // 
            // frmSubmitDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 430);
            this.Controls.Add(this.txtProductType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmitDesign);
            this.Controls.Add(this.btnAddPreview);
            this.Controls.Add(this.picBoxPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSourcePath);
            this.Name = "frmSubmitDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit Design";
            this.Load += new System.EventHandler(this.frmSubmitDesign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxPreview;
        private System.Windows.Forms.Button btnAddPreview;
        private System.Windows.Forms.Button btnSubmitDesign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Label label3;
    }
}