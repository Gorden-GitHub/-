using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelmgr
{
    public partial class FrmMemberAdd : Form
    {
        public FrmMemberAdd()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbCustoName.Text == "")
            {
                MessageBox.Show("请输入姓名。", "提示");
                tbCustoName.Focus();
            }
            else if (tbCustoPhone.Text == "")
            {
                MessageBox.Show("请输入手机号码。", "提示");
                tbCustoPhone.Focus();
            }
            MySQLHelper mySQL = MySQLHelper.GetInstance();
            string strcmd = string.Format("INSERT INTO member_information VALUES ('{0}', '{1}')", tbCustoPhone.Text, tbCustoName.Text);
            mySQL.ExecuteNonQuery(strcmd);
            MessageBox.Show("登记成功。", "提示");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
