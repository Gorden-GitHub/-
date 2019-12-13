using hotelmgt.DAL;
using MySql.Data.MySqlClient;
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
    public partial class FrmMemberAdd : Form
    {
        public FrmMemberAdd()
        {
            InitializeComponent();
        }

        #region 检验输入完整性
        /// <summary>
        /// 检验输入完整性
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (tbCustoName.Text == "")
            {
                MessageBox.Show("请输入客户姓名。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCustoName.Focus();
                return false;
            }
            if (tbCustoPhone.Text == "")
            {
                MessageBox.Show("请输入手机号码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCustoPhone.Focus();
                return false;
            }
            return true;
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                string sql = "INSERT INTO member_information";
                sql += " values('" + tbCustoPhone.Text + "','" + tbCustoName.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "') ";
                MySqlConnection con = DBHelper.GetConnection();
                con.Open();
                int i = DBHelper.ExecuteNonQuery(sql);
                tbCustoName.Text = "";
                tbCustoPhone.Text = "";
                MessageBox.Show("登记成功。", "提示");
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
