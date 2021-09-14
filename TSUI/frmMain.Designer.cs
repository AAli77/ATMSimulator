namespace TSUI
{
    partial class frmMain
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
            this.pMain = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnAccBal = new System.Windows.Forms.Button();
            this.btnWD = new System.Windows.Forms.Button();
            this.btnDep = new System.Windows.Forms.Button();
            this.btnChPIN = new System.Windows.Forms.Button();
            this.btnTF = new System.Windows.Forms.Button();
            this.btnBP = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblATMID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pMain.Controls.Add(this.lblHeading);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(651, 64);
            this.pMain.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeading.Location = new System.Drawing.Point(191, 19);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(284, 29);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "ATM Management System";
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMainMenu.Location = new System.Drawing.Point(255, 117);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(146, 29);
            this.lblMainMenu.TabIndex = 2;
            this.lblMainMenu.Text = "MAIN MENU";
            this.lblMainMenu.Click += new System.EventHandler(this.lblMainMenu_Click);
            // 
            // btnAccBal
            // 
            this.btnAccBal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAccBal.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAccBal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAccBal.Location = new System.Drawing.Point(40, 173);
            this.btnAccBal.Name = "btnAccBal";
            this.btnAccBal.Size = new System.Drawing.Size(210, 66);
            this.btnAccBal.TabIndex = 7;
            this.btnAccBal.Text = "Account Balance";
            this.btnAccBal.UseVisualStyleBackColor = false;
            this.btnAccBal.Click += new System.EventHandler(this.btnAccBal_Click);
            // 
            // btnWD
            // 
            this.btnWD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnWD.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnWD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWD.Location = new System.Drawing.Point(399, 173);
            this.btnWD.Name = "btnWD";
            this.btnWD.Size = new System.Drawing.Size(210, 66);
            this.btnWD.TabIndex = 7;
            this.btnWD.Text = "WITHDRAWAL";
            this.btnWD.UseVisualStyleBackColor = false;
            this.btnWD.Click += new System.EventHandler(this.btnWD_Click);
            // 
            // btnDep
            // 
            this.btnDep.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDep.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDep.Location = new System.Drawing.Point(399, 256);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(210, 66);
            this.btnDep.TabIndex = 8;
            this.btnDep.Text = "DEPOSIT";
            this.btnDep.UseVisualStyleBackColor = false;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // btnChPIN
            // 
            this.btnChPIN.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnChPIN.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnChPIN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChPIN.Location = new System.Drawing.Point(40, 256);
            this.btnChPIN.Name = "btnChPIN";
            this.btnChPIN.Size = new System.Drawing.Size(210, 66);
            this.btnChPIN.TabIndex = 9;
            this.btnChPIN.Text = "Change PIN";
            this.btnChPIN.UseVisualStyleBackColor = false;
            this.btnChPIN.Click += new System.EventHandler(this.btnChPIN_Click);
            // 
            // btnTF
            // 
            this.btnTF.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTF.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTF.Location = new System.Drawing.Point(399, 341);
            this.btnTF.Name = "btnTF";
            this.btnTF.Size = new System.Drawing.Size(210, 66);
            this.btnTF.TabIndex = 10;
            this.btnTF.Text = "TRANSFER";
            this.btnTF.UseVisualStyleBackColor = false;
            this.btnTF.Click += new System.EventHandler(this.btnTF_Click);
            // 
            // btnBP
            // 
            this.btnBP.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBP.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnBP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBP.Location = new System.Drawing.Point(40, 341);
            this.btnBP.Name = "btnBP";
            this.btnBP.Size = new System.Drawing.Size(210, 66);
            this.btnBP.TabIndex = 11;
            this.btnBP.Text = "Bill Payee";
            this.btnBP.UseVisualStyleBackColor = false;
            this.btnBP.Click += new System.EventHandler(this.btnBP_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogout.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(40, 423);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(569, 66);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Back to Login";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 76);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(329, 23);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "Welcome Account # 10011111 - Amir Ali";
            // 
            // lblATMID
            // 
            this.lblATMID.AutoSize = true;
            this.lblATMID.Location = new System.Drawing.Point(620, 103);
            this.lblATMID.Name = "lblATMID";
            this.lblATMID.Size = new System.Drawing.Size(19, 23);
            this.lblATMID.TabIndex = 13;
            this.lblATMID.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "ATM:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(541, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 23);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "ATM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 493);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblATMID);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTF);
            this.Controls.Add(this.btnBP);
            this.Controls.Add(this.btnDep);
            this.Controls.Add(this.btnChPIN);
            this.Controls.Add(this.btnWD);
            this.Controls.Add(this.btnAccBal);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.pMain);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnAccBal;
        private System.Windows.Forms.Button btnWD;
        private System.Windows.Forms.Button btnDep;
        private System.Windows.Forms.Button btnChPIN;
        private System.Windows.Forms.Button btnTF;
        private System.Windows.Forms.Button btnBP;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblATMID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
    }
}