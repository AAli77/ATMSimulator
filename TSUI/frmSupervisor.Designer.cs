namespace TSUI
{
    partial class frmSupervisor
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
            this.lblMainMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnfillATM = new System.Windows.Forms.Button();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.btnBLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainMessage
            // 
            this.lblMainMessage.AutoSize = true;
            this.lblMainMessage.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMessage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMainMessage.Location = new System.Drawing.Point(204, 55);
            this.lblMainMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMainMessage.Name = "lblMainMessage";
            this.lblMainMessage.Size = new System.Drawing.Size(185, 29);
            this.lblMainMessage.TabIndex = 8;
            this.lblMainMessage.Text = "Supervisor Menu";
            this.lblMainMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 50);
            this.panel1.TabIndex = 7;
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
            // btnfillATM
            // 
            this.btnfillATM.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnfillATM.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnfillATM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnfillATM.Location = new System.Drawing.Point(193, 177);
            this.btnfillATM.Name = "btnfillATM";
            this.btnfillATM.Size = new System.Drawing.Size(210, 66);
            this.btnfillATM.TabIndex = 11;
            this.btnfillATM.Text = "Fill ATM";
            this.btnfillATM.UseVisualStyleBackColor = false;
            this.btnfillATM.Click += new System.EventHandler(this.btnfillATM_Click);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNewAccount.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNewAccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewAccount.Location = new System.Drawing.Point(193, 94);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(210, 66);
            this.btnNewAccount.TabIndex = 10;
            this.btnNewAccount.Text = "&New Account";
            this.btnNewAccount.UseVisualStyleBackColor = false;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // btnBLogin
            // 
            this.btnBLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBLogin.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnBLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBLogin.Location = new System.Drawing.Point(126, 263);
            this.btnBLogin.Name = "btnBLogin";
            this.btnBLogin.Size = new System.Drawing.Size(362, 66);
            this.btnBLogin.TabIndex = 12;
            this.btnBLogin.Text = "Back to Login";
            this.btnBLogin.UseVisualStyleBackColor = false;
            this.btnBLogin.Click += new System.EventHandler(this.btnBLogin_Click);
            // 
            // frmSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 341);
            this.Controls.Add(this.btnBLogin);
            this.Controls.Add(this.btnfillATM);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.lblMainMessage);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmSupervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSupervisor";
            this.Load += new System.EventHandler(this.frmSupervisor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnfillATM;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Button btnBLogin;
    }
}