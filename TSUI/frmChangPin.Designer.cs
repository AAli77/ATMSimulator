namespace TSUI
{
    partial class frmChangPin
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
            this.lblPinChange = new System.Windows.Forms.Label();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.lblSABal = new System.Windows.Forms.Label();
            this.lblCABal = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtCPIN = new System.Windows.Forms.TextBox();
            this.txtNPIN = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.LinkLabel();
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
            this.panel1.Size = new System.Drawing.Size(486, 45);
            this.panel1.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeading.Location = new System.Drawing.Point(93, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(284, 29);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "ATM Management System";
            // 
            // lblPinChange
            // 
            this.lblPinChange.AutoSize = true;
            this.lblPinChange.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinChange.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPinChange.Location = new System.Drawing.Point(193, 61);
            this.lblPinChange.Name = "lblPinChange";
            this.lblPinChange.Size = new System.Drawing.Size(123, 29);
            this.lblPinChange.TabIndex = 4;
            this.lblPinChange.Text = "PinChange";
            // 
            // txtAccNo
            // 
            this.txtAccNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAccNo.Enabled = false;
            this.txtAccNo.Location = new System.Drawing.Point(198, 105);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(262, 31);
            this.txtAccNo.TabIndex = 9;
            // 
            // lblSABal
            // 
            this.lblSABal.AutoSize = true;
            this.lblSABal.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSABal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSABal.Location = new System.Drawing.Point(19, 189);
            this.lblSABal.Name = "lblSABal";
            this.lblSABal.Size = new System.Drawing.Size(138, 29);
            this.lblSABal.TabIndex = 6;
            this.lblSABal.Text = "Confirm PIN";
            // 
            // lblCABal
            // 
            this.lblCABal.AutoSize = true;
            this.lblCABal.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCABal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCABal.Location = new System.Drawing.Point(19, 147);
            this.lblCABal.Name = "lblCABal";
            this.lblCABal.Size = new System.Drawing.Size(103, 29);
            this.lblCABal.TabIndex = 7;
            this.lblCABal.Text = "New PIN";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAccount.Location = new System.Drawing.Point(19, 107);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(141, 29);
            this.lblAccount.TabIndex = 8;
            this.lblAccount.Text = "Account No.";
            // 
            // txtCPIN
            // 
            this.txtCPIN.Location = new System.Drawing.Point(198, 187);
            this.txtCPIN.Name = "txtCPIN";
            this.txtCPIN.Size = new System.Drawing.Size(118, 31);
            this.txtCPIN.TabIndex = 1;
            // 
            // txtNPIN
            // 
            this.txtNPIN.Location = new System.Drawing.Point(198, 147);
            this.txtNPIN.Name = "txtNPIN";
            this.txtNPIN.Size = new System.Drawing.Size(118, 31);
            this.txtNPIN.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdate.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(325, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 38);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update PIN";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(333, 256);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(118, 23);
            this.lblBack.TabIndex = 13;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "Back to Main";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // frmChangPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 289);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtNPIN);
            this.Controls.Add(this.txtCPIN);
            this.Controls.Add(this.lblSABal);
            this.Controls.Add(this.lblCABal);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblPinChange);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmChangPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChPin";
            this.Load += new System.EventHandler(this.frmChangPin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblPinChange;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Label lblSABal;
        private System.Windows.Forms.Label lblCABal;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtCPIN;
        private System.Windows.Forms.TextBox txtNPIN;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.LinkLabel lblBack;
    }
}