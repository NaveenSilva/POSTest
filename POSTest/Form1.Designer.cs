namespace POSTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UNameLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.BttnCancel = new System.Windows.Forms.Button();
            this.BttnLogIn = new System.Windows.Forms.Button();
            this.CBShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UNameLbl
            // 
            this.UNameLbl.AutoSize = true;
            this.UNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UNameLbl.Location = new System.Drawing.Point(23, 43);
            this.UNameLbl.Name = "UNameLbl";
            this.UNameLbl.Size = new System.Drawing.Size(113, 28);
            this.UNameLbl.TabIndex = 0;
            this.UNameLbl.Text = "User Name";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Silva"});
            this.comboBox1.Location = new System.Drawing.Point(216, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 36);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.CBShow_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTb.Location = new System.Drawing.Point(216, 99);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(197, 34);
            this.PasswordTb.TabIndex = 3;
            this.PasswordTb.UseSystemPasswordChar = true;
            // 
            // BttnCancel
            // 
            this.BttnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BttnCancel.Location = new System.Drawing.Point(75, 183);
            this.BttnCancel.Name = "BttnCancel";
            this.BttnCancel.Size = new System.Drawing.Size(94, 40);
            this.BttnCancel.TabIndex = 4;
            this.BttnCancel.Text = "Cancel";
            this.BttnCancel.UseVisualStyleBackColor = true;
            // 
            // BttnLogIn
            // 
            this.BttnLogIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BttnLogIn.Location = new System.Drawing.Point(260, 183);
            this.BttnLogIn.Name = "BttnLogIn";
            this.BttnLogIn.Size = new System.Drawing.Size(94, 40);
            this.BttnLogIn.TabIndex = 5;
            this.BttnLogIn.Text = "Log In";
            this.BttnLogIn.UseVisualStyleBackColor = true;
            this.BttnLogIn.Click += new System.EventHandler(this.BttnLogIn_Click);
            // 
            // CBShow
            // 
            this.CBShow.AutoSize = true;
            this.CBShow.Location = new System.Drawing.Point(216, 139);
            this.CBShow.Name = "CBShow";
            this.CBShow.Size = new System.Drawing.Size(67, 24);
            this.CBShow.TabIndex = 6;
            this.CBShow.Text = "Show";
            this.CBShow.UseVisualStyleBackColor = true;
            this.CBShow.CheckedChanged += new System.EventHandler(this.CBShow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 235);
            this.Controls.Add(this.CBShow);
            this.Controls.Add(this.BttnLogIn);
            this.Controls.Add(this.BttnCancel);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.UNameLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UNameLbl;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox PasswordTb;
        private Button BttnCancel;
        private Button BttnLogIn;
        private CheckBox CBShow;
    }
}