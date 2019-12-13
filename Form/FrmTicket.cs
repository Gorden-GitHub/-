using hotelmgt.BLL;
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
    public partial class FrmBF : Form
    {
        public FrmBF()
        {
            InitializeComponent();
        }

        private void FrmBF_Load(object sender, EventArgs e)
        {
            dgvBFInfo.AutoGenerateColumns = false;
            dgvBFInfo.DataSource = TicketInfoManager.SelectTicketAll();
            DataGridViewColumn Type_Column = new DataGridViewTextBoxColumn();
            Type_Column.HeaderText = "餐票类型";
            Type_Column.DataPropertyName = "Ticket_Type";
            dgvBFInfo.Columns.Add(Type_Column);
            DataGridViewColumn Price_Column = new DataGridViewTextBoxColumn();
            Price_Column.HeaderText = "餐票价格";
            Price_Column.DataPropertyName = "Ticket_Price";
            dgvBFInfo.Columns.Add(Price_Column);
        }

        private bool CheckInput()
        {
            if (tbTicketType.Text == "")
            {
                MessageBox.Show("请输入餐票类型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTicketType.Focus();
                return false;
            }
            if (tbTicketPrice.Text == "")
            {
                MessageBox.Show("请输入餐票价格。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTicketPrice.Focus();
                return false;
            }
            return true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                bool flag = TicketInfoManager.AddTicket(tbTicketType.Text, tbTicketPrice.Text);
                tbTicketType.Text = "";
                tbTicketPrice.Text = "";
                MessageBox.Show("添加成功");
                dgvBFInfo.DataSource = TicketInfoManager.SelectTicketAll();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int index = -1;
            index = dgvBFInfo.CurrentRow.Index;
            string name = dgvBFInfo.Rows[index].Cells[0].Value.ToString();
            bool flag = TicketInfoManager.DeleteMemberByName(name);
            if (flag == true)
            {
                dgvBFInfo.DataSource = TicketInfoManager.SelectTicketAll();
            }
            else
            {
                MessageBox.Show("删除失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
