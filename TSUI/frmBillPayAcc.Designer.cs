namespace TSUI
{
    partial class frmBillPayAcc
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
            this.lblBillPayee = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPType = new System.Windows.Forms.TextBox();
            this.txtPAccount = new System.Windows.Forms.TextBox();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBillPayee
            // 
            this.lblBillPayee.AutoSize = true;
            this.lblBillPayee.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPayee.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBillPayee.Location = new System.Drawing.Point(196, 55);
            this.lblBillPayee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBillPayee.Name = "lblBillPayee";
            this.lblBillPayee.Size = new System.Drawing.Size(127, 29);
            this.lblBillPayee.TabIndex = 12;
            this.lblBillPayee.Text = "New Payee";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeading.Location = new System.Drawing.Point(117, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(284, 29);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "ATM Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 50);
            this.panel1.TabIndex = 11;
            // 
            // txtAccNo
            // 
            this.txtAccNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAccNo.Enabled = false;
            this.txtAccNo.Location = new System.Drawing.Point(183, 93);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(218, 31);
            this.txtAccNo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Account No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Payee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Payee Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Payee Account";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(183, 135);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(218, 31);
            this.txtPName.TabIndex = 0;
            // 
            // txtPType
            // 
            this.txtPType.Location = new System.Drawing.Point(183, 173);
            this.txtPType.Name = "txtPType";
            this.txtPType.Size = new System.Drawing.Size(218, 31);
            this.txtPType.TabIndex = 1;
            // 
            // txtPAccount
            // 
            this.txtPAccount.Location = new System.Drawing.Point(183, 213);
            this.txtPAccount.Name = "txtPAccount";
            this.txtPAccount.Size = new System.Drawing.Size(218, 31);
            this.txtPAccount.TabIndex = 2;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(407, 219);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(158, 23);
            this.lblBack.TabIndex = 4;
            this.lblBack.TabStop = true;
            this.lblBack.Text = " Back to BillPayee";
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(421, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmBillPayAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 254);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPAccount);
            this.Controls.Add(this.txtPType);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBillPayee);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmBillPayAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBillPayAcc";
            this.Load += new System.EventHandler(this.frmBillPayAcc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillPayee;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPType;
        private System.Windows.Forms.TextBox txtPAccount;
        private System.Windows.Forms.LinkLabel lblBack;
        private System.Windows.Forms.Button btnAdd;
    }
}