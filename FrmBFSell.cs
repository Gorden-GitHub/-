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
    public partial class FrmBFSell : Form
    {
        public FrmBFSell()
        {
            InitializeComponent();
        }

        private void FrmSellBF_Load(object sender, EventArgs e)
        {
            cbBFType.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "房间编号：" + tbRoomNo.Text +
                "\n餐票类型："+cbBFType.SelectedItem.ToString()+
                "\n餐票数量：" + tbBFNum.Text +
                "\n应收餐费：" + (int.Parse(tbBFNum.Text) * int.Parse(lblBFPriceVal.Text)).ToString() +
                "\n\n请确认以上信息无误，完成交易后点击记账。", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("已登记早餐票交易记录。", "提示");
            }
        }
    }
}
