namespace TSUI
{
    partial class frmTransfer
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.cmbFAccount = new System.Windows.Forms.ComboBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAcType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTAccount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFAcBal = new System.Windows.Forms.Label();
            this.lblTAcBal = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeading.Location = new System.Drawing.Point(152, 9);
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
            this.panel1.Size = new System.Drawing.Size(575, 50);
            this.panel1.TabIndex = 2;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDeposit.Location = new System.Drawing.Point(146, 54);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(296, 29);
            this.lblDeposit.TabIndex = 6;
            this.lblDeposit.Text = "Transfer Funds b/w Account";
            // 
            // cmbFAccount
            // 
            this.cmbFAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFAccount.FormattingEnabled = true;
            this.cmbFAccount.Items.AddRange(new object[] {
            "Chequing Account",
            "Saving Account"});
            this.cmbFAccount.Location = new System.Drawing.Point(205, 133);
            this.cmbFAccount.Name = "cmbFAccount";
            this.cmbFAccount.Size = new System.Drawing.Size(217, 31);
            this.cmbFAccount.TabIndex = 28;
            this.cmbFAccount.SelectedIndexChanged += new System.EventHandler(this.cmbFAccount_SelectedIndexChanged);
            // 
            // txtAccNo
            // 
            this.txtAccNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAccNo.Enabled = false;
            this.txtAccNo.Location = new System.Drawing.Point(205, 89);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(217, 31);
            this.txtAccNo.TabIndex = 26;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(205, 224);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(217, 31);
            this.txtAmount.TabIndex = 27;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTransfer.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransfer.Location = new System.Drawing.Point(433, 224);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(130, 38);
            this.btnTransfer.TabIndex = 24;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAmount.Location = new System.Drawing.Point(26, 224);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(97, 29);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "Amount";
            // 
            // lblAcType
            // 
            this.lblAcType.AutoSize = true;
            this.lblAcType.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAcType.Location = new System.Drawing.Point(26, 133);
            this.lblAcType.Name = "lblAcType";
            this.lblAcType.Size = new System.Drawing.Size(157, 29);
            this.lblAcType.TabIndex = 22;
            this.lblAcType.Text = "From Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Account No.";
            // 
            // cmbTAccount
            // 
            this.cmbTAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTAccount.FormattingEnabled = true;
            this.cmbTAccount.Items.AddRange(new object[] {
            "Chequing Account",
            "Saving Account"});
            this.cmbTAccount.Location = new System.Drawing.Point(205, 179);
            this.cmbTAccount.Name = "cmbTAccount";
            this.cmbTAccount.Size = new System.Drawing.Size(217, 31);
            this.cmbTAccount.TabIndex = 28;
            this.cmbTAccount.SelectedIndexChanged += new System.EventHandler(this.cmbTAccount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(26, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "To Account";
            // 
            // lblFAcBal
            // 
            this.lblFAcBal.AutoSize = true;
            this.lblFAcBal.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFAcBal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblFAcBal.Location = new System.Drawing.Point(428, 133);
            this.lblFAcBal.Name = "lblFAcBal";
            this.lblFAcBal.Size = new System.Drawing.Size(132, 29);
            this.lblFAcBal.TabIndex = 32;
            this.lblFAcBal.Text = "AccBalance";
            // 
            // lblTAcBal
            // 
            this.lblTAcBal.AutoSize = true;
            this.lblTAcBal.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTAcBal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTAcBal.Location = new System.Drawing.Point(428, 177);
            this.lblTAcBal.Name = "lblTAcBal";
            this.lblTAcBal.Size = new System.Drawing.Size(132, 29);
            this.lblTAcBal.TabIndex = 33;
            this.lblTAcBal.Text = "AccBalance";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(442, 265);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(118, 23);
            this.lblBack.TabIndex = 34;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "Back to Main";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 289);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblTAcBal);
            this.Controls.Add(this.lblFAcBal);
            this.Controls.Add(this.cmbTAccount);
            this.Controls.Add(this.cmbFAccount);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAcType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.ComboBox cmbFAccount;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAcType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFAcBal;
        private System.Windows.Forms.Label lblTAcBal;
        private System.Windows.Forms.LinkLabel lblBack;
    }
}