namespace WindowsFormsApp1
{
    partial class frmDesigner
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
            this.btnSubmitDesign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesignType = new System.Windows.Forms.TextBox();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnAcceptJob = new System.Windows.Forms.Button();
            this.btnAcceptRevision = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.dataGridJobRequest = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridRevision = new System.Windows.Forms.DataGridView();
            this.btnMessages = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJobRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRevision)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmitDesign
            // 
            this.btnSubmitDesign.Location = new System.Drawing.Point(449, 120);
            this.btnSubmitDesign.Name = "btnSubmitDesign";
            this.btnSubmitDesign.Size = new System.Drawing.Size(107, 24);
            this.btnSubmitDesign.TabIndex = 4;
            this.btnSubmitDesign.Text = "Submit Designs";
            this.btnSubmitDesign.UseVisualStyleBackColor = true;
            this.btnSubmitDesign.Click += new System.EventHandler(this.btnSubmitDesign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Job";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Design Type:";
            // 
            // txtDesignType
            // 
            this.txtDesignType.Location = new System.Drawing.Point(459, 53);
            this.txtDesignType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDesignType.Name = "txtDesignType";
            this.txtDesignType.ReadOnly = true;
            this.txtDesignType.Size = new System.Drawing.Size(178, 20);
            this.txtDesignType.TabIndex = 12;
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(459, 84);
            this.txtOrderNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.ReadOnly = true;
            this.txtOrderNum.Size = new System.Drawing.Size(178, 20);
            this.txtOrderNum.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(169, 21);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "First Name Last Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(172, 109);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 23);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(225, 41);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 13);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(565, 121);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(72, 23);
            this.btnDetails.TabIndex = 19;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAcceptJob
            // 
            this.btnAcceptJob.Location = new System.Drawing.Point(10, 424);
            this.btnAcceptJob.Name = "btnAcceptJob";
            this.btnAcceptJob.Size = new System.Drawing.Size(294, 24);
            this.btnAcceptJob.TabIndex = 6;
            this.btnAcceptJob.Text = "Accept";
            this.btnAcceptJob.UseVisualStyleBackColor = true;
            this.btnAcceptJob.Click += new System.EventHandler(this.btnAcceptJob_Click);
            // 
            // btnAcceptRevision
            // 
            this.btnAcceptRevision.Location = new System.Drawing.Point(347, 424);
            this.btnAcceptRevision.Name = "btnAcceptRevision";
            this.btnAcceptRevision.Size = new System.Drawing.Size(290, 24);
            this.btnAcceptRevision.TabIndex = 7;
            this.btnAcceptRevision.Text = "Accept Revision";
            this.btnAcceptRevision.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditAccount);
            this.groupBox1.Controls.Add(this.picUser);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(284, 172);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(172, 136);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(95, 23);
            this.btnEditAccount.TabIndex = 19;
            this.btnEditAccount.Text = "Edit Account";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(4, 15);
            this.picUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(154, 153);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 15;
            this.picUser.TabStop = false;
            // 
            // dataGridJobRequest
            // 
            this.dataGridJobRequest.AllowUserToAddRows = false;
            this.dataGridJobRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridJobRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJobRequest.Location = new System.Drawing.Point(10, 263);
            this.dataGridJobRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridJobRequest.Name = "dataGridJobRequest";
            this.dataGridJobRequest.Size = new System.Drawing.Size(294, 156);
            this.dataGridJobRequest.TabIndex = 21;
            this.dataGridJobRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridJobRequest_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Job Requests";
            // 
            // dataGridRevision
            // 
            this.dataGridRevision.AllowUserToAddRows = false;
            this.dataGridRevision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRevision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRevision.Location = new System.Drawing.Point(347, 263);
            this.dataGridRevision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridRevision.Name = "dataGridRevision";
            this.dataGridRevision.Size = new System.Drawing.Size(290, 156);
            this.dataGridRevision.TabIndex = 23;
            this.dataGridRevision.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnMessages
            // 
            this.btnMessages.Location = new System.Drawing.Point(449, 160);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(188, 24);
            this.btnMessages.TabIndex = 7;
            this.btnMessages.Text = "Messages";
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // frmDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 458);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.dataGridRevision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridJobRequest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAcceptJob);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnAcceptRevision);
            this.Controls.Add(this.btnSubmitDesign);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.txtDesignType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desinger";
            this.Load += new System.EventHandler(this.frmDesigner_Load);
            this.Resize += new System.EventHandler(this.frmDesigner_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJobRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRevision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmitDesign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesignType;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnAcceptJob;
        private System.Windows.Forms.Button btnAcceptRevision;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.DataGridView dataGridJobRequest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridRevision;
        private System.Windows.Forms.Button btnMessages;
    }
}