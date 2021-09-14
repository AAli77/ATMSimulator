namespace TSUI
{
    partial class frmDeposit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAcType = new System.Windows.Forms.Label();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbAcType = new System.Windows.Forms.ComboBox();
            this.lblAcBal = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.txtATM = new System.Windows.Forms.TextBox();
            this.lblATMID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 45);
            this.panel1.TabIndex = 1;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeading.Location = new System.Drawing.Point(120, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(284, 29);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "ATM Management System";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDeposit.Location = new System.Drawing.Point(210, 52);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(93, 29);
            this.lblDeposit.TabIndex = 5;
            this.lblDeposit.Text = "Deposit";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeposit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeposit.Location = new System.Drawing.Point(399, 192);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(134, 38);
            this.btnDeposit.TabIndex = 16;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAccount.Location = new System.Drawing.Point(28, 141);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(141, 29);
            this.lblAccount.TabIndex = 15;
            this.lblAccount.Text = "Account No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(28, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Account No.";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAmount.Location = new System.Drawing.Point(28, 253);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(97, 29);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "Amount";
            // 
            // lblAcType
            // 
            this.lblAcType.AutoSize = true;
            this.lblAcType.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAcType.Location = new System.Drawing.Point(28, 179);
            this.lblAcType.Name = "lblAcType";
            this.lblAcType.Size = new System.Drawing.Size(99, 29);
            this.lblAcType.TabIndex = 15;
            this.lblAcType.Text = "Account";
            this.lblAcType.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAccNo
            // 
            this.txtAccNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAccNo.Enabled = false;
            this.txtAccNo.Location = new System.Drawing.Point(175, 139);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(218, 31);
            this.txtAccNo.TabIndex = 18;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(175, 256);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(218, 31);
            this.txtAmount.TabIndex = 19;
            // 
            // cmbAcType
            // 
            this.cmbAcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcType.FormattingEnabled = true;
            this.cmbAcType.Location = new System.Drawing.Point(175, 179);
            this.cmbAcType.Name = "cmbAcType";
            this.cmbAcType.Size = new System.Drawing.Size(218, 31);
            this.cmbAcType.TabIndex = 20;
            this.cmbAcType.SelectedIndexChanged += new System.EventHandler(this.cmbAcType_SelectedIndexChanged);
            // 
            // lblAcBal
            // 
            this.lblAcBal.AutoSize = true;
            this.lblAcBal.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcBal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAcBal.Location = new System.Drawing.Point(261, 218);
            this.lblAcBal.Name = "lblAcBal";
            this.lblAcBal.Size = new System.Drawing.Size(132, 29);
            this.lblAcBal.TabIndex = 32;
            this.lblAcBal.Text = "AccBalance";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(399, 248);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(122, 23);
            this.lblBack.TabIndex = 33;
            this.lblBack.TabStop = true;
            this.lblBack.Text = " Back to Main";
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // txtATM
            // 
            this.txtATM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtATM.Enabled = false;
            this.txtATM.Location = new System.Drawing.Point(175, 102);
            this.txtATM.Name = "txtATM";
            this.txtATM.Size = new System.Drawing.Size(66, 31);
            this.txtATM.TabIndex = 18;
            // 
            // lblATMID
            // 
            this.lblATMID.AutoSize = true;
            this.lblATMID.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATMID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblATMID.Location = new System.Drawing.Point(28, 102);
            this.lblATMID.Name = "lblATMID";
            this.lblATMID.Size = new System.Drawing.Size(91, 29);
            this.lblATMID.TabIndex = 15;
            this.lblATMID.Text = "ATM ID";
            // 
            // frmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 296);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblAcBal);
            this.Controls.Add(this.cmbAcType);
            this.Controls.Add(this.txtATM);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAcType);
            this.Controls.Add(this.lblATMID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeposit";
            this.Load += new System.EventHandler(this.frmDeposit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAcType;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbAcType;
        private System.Windows.Forms.Label lblAcBal;
        private System.Windows.Forms.LinkLabel lblBack;
        private System.Windows.Forms.TextBox txtATM;
        private System.Windows.Forms.Label lblATMID;
    }
}