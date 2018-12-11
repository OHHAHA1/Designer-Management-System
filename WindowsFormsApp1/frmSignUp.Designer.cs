namespace WindowsFormsApp1
{
    partial class frmSignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.radMgr = new System.Windows.Forms.RadioButton();
            this.radDesigner = new System.Windows.Forms.RadioButton();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCPw = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCPw);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPw);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radDesigner);
            this.groupBox1.Controls.Add(this.radMgr);
            this.groupBox1.Controls.Add(this.txtLname);
            this.groupBox1.Controls.Add(this.txtUname);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(113, 52);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(192, 27);
            this.txtFname.TabIndex = 6;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(113, 98);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(192, 27);
            this.txtUname.TabIndex = 7;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(421, 51);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(203, 27);
            this.txtLname.TabIndex = 8;
            // 
            // radMgr
            // 
            this.radMgr.AutoSize = true;
            this.radMgr.Location = new System.Drawing.Point(106, 150);
            this.radMgr.Name = "radMgr";
            this.radMgr.Size = new System.Drawing.Size(95, 24);
            this.radMgr.TabIndex = 9;
            this.radMgr.TabStop = true;
            this.radMgr.Text = "Manager";
            this.radMgr.UseVisualStyleBackColor = true;
            // 
            // radDesigner
            // 
            this.radDesigner.AutoSize = true;
            this.radDesigner.Location = new System.Drawing.Point(217, 150);
            this.radDesigner.Name = "radDesigner";
            this.radDesigner.Size = new System.Drawing.Size(98, 24);
            this.radDesigner.TabIndex = 10;
            this.radDesigner.TabStop = true;
            this.radDesigner.Text = "Designer";
            this.radDesigner.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(258, 391);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(179, 37);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(113, 213);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '#';
            this.txtPw.Size = new System.Drawing.Size(192, 27);
            this.txtPw.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Confirm Password";
            // 
            // txtCPw
            // 
            this.txtCPw.Location = new System.Drawing.Point(473, 211);
            this.txtCPw.Name = "txtCPw";
            this.txtCPw.PasswordChar = '#';
            this.txtCPw.Size = new System.Drawing.Size(192, 27);
            this.txtCPw.TabIndex = 14;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 452);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSignUp";
            this.Text = "frmSignUp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDesigner;
        private System.Windows.Forms.RadioButton radMgr;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtCPw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label label6;
    }
}