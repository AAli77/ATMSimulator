namespace TSUI
{
    partial class frmWithDrawal
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
            this.lbl10 = new System.Windows.Forms.Button();
            this.lbl20 = new System.Windows.Forms.Button();
            this.lbl40 = new System.Windows.Forms.Button();
            this.lbl60 = new System.Windows.Forms.Button();
            this.lbl80 = new System.Windows.Forms.Button();
            this.lbl100 = new System.Windows.Forms.Button();
            this.lbl200 = new System.Windows.Forms.Button();
            this.lbl400 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblOAmount = new System.Windows.Forms.Label();
            this.btnWithDraw = new System.Windows.Forms.Button();
            this.cmbAcType = new System.Windows.Forms.ComboBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.lblAcBal = new System.Windows.Forms.Label();
            this.lblAcType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtATMId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBillPayee
            // 
            this.lblBillPayee.AutoSize = true;
            this.lblBillPayee.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPayee.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBillPayee.Location = new System.Drawing.Point(234, 57);
            this.lblBillPayee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBillPayee.Name = "lblBillPayee";
            this.lblBillPayee.Size = new System.Drawing.Size(136, 29);
            this.lblBillPayee.TabIndex = 10;
            this.lblBillPayee.Text = "WithDrawal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 50);
            this.panel1.TabIndex = 9;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeading.Location = new System.Drawing.Point(173, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(284, 29);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "ATM Management System";
            // 
            // lbl10
            // 
            this.lbl10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl10.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl10.Location = new System.Drawing.Point(35, 222);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(164, 38);
            this.lbl10.TabIndex = 1;
            this.lbl10.Text = "10";
            this.lbl10.UseVisualStyleBackColor = false;
            this.lbl10.Click += new System.EventHandler(this.lbl10_Click);
            // 
            // lbl20
            // 
            this.lbl20.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl20.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl20.Location = new System.Drawing.Point(35, 277);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(164, 38);
            this.lbl20.TabIndex = 2;
            this.lbl20.Text = "20";
            this.lbl20.UseVisualStyleBackColor = false;
            this.lbl20.Click += new System.EventHandler(this.lbl20_Click);
            // 
            // lbl40
            // 
            this.lbl40.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl40.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl40.Location = new System.Drawing.Point(35, 336);
            this.lbl40.Name = "lbl40";
            this.lbl40.Size = new System.Drawing.Size(164, 38);
            this.lbl40.TabIndex = 3;
            this.lbl40.Text = "40";
            this.lbl40.UseVisualStyleBackColor = false;
            this.lbl40.Click += new System.EventHandler(this.lbl40_Click);
            // 
            // lbl60
            // 
            this.lbl60.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl60.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl60.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl60.Location = new System.Drawing.Point(35, 390);
            this.lbl60.Name = "lbl60";
            this.lbl60.Size = new System.Drawing.Size(164, 38);
            this.lbl60.TabIndex = 4;
            this.lbl60.Text = "60";
            this.lbl60.UseVisualStyleBackColor = false;
            this.lbl60.Click += new System.EventHandler(this.lbl60_Click);
            // 
            // lbl80
            // 
            this.lbl80.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl80.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl80.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl80.Location = new System.Drawing.Point(417, 222);
            this.lbl80.Name = "lbl80";
            this.lbl80.Size = new System.Drawing.Size(164, 38);
            this.lbl80.TabIndex = 5;
            this.lbl80.Text = "80";
            this.lbl80.UseVisualStyleBackColor = false;
            this.lbl80.Click += new System.EventHandler(this.lbl80_Click);
            // 
            // lbl100
            // 
            this.lbl100.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl100.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl100.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl100.Location = new System.Drawing.Point(417, 277);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(164, 38);
            this.lbl100.TabIndex = 6;
            this.lbl100.Text = "100";
            this.lbl100.UseVisualStyleBackColor = false;
            this.lbl100.Click += new System.EventHandler(this.lbl100_Click);
            // 
            // lbl200
            // 
            this.lbl200.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl200.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl200.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl200.Location = new System.Drawing.Point(417, 336);
            this.lbl200.Name = "lbl200";
            this.lbl200.Size = new System.Drawing.Size(164, 38);
            this.lbl200.TabIndex = 7;
            this.lbl200.Text = "200";
            this.lbl200.UseVisualStyleBackColor = false;
            this.lbl200.Click += new System.EventHandler(this.lbl200_Click);
            // 
            // lbl400
            // 
            this.lbl400.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl400.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl400.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl400.Location = new System.Drawing.Point(417, 390);
            this.lbl400.Name = "lbl400";
            this.lbl400.Size = new System.Drawing.Size(164, 38);
            this.lbl400.TabIndex = 8;
            this.lbl400.Text = "400";
            this.lbl400.UseVisualStyleBackColor = false;
            this.lbl400.Click += new System.EventHandler(this.lbl400_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(239, 319);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(144, 37);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblOAmount
            // 
            this.lblOAmount.AutoSize = true;
            this.lblOAmount.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblOAmount.Location = new System.Drawing.Point(231, 286);
            this.lblOAmount.Name = "lblOAmount";
            this.lblOAmount.Size = new System.Drawing.Size(161, 29);
            this.lblOAmount.TabIndex = 37;
            this.lblOAmount.Text = "Other Amount";
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnWithDraw.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithDraw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWithDraw.Location = new System.Drawing.Point(231, 362);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(164, 46);
            this.btnWithDraw.TabIndex = 10;
            this.btnWithDraw.Text = "WithDraw";
            this.btnWithDraw.UseVisualStyleBackColor = false;
            this.btnWithDraw.Click += new System.EventHandler(this.btnWithDraw_Click);
            // 
            // cmbAcType
            // 
            this.cmbAcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcType.FormattingEnabled = true;
            this.cmbAcType.Items.AddRange(new object[] {
            "Chequing Account",
            "Saving Account"});
            this.cmbAcType.Location = new System.Drawing.Point(231, 163);
            this.cmbAcType.Name = "cmbAcType";
            this.cmbAcType.Size = new System.Drawing.Size(175, 31);
            this.cmbAcType.TabIndex = 0;
            this.cmbAcType.SelectedIndexChanged += new System.EventHandler(this.cmdAcType_SelectedIndexChanged);
            // 
            // txtAccNo
            // 
            this.txtAccNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAccNo.Enabled = false;
            this.txtAccNo.Location = new System.Drawing.Point(231, 126);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(262, 31);
            this.txtAccNo.TabIndex = 43;
            // 
            // lblAcBal
            // 
            this.lblAcBal.AutoSize = true;
            this.lblAcBal.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcBal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAcBal.Location = new System.Drawing.Point(412, 165);
            this.lblAcBal.Name = "lblAcBal";
            this.lblAcBal.Size = new System.Drawing.Size(132, 29);
            this.lblAcBal.TabIndex = 40;
            this.lblAcBal.Text = "AccBalance";
            // 
            // lblAcType
            // 
            this.lblAcType.AutoSize = true;
            this.lblAcType.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAcType.Location = new System.Drawing.Point(52, 163);
            this.lblAcType.Name = "lblAcType";
            this.lblAcType.Size = new System.Drawing.Size(99, 29);
            this.lblAcType.TabIndex = 41;
            this.lblAcType.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(52, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Account No.";
            // 
            // txtATMId
            // 
            this.txtATMId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtATMId.Enabled = false;
            this.txtATMId.Location = new System.Drawing.Point(231, 89);
            this.txtATMId.Name = "txtATMId";
            this.txtATMId.Size = new System.Drawing.Size(67, 31);
            this.txtATMId.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(52, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "ATMId";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(494, 55);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(122, 23);
            this.lblBack.TabIndex = 34;
            this.lblBack.TabStop = true;
            this.lblBack.Text = " Back to Main";
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // frmWithDrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 440);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.cmbAcType);
            this.Controls.Add(this.txtATMId);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.lblAcBal);
            this.Controls.Add(this.lblAcType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWithDraw);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblOAmount);
            this.Controls.Add(this.lbl400);
            this.Controls.Add(this.lbl60);
            this.Controls.Add(this.lbl200);
            this.Controls.Add(this.lbl40);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl80);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lblBillPayee);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmWithDrawal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWithDrawal";
            this.Load += new System.EventHandler(this.frmWithDrawal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillPayee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button lbl10;
        private System.Windows.Forms.Button lbl20;
        private System.Windows.Forms.Button lbl40;
        private System.Windows.Forms.Button lbl60;
        private System.Windows.Forms.Button lbl80;
        private System.Windows.Forms.Button lbl100;
        private System.Windows.Forms.Button lbl200;
        private System.Windows.Forms.Button lbl400;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblOAmount;
        private System.Windows.Forms.Button btnWithDraw;
        private System.Windows.Forms.ComboBox cmbAcType;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Label lblAcBal;
        private System.Windows.Forms.Label lblAcType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtATMId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblBack;
    }
}