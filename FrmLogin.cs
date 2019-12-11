using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace hotelmgr
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("请输入用户名。", "提示");
                tbUsername.Focus();
            }
            else if (tbPassword.Text == "")
            {

                MessageBox.Show("请输入密码。", "提示");
                tbPassword.Focus();
            }
            else 
            {
                MySQLHelper mySQL = MySQLHelper.GetInstance();
                string strcmd = "select Username,Password from system_user_information";
                DataTable dataTable = mySQL.ExecuteDataTable(strcmd);
                DataRow[] dataRows = dataTable.Select("Username='" + tbUsername.Text + "' and Password='" + tbPassword.Text + "'");
                if (dataRows.Length > 0)
                {
                    new FrmMain(this).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误。", "提示");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)     // 在密码输入框按下回车键
            {
                btnLogin.PerformClick();    // 自动点击登录按钮
            }
        }
    }
}
