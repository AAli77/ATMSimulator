namespace TSUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 53);
            this.panel1.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeading.Location = new System.Drawing.Point(140, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(284, 29);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "ATM Management System";
            // 
            // lblSecurity
            // 
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurity.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSecurity.Location = new System.Drawing.Point(232, 68);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(98, 29);
            this.lblSecurity.TabIndex = 1;
            this.lblSecurity.Text = "Security";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAccount.Location = new System.Drawing.Point(152, 126);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(112, 23);
            this.lblAccount.TabIndex = 3;
            this.lblAccount.Text = "Account No.";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPin.Location = new System.Drawing.Point(152, 166);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(79, 23);
            this.lblPin.TabIndex = 4;
            this.lblPin.Text = " PIN No.";
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtAccount.Location = new System.Drawing.Point(270, 126);
            this.txtAccount.MaxLength = 8;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(158, 31);
            this.txtAccount.TabIndex = 0;
            // 
            // txtPIN
            // 
            this.txtPIN.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPIN.Location = new System.Drawing.Point(270, 166);
            this.txtPIN.MaxLength = 4;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(158, 31);
            this.txtPIN.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(434, 126);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(434, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 246);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSecurity);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}