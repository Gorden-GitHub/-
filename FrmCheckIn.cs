using System.Windows.Forms;

namespace hotelmgr
{
    public partial class FrmCheckIn : Form
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        private void FrmCheckIn_Load(object sender, System.EventArgs e)
        {
            // 添加客户信息
            dgvCustInfo.Rows.Add("1", "Customer1", "12345678901", "身份证", "123456789012345678", "Address1", "登记会员", "0201");

            // 添加房间信息
            dgvRoomInfo.Rows.Add("0201", false, "", "2019-01-01 14:00", "2019-01-02 12:00", true, "2019-01-02 07:00", "140", "");
        }

        private void dgvCheckIn_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvCustInfo.Rows[dgvCustInfo.Rows.Count - 2].Cells[0].Value = (dgvCustInfo.Rows.Count - 1).ToString();
        }

        private void dgvCheckIn_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = e.RowIndex; i < dgvCustInfo.Rows.Count - 1; i++)
            {
                dgvCustInfo.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("确定要取消登记新的入住信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }

        private void dgvCustInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                FrmMemberAdd frmMember = new FrmMemberAdd();
                frmMember.ShowDialog();
            }
        }
    }
}
