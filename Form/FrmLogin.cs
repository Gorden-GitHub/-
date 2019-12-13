using hotelmgt.BLL;
using hotelmgt.Model;
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

        #region 检验输入完整性
        /// <summary>
        /// 检验输入完整性
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("请输入用户名。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return false;
            }
            if (tbPassword.Text == "")
            {
                MessageBox.Show("请输入密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region 按钮事件
        // 登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput())
                {
                    string Username = tbUsername.Text;
                    string Password = tbPassword.Text;
                    User u = UserManager.SelectUserInfoByUsername(Username);
                    if (u != null)
                    {
                        u = UserManager.SelectUserInfoByUsernameAndPassword(Username, Password);
                        if (u != null)
                        {
                            new FrmMain().Show();   // 进入主界面
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("密码错误。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbPassword.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbUsername.Focus();
                    }
                }
            }
            catch
            { 
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
