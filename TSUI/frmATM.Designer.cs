namespace TSUI
{
    partial class frmATM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.cmbATMId = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblAcType = new System.Windows.Forms.Label();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBillPayee
            // 
            this.lblBillPayee.AutoSize = true;
            this.lblBillPayee.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPayee.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBillPayee.Location = new System.Drawing.Point(180, 55);
            this.lblBillPayee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBillPayee.Name = "lblBillPayee";
            this.lblBillPayee.Size = new System.Drawing.Size(118, 29);
            this.lblBillPayee.TabIndex = 10;
            this.lblBillPayee.Text = "ATM Load";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 50);
            this.panel1.TabIndex = 9;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeading.Location = new System.Drawing.Point(96, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(284, 29);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "ATM Management System";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // cmbATMId
            // 
            this.cmbATMId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbATMId.FormattingEnabled = true;
            this.cmbATMId.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbATMId.Location = new System.Drawing.Point(134, 90);
            this.cmbATMId.Name = "cmbATMId";
            this.cmbATMId.Size = new System.Drawing.Size(111, 31);
            this.cmbATMId.TabIndex = 0;
            this.cmbATMId.SelectedIndexChanged += new System.EventHandler(this.cmbFAccount_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(134, 127);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(212, 31);
            this.txtAmount.TabIndex = 1;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeposit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeposit.Location = new System.Drawing.Point(356, 127);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(115, 38);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDeposit.Location = new System.Drawing.Point(16, 127);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(93, 29);
            this.lblDeposit.TabIndex = 39;
            this.lblDeposit.Text = "Deposit";
            // 
            // lblAcType
            // 
            this.lblAcType.AutoSize = true;
            this.lblAcType.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAcType.Location = new System.Drawing.Point(22, 90);
            this.lblAcType.Name = "lblAcType";
            this.lblAcType.Size = new System.Drawing.Size(91, 29);
            this.lblAcType.TabIndex = 40;
            this.lblAcType.Text = "ATM ID";
            this.lblAcType.Click += new System.EventHandler(this.lblAcType_Click);
            // 
            // txtBal
            // 
            this.txtBal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBal.Enabled = false;
            this.txtBal.Location = new System.Drawing.Point(134, 164);
            this.txtBal.Name = "txtBal";
            this.txtBal.Size = new System.Drawing.Size(212, 31);
            this.txtBal.TabIndex = 2;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBalance.Location = new System.Drawing.Point(16, 164);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(94, 29);
            this.lblBalance.TabIndex = 39;
            this.lblBalance.Text = "Balance";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(352, 172);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(122, 23);
            this.lblBack.TabIndex = 4;
            this.lblBack.TabStop = true;
            this.lblBack.Text = " Back to Main";
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // frmATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 203);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.cmbATMId);
            this.Controls.Add(this.txtBal);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblAcType);
            this.Controls.Add(this.lblBillPayee);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmATM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillPayee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox cmbATMId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblAcType;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.LinkLabel lblBack;
    }
}