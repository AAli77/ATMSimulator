namespace TSUI
{
    partial class frmBillPayee
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
            this.cmbBillPayAcc = new System.Windows.Forms.ComboBox();
            this.cmbAcType = new System.Windows.Forms.ComboBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAcType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAcBal = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.llblNewBP = new System.Windows.Forms.LinkLabel();
            this.lblATM = new System.Windows.Forms.Label();
            this.txtATMId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBillPayee
            // 
            this.lblBillPayee.AutoSize = true;
            this.lblBillPayee.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPayee.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBillPayee.Location = new System.Drawing.Point(173, 55);
            this.lblBillPayee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBillPayee.Name = "lblBillPayee";
            this.lblBillPayee.Size = new System.Drawing.Size(113, 29);
            this.lblBillPayee.TabIndex = 8;
            this.lblBillPayee.Text = "Bill Payee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 50);
            this.panel1.TabIndex = 7;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeading.Location = new System.Drawing.Point(97, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(284, 29);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "ATM Management System";
            // 
            // cmbBillPayAcc
            // 
            this.cmbBillPayAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillPayAcc.FormattingEnabled = true;
            this.cmbBillPayAcc.Location = new System.Drawing.Point(156, 199);
            this.cmbBillPayAcc.Name = "cmbBillPayAcc";
            this.cmbBillPayAcc.Size = new System.Drawing.Size(246, 31);
            this.cmbBillPayAcc.TabIndex = 1;
            // 
            // cmbAcType
            // 
            this.cmbAcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcType.FormattingEnabled = true;
            this.cmbAcType.Items.AddRange(new object[] {
            "Chequing Account",
            "Saving Account"});
            this.cmbAcType.Location = new System.Drawing.Point(156, 159);
            this.cmbAcType.Name = "cmbAcType";
            this.cmbAcType.Size = new System.Drawing.Size(210, 31);
            this.cmbAcType.TabIndex = 0;
            this.cmbAcType.SelectedIndexChanged += new System.EventHandler(this.cmbAcType_SelectedIndexChanged);
            // 
            // txtAccNo
            // 
            this.txtAccNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAccNo.Enabled = false;
            this.txtAccNo.Location = new System.Drawing.Point(156, 121);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(210, 31);
            this.txtAccNo.TabIndex = 35;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(156, 239);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(130, 31);
            this.txtAmount.TabIndex = 2;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTransfer.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransfer.Location = new System.Drawing.Point(341, 239);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(164, 41);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Pay the Bill";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAmount.Location = new System.Drawing.Point(17, 239);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(97, 29);
            this.lblAmount.TabIndex = 29;
            this.lblAmount.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(17, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Bill Payee";
            // 
            // lblAcType
            // 
            this.lblAcType.AutoSize = true;
            this.lblAcType.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAcType.Location = new System.Drawing.Point(17, 159);
            this.lblAcType.Name = "lblAcType";
            this.lblAcType.Size = new System.Drawing.Size(99, 29);
            this.lblAcType.TabIndex = 31;
            this.lblAcType.Text = "Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(17, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Account No.";
            // 
            // lblAcBal
            // 
            this.lblAcBal.AutoSize = true;
            this.lblAcBal.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcBal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAcBal.Location = new System.Drawing.Point(366, 161);
            this.lblAcBal.Name = "lblAcBal";
            this.lblAcBal.Size = new System.Drawing.Size(132, 29);
            this.lblAcBal.TabIndex = 31;
            this.lblAcBal.Text = "AccBalance";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(387, 283);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(118, 23);
            this.lblBack.TabIndex = 4;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "Back to Main";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // llblNewBP
            // 
            this.llblNewBP.AutoSize = true;
            this.llblNewBP.Location = new System.Drawing.Point(402, 207);
            this.llblNewBP.Name = "llblNewBP";
            this.llblNewBP.Size = new System.Drawing.Size(103, 23);
            this.llblNewBP.TabIndex = 39;
            this.llblNewBP.TabStop = true;
            this.llblNewBP.Text = "New Payee";
            this.llblNewBP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNewBP_LinkClicked);
            // 
            // lblATM
            // 
            this.lblATM.AutoSize = true;
            this.lblATM.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATM.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblATM.Location = new System.Drawing.Point(17, 84);
            this.lblATM.Name = "lblATM";
            this.lblATM.Size = new System.Drawing.Size(141, 29);
            this.lblATM.TabIndex = 32;
            this.lblATM.Text = "Account No.";
            // 
            // txtATMId
            // 
            this.txtATMId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtATMId.Enabled = false;
            this.txtATMId.Location = new System.Drawing.Point(156, 84);
            this.txtATMId.Name = "txtATMId";
            this.txtATMId.Size = new System.Drawing.Size(56, 31);
            this.txtATMId.TabIndex = 35;
            // 
            // frmBillPayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 314);
            this.Controls.Add(this.llblNewBP);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.cmbBillPayAcc);
            this.Controls.Add(this.cmbAcType);
            this.Controls.Add(this.txtATMId);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAcBal);
            this.Controls.Add(this.lblAcType);
            this.Controls.Add(this.lblATM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBillPayee);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmBillPayee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBillPayee";
            this.Load += new System.EventHandler(this.frmBillPayee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillPayee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox cmbBillPayAcc;
        private System.Windows.Forms.ComboBox cmbAcType;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAcType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAcBal;
        private System.Windows.Forms.LinkLabel lblBack;
        private System.Windows.Forms.LinkLabel llblNewBP;
        private System.Windows.Forms.Label lblATM;
        private System.Windows.Forms.TextBox txtATMId;
    }
}