namespace TSUI
{
    partial class frmAccBalances
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
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.grpRptMonth = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdToday = new System.Windows.Forms.RadioButton();
            this.rdDays120 = new System.Windows.Forms.RadioButton();
            this.rdDays90 = new System.Windows.Forms.RadioButton();
            this.rdDays60 = new System.Windows.Forms.RadioButton();
            this.rdDays30 = new System.Windows.Forms.RadioButton();
            this.cmbAcType = new System.Windows.Forms.ComboBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.lblAcBal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDispBal = new System.Windows.Forms.ListBox();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpRptMonth.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading2
            // 
            this.lblHeading2.AutoSize = true;
            this.lblHeading2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHeading2.Location = new System.Drawing.Point(515, 55);
            this.lblHeading2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(185, 29);
            this.lblHeading2.TabIndex = 10;
            this.lblHeading2.Text = "Account Balance";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 50);
            this.panel1.TabIndex = 9;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeading.Location = new System.Drawing.Point(471, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(284, 29);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "ATM Management System";
            // 
            // grpRptMonth
            // 
            this.grpRptMonth.Controls.Add(this.label2);
            this.grpRptMonth.Controls.Add(this.rdToday);
            this.grpRptMonth.Controls.Add(this.rdDays120);
            this.grpRptMonth.Controls.Add(this.rdDays90);
            this.grpRptMonth.Controls.Add(this.rdDays60);
            this.grpRptMonth.Controls.Add(this.rdDays30);
            this.grpRptMonth.Location = new System.Drawing.Point(718, 61);
            this.grpRptMonth.Name = "grpRptMonth";
            this.grpRptMonth.Size = new System.Drawing.Size(533, 62);
            this.grpRptMonth.TabIndex = 11;
            this.grpRptMonth.TabStop = false;
            this.grpRptMonth.Text = "Report for Last";
            this.grpRptMonth.Enter += new System.EventHandler(this.grpRptMonth_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(398, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "OR";
            // 
            // rdToday
            // 
            this.rdToday.AutoSize = true;
            this.rdToday.Location = new System.Drawing.Point(435, 28);
            this.rdToday.Name = "rdToday";
            this.rdToday.Size = new System.Drawing.Size(92, 27);
            this.rdToday.TabIndex = 5;
            this.rdToday.TabStop = true;
            this.rdToday.Text = "Today\'s";
            this.rdToday.UseVisualStyleBackColor = true;
            // 
            // rdDays120
            // 
            this.rdDays120.AutoSize = true;
            this.rdDays120.Location = new System.Drawing.Point(302, 28);
            this.rdDays120.Name = "rdDays120";
            this.rdDays120.Size = new System.Drawing.Size(101, 27);
            this.rdDays120.TabIndex = 4;
            this.rdDays120.TabStop = true;
            this.rdDays120.Text = "120 Days";
            this.rdDays120.UseVisualStyleBackColor = true;
            // 
            // rdDays90
            // 
            this.rdDays90.AutoSize = true;
            this.rdDays90.Location = new System.Drawing.Point(203, 28);
            this.rdDays90.Name = "rdDays90";
            this.rdDays90.Size = new System.Drawing.Size(93, 27);
            this.rdDays90.TabIndex = 3;
            this.rdDays90.TabStop = true;
            this.rdDays90.Text = "90 Days";
            this.rdDays90.UseVisualStyleBackColor = true;
            // 
            // rdDays60
            // 
            this.rdDays60.AutoSize = true;
            this.rdDays60.Location = new System.Drawing.Point(104, 28);
            this.rdDays60.Name = "rdDays60";
            this.rdDays60.Size = new System.Drawing.Size(93, 27);
            this.rdDays60.TabIndex = 2;
            this.rdDays60.TabStop = true;
            this.rdDays60.Text = "60 Days";
            this.rdDays60.UseVisualStyleBackColor = true;
            // 
            // rdDays30
            // 
            this.rdDays30.AutoSize = true;
            this.rdDays30.Location = new System.Drawing.Point(6, 28);
            this.rdDays30.Name = "rdDays30";
            this.rdDays30.Size = new System.Drawing.Size(92, 27);
            this.rdDays30.TabIndex = 1;
            this.rdDays30.TabStop = true;
            this.rdDays30.Text = "30 Days";
            this.rdDays30.UseVisualStyleBackColor = true;
            // 
            // cmbAcType
            // 
            this.cmbAcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcType.FormattingEnabled = true;
            this.cmbAcType.Items.AddRange(new object[] {
            "Chequing Account",
            "Saving Account"});
            this.cmbAcType.Location = new System.Drawing.Point(364, 92);
            this.cmbAcType.Name = "cmbAcType";
            this.cmbAcType.Size = new System.Drawing.Size(210, 31);
            this.cmbAcType.TabIndex = 0;
            this.cmbAcType.SelectedIndexChanged += new System.EventHandler(this.cmbAcType_SelectedIndexChanged);
            // 
            // txtAccNo
            // 
            this.txtAccNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAccNo.Enabled = false;
            this.txtAccNo.Location = new System.Drawing.Point(148, 92);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(210, 31);
            this.txtAccNo.TabIndex = 40;
            // 
            // lblAcBal
            // 
            this.lblAcBal.AutoSize = true;
            this.lblAcBal.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcBal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAcBal.Location = new System.Drawing.Point(580, 94);
            this.lblAcBal.Name = "lblAcBal";
            this.lblAcBal.Size = new System.Drawing.Size(132, 29);
            this.lblAcBal.TabIndex = 37;
            this.lblAcBal.Text = "AccBalance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Account No.";
            // 
            // lstDispBal
            // 
            this.lstDispBal.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDispBal.FormattingEnabled = true;
            this.lstDispBal.ItemHeight = 24;
            this.lstDispBal.Location = new System.Drawing.Point(17, 142);
            this.lstDispBal.Name = "lstDispBal";
            this.lstDispBal.Size = new System.Drawing.Size(1234, 412);
            this.lstDispBal.TabIndex = 41;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(1138, 590);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(118, 23);
            this.lblBack.TabIndex = 6;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "Back to Main";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDisplay.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDisplay.Location = new System.Drawing.Point(949, 581);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(183, 38);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "&Display Report";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // frmAccBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 631);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lstDispBal);
            this.Controls.Add(this.cmbAcType);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.lblAcBal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpRptMonth);
            this.Controls.Add(this.lblHeading2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmAccBalances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccBalances";
            this.Load += new System.EventHandler(this.frmAccBalances_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpRptMonth.ResumeLayout(false);
            this.grpRptMonth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpRptMonth;
        private System.Windows.Forms.RadioButton rdDays120;
        private System.Windows.Forms.RadioButton rdDays60;
        private System.Windows.Forms.RadioButton rdDays30;
        private System.Windows.Forms.ComboBox cmbAcType;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Label lblAcBal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDispBal;
        private System.Windows.Forms.LinkLabel lblBack;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.RadioButton rdDays90;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdToday;
    }
}