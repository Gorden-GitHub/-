using hotelmgt.BLL;
using hotelmgt.Model;
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
    public partial class FrmBFSell : Form
    {
        List<TicketInfo> tickets = TicketInfoManager.SelectTicketAll();
        public FrmBFSell()
        {
            InitializeComponent();
        }

        private void FrmSellBF_Load(object sender, EventArgs e)
        {
            string Type = "";
            foreach (TicketInfo t in tickets)
            {
                Type += t.Ticket_Type + " ";
            }
            string[] Types = Type.Split(' ');
            cbBFType.DataSource = Types;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbRoomNo.Text == "")
            {
                MessageBox.Show("请输入房间编号。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRoomNo.Focus();
                return;
            }
            if (MessageBox.Show(
                "房间编号：" + tbRoomNo.Text +
                "\n餐票类型："+cbBFType.SelectedItem.ToString()+
                "\n餐票数量：" + tbBFNum.Text +
                "\n应收餐费：" + lblBFPriceVal.Text +
                "\n\n请确认以上信息无误，完成交易后点击记账。", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("已登记早餐票交易记录。", "提示");
            }
        }

        private void tbBFNum_MouseLeave(object sender, EventArgs e)
        {
            if (tbBFNum.Text == "")
            {
                return;
            }
            string type = cbBFType.Text;
            string price = "";
            foreach (TicketInfo t in tickets)
            {
                if (t.Ticket_Type == type) ;
                {
                    price += t.Ticket_Price;
                    break;
                }
            }
            lblBFPriceVal.Text = (int.Parse(tbBFNum.Text) * int.Parse(price)).ToString();
        }
    }
}
