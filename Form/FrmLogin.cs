using System;
using System.Windows.Forms;

namespace hotelmgt
{
    public partial class FrmLogin : Form
    {
        public static FrmLogin frmLogin;        // 当前窗体实例

        #region 窗体事件
        public FrmLogin()
        {
            InitializeComponent();
            frmLogin = this;        // 保存当前窗体实例
        }
        // 用户名文本框按下回车键，自动点击登录按钮
        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    // 按下回车键
            {
                btnLogin.PerformClick();    // 点击登录按钮
            }
        }
        // 密码文本框按下回车键，自动点击登录按钮
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    // 按下回车键
            {
                btnLogin.PerformClick();    // 点击登录按钮
            }
        }
        #endregion

        #region 按钮事件
        // 登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("请输入用户名。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("请输入密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
            }
            else if (tbUsername.Text == "admin" && tbPassword.Text == "admin")
            {
                new FrmMain().Show();   // 进入主界面
                this.Hide();    // 隐藏登录界面，以便切换用户
            }
            else
            {
                MessageBox.Show("用户名或密码错误。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Focus();
            }
        }
        // 退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }
        #endregion
    }
}
