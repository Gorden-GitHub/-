using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelmgt
{
    public partial class FrmLockScreen : Form
    {
        public FrmLockScreen()
        {
            InitializeComponent();
        }

        private void FrmLockScreen_Load(object sender, EventArgs e)
        {
            // 初始化控件的位置
            lblUsername.Left = (this.Width - lblUsername.Margin.Left - lblUsername.Width - lblUsername.Margin.Right) / 2;
            lblUsername.Top = (this.Height
                - lblUsername.Margin.Top - lblUsername.Height - lblUsername.Margin.Bottom
                - tbPassword.Margin.Top - tbPassword.Height - tbPassword.Margin.Bottom
                - lblTip.Margin.Top - lblTip.Height - lblTip.Margin.Bottom) / 2;
            tbPassword.Left = (this.Width
                - tbPassword.Margin.Left - tbPassword.Width - tbPassword.Margin.Right
                - btnUnlock.Margin.Left - btnUnlock.Width - btnUnlock.Margin.Right) / 2;
            tbPassword.Top = lblUsername.Top + lblUsername.Height + lblUsername.Margin.Bottom + tbPassword.Margin.Top;
            btnUnlock.Left = tbPassword.Left + tbPassword.Width + tbPassword.Margin.Right + btnUnlock.Margin.Left;
            btnUnlock.Top = lblUsername.Top + lblUsername.Height + lblUsername.Margin.Bottom + btnUnlock.Margin.Top;
            lblTip.Left = (this.Width - lblTip.Width) / 2;
            lblTip.Top = tbPassword.Top + tbPassword.Height + tbPassword.Margin.Bottom + lblTip.Margin.Top;
            llbSwitchUser.Left = this.Width - llbSwitchUser.Width - llbSwitchUser.Margin.Right;
            llbSwitchUser.Top = this.Height - lblUsername.Height - llbSwitchUser.Margin.Bottom;
        }

        // 解锁
        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "admin")
            {
                // 密码正确，解锁成功，返回主界面
                FrmMain.frmMain.Show();
                this.Close();
            }
            else
            {
                // 密码错误，解锁失败
                lblTip.Text = "密码错误，请重新输入。";
                lblTip.Left = (this.Width - lblTip.Width) / 2;
                tbPassword.Focus();
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lblTip.Text = "";
            lblTip.Left = (this.Width - lblTip.Width) / 2;

        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUnlock.PerformClick();
            }
        }

        // 切换用户
        private void llbSwitchUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("确定要切换用户吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FrmLogin.frmLogin.tbUsername.Text = "";
                FrmLogin.frmLogin.tbPassword.Text = "";
                FrmLogin.frmLogin.Show();
                FrmLogin.frmLogin.tbUsername.Focus();
                this.Close();
            }
            else
            {
                tbPassword.Focus();
            }
        }
    }
}
