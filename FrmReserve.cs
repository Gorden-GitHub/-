using System;
using System.Windows.Forms;

namespace hotelmgr
{
    public partial class FrmReserve : Form
    {
        private FrmMain mFrmMain;
        public FrmReserve(FrmMain frmMain)
        {
            InitializeComponent();
            mFrmMain = frmMain;
        }

        private void FrmReserve_Load(object sender, EventArgs e)
        {
        }
        // 添加房间
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            FrmRoomAdd frmRoomAdd = new FrmRoomAdd();
            frmRoomAdd.ShowDialog();
        }
        // 确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            int index = mFrmMain.dgvReserve.Rows.Add();
            mFrmMain.dgvReserve.Rows[index].Cells[0].Value = (index + 1).ToString();
            mFrmMain.dgvReserve.Rows[index].Cells[1].Value = tbName.Text;
            mFrmMain.dgvReserve.Rows[index].Cells[2].Value = tbPhone.Text;
            string roomNumbers = "";
            for (int i = 0; i < lvSelectedRooms.Items.Count; i++)
            {
                roomNumbers += lvSelectedRooms.Items[i].Text + (i < lvSelectedRooms.Items.Count - 1 ? ";" : "");
            }
            mFrmMain.dgvReserve.Rows[index].Cells[3].Value = roomNumbers;
            mFrmMain.dgvReserve.Rows[index].Cells[4].Value = dtpArriveTime.Value.ToString();
            mFrmMain.dgvReserve.Rows[index].Cells[5].Value = dtpLeaveTime.Value.ToString();
            mFrmMain.dgvReserve.Rows[index].Cells[6].Value = DateTime.Now.ToString();
            mFrmMain.dgvReserve.Rows[index].Cells[7].Value = "已预订，等待入住登记";
            MessageBox.Show("添加预订信息成功。", "提示");
            Close();
        }
        // 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要取消添加新的预订信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }
        // 删除房间
        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            if(lvSelectedRooms.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选中要删除的房间。", "提示");
            }
            else
            {
                foreach(ListViewItem item in lvSelectedRooms.SelectedItems)
                {
                    lvSelectedRooms.Items.Remove(item);
                }
            }
        }
    }
}