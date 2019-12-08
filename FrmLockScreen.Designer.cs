namespace hotelmgr
{
    partial class FrmLockScreen
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.llbSwitchUser = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUsername.Location = new System.Drawing.Point(332, 150);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(152, 50);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "admin";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPassword.Location = new System.Drawing.Point(271, 220);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(10);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(150, 30);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTip.Location = new System.Drawing.Point(294, 270);
            this.lblTip.Margin = new System.Windows.Forms.Padding(10);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(237, 19);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "系统已锁定，请输入密码。";
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(441, 220);
            this.btnUnlock.Margin = new System.Windows.Forms.Padding(10);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(90, 35);
            this.btnUnlock.TabIndex = 3;
            this.btnUnlock.Text = "解锁";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // llbSwitchUser
            // 
            this.llbSwitchUser.ActiveLinkColor = System.Drawing.Color.Black;
            this.llbSwitchUser.AutoSize = true;
            this.llbSwitchUser.LinkColor = System.Drawing.Color.Gray;
            this.llbSwitchUser.Location = new System.Drawing.Point(714, 416);
            this.llbSwitchUser.Margin = new System.Windows.Forms.Padding(10);
            this.llbSwitchUser.Name = "llbSwitchUser";
            this.llbSwitchUser.Size = new System.Drawing.Size(67, 15);
            this.llbSwitchUser.TabIndex = 4;
            this.llbSwitchUser.TabStop = true;
            this.llbSwitchUser.Text = "切换用户";
            this.llbSwitchUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSwitchUser_LinkClicked);
            // 
            // FrmLockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llbSwitchUser);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLockScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLockScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLockScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.LinkLabel llbSwitchUser;
    }
}