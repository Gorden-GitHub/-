namespace hotelmgt
{
    partial class FrmMemberAdd
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
            this.tbCustoPhone = new System.Windows.Forms.TextBox();
            this.lblCustoPhone = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbCustoName = new System.Windows.Forms.TextBox();
            this.lblCustoName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCustoPhone
            // 
            this.tbCustoPhone.Location = new System.Drawing.Point(135, 70);
            this.tbCustoPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.tbCustoPhone.Name = "tbCustoPhone";
            this.tbCustoPhone.Size = new System.Drawing.Size(150, 25);
            this.tbCustoPhone.TabIndex = 0;
            // 
            // lblCustoPhone
            // 
            this.lblCustoPhone.Location = new System.Drawing.Point(45, 70);
            this.lblCustoPhone.Margin = new System.Windows.Forms.Padding(5, 5, 0, 10);
            this.lblCustoPhone.Name = "lblCustoPhone";
            this.lblCustoPhone.Size = new System.Drawing.Size(85, 25);
            this.lblCustoPhone.TabIndex = 0;
            this.lblCustoPhone.Text = "手机号码：";
            this.lblCustoPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(171, 120);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(56, 120);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 35);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "登记";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbCustoName
            // 
            this.tbCustoName.Location = new System.Drawing.Point(135, 30);
            this.tbCustoName.Margin = new System.Windows.Forms.Padding(5);
            this.tbCustoName.Name = "tbCustoName";
            this.tbCustoName.Size = new System.Drawing.Size(150, 25);
            this.tbCustoName.TabIndex = 0;
            // 
            // lblCustoName
            // 
            this.lblCustoName.Location = new System.Drawing.Point(45, 30);
            this.lblCustoName.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblCustoName.Name = "lblCustoName";
            this.lblCustoName.Size = new System.Drawing.Size(85, 25);
            this.lblCustoName.TabIndex = 0;
            this.lblCustoName.Text = "客户姓名：";
            this.lblCustoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMemberAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(332, 178);
            this.Controls.Add(this.tbCustoName);
            this.Controls.Add(this.lblCustoName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbCustoPhone);
            this.Controls.Add(this.lblCustoPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMemberAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登记会员";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCustoPhone;
        private System.Windows.Forms.Label lblCustoPhone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbCustoName;
        private System.Windows.Forms.Label lblCustoName;
    }
}