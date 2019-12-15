using hotelmgt.BLL;
using hotelmgt.DAL;
using hotelmgt.Model;
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
    public partial class FrmMember : Form
    {
        public FrmMember()
        {
            InitializeComponent();
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            // 初始化窗体位置及大小
            this.Top = 0;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            dgvMemberInfo.AutoGenerateColumns = false;
            dgvMemberInfo.DataSource = MemberManager.SelectMemberAll();
            DataGridViewColumn Name_Column = new DataGridViewTextBoxColumn();
            Name_Column.HeaderText = "会员姓名";
            Name_Column.DataPropertyName = "Member_Name";
            dgvMemberInfo.Columns.Add(Name_Column);
            DataGridViewColumn Phone_Column = new DataGridViewTextBoxColumn();
            Phone_Column.HeaderText = "手机号码";
            Phone_Column.DataPropertyName = "Member_Phone";
            dgvMemberInfo.Columns.Add(Phone_Column);
            DataGridViewColumn Time_Column = new DataGridViewTextBoxColumn();
            Time_Column.HeaderText = "登记时间";
            Time_Column.DataPropertyName = "Member_RTime";
            dgvMemberInfo.Columns.Add(Time_Column);
        }
        private bool CheckInput()
        {
            if (tbMemberName.Text == "")
            {
                MessageBox.Show("请输入会员姓名。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMemberName.Focus();
                return false;
            }
            if (tbMemberPhone.Text == "")
            {
                MessageBox.Show("请输入手机号码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMemberPhone.Focus();
                return false;
            }
            return true;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                bool flag = MemberManager.AddMember(tbMemberName.Text, tbMemberPhone.Text);
                if (flag == true)
                {
                    tbMemberName.Text = "";
                    tbMemberPhone.Text = "";
                    MessageBox.Show("添加成功");
                    dgvMemberInfo.DataSource = MemberManager.SelectMemberAll();
                }
            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            if (tbMemberName.Text == "" && tbMemberPhone.Text == "")
            {
                MessageBox.Show("请输入会员姓名或手机号码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbMemberName.Text != "")
            {
                Member m = MemberManager.SelectMemberByName(tbMemberName.Text);
                if (m != null)
                {
                    List<Member> members = new List<Member>();
                    members.Add(m);
                    dgvMemberInfo.DataSource = members;
                }
                else
                {
                    MessageBox.Show("用户不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbMemberName.Text = "";
                }
            }
            else if (tbMemberPhone.Text != "")
            {
                Member m = MemberManager.SelectMemberByPhone(tbMemberPhone.Text);
                if (m != null)
                {
                    List<Member> members = new List<Member>();
                    members.Add(m);
                    dgvMemberInfo.DataSource = members;
                }
                else
                {
                    MessageBox.Show("用户不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbMemberPhone.Text = "";
                }
            }
        }

        private void dgvMemberInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbMemberName.Text = "";
            tbMemberPhone.Text = "";
            dgvMemberInfo.DataSource = MemberManager.SelectMemberAll();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int index = -1;
            index = dgvMemberInfo.CurrentRow.Index;
            string name = dgvMemberInfo.Rows[index].Cells[0].Value.ToString();
            bool flag = MemberManager.DeleteMemberByName(name);
            if (flag == true)
            {
                dgvMemberInfo.DataSource = MemberManager.SelectMemberAll();
            }
            else
            {
                MessageBox.Show("删除失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
