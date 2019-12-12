using hotelmgt.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace hotelmgt
{
    public partial class FrmReserve : Form
    {
        public FrmReserve()
        {
            InitializeComponent();
        }

        private void FrmReserve_Load(object sender, EventArgs e)
        {
            // 初始化最早可选时间为今天
            dtpArriveTime.MinDate = DateTime.Today;
            dtpLeaveTime.MinDate = DateTime.Today;
        }

        #region 客户信息

        // 修改预达时间时，修改预离时间等于预达时间
        private void dtpArriveTime_ValueChanged(object sender, EventArgs e)
        {
            dtpLeaveTime.MinDate = dtpArriveTime.Value;
            dtpLeaveTime.Value = dtpLeaveTime.MinDate;
        }

        #endregion



        #region 按钮事件

        // 添加房间
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            FrmRoomAdd frmRoomAdd = new FrmRoomAdd();
            if (frmRoomAdd.ShowDialog() == DialogResult.OK)      // 打开选择房间对话框
            {
                List<Room> rooms = frmRoomAdd.Tag as List<Room>;    // 获取选择的房间信息
                foreach (Room room in rooms)     // 插入选择的房间
                {
                    lvSelectedRooms.Items.Add(new ListViewItem(new string[]
                    {
                        room.RoomNo,
                        room.RoomType,
                        room.BedNum.ToString()
                    }));
                }
            }
        }

        // 确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            int index = FrmMain.frmMain.dgvReserve.Rows.Add();
            FrmMain.frmMain.dgvReserve.Rows[index].Cells[0].Value = (index + 1).ToString();
            FrmMain.frmMain.dgvReserve.Rows[index].Cells[1].Value = tbName.Text;
            FrmMain.frmMain.dgvReserve.Rows[index].Cells[2].Value = tbPhone.Text;
            string roomNumbers = "";
            for (int i = 0; i < lvSelectedRooms.Items.Count; i++)
            {
                roomNumbers += lvSelectedRooms.Items[i].Text + (i < lvSelectedRooms.Items.Count - 1 ? ";" : "");
            }
            FrmMain.frmMain.dgvReserve.Rows[index].Cells[3].Value = roomNumbers;
            FrmMain.frmMain.dgvReserve.Rows[index].Cells[4].Value = dtpArriveTime.Value.ToString();
            FrmMain.frmMain.dgvReserve.Rows[index].Cells[5].Value = dtpLeaveTime.Value.ToString();
            FrmMain.frmMain.dgvReserve.Rows[index].Cells[6].Value = DateTime.Now.ToString();
            FrmMain.frmMain.dgvReserve.Rows[index].Cells[7].Value = "已预订，等待入住登记";
            MessageBox.Show("添加预订信息成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        // 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要取消添加新的预订信息？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }

        // 删除房间
        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            if (lvSelectedRooms.CheckedItems.Count == 0)
            {
                MessageBox.Show("请先勾选要删除的房间。", "提示");
            }
            else
            {
                string message = "";
                foreach (ListViewItem item in lvSelectedRooms.CheckedItems)
                {
                    message += item.SubItems[0].Text + " " + item.SubItems[1].Text + "\n";
                }
                if (MessageBox.Show("是否删除以下房间？\n\n" + message, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lvSelectedRooms.CheckedItems)
                    {
                        lvSelectedRooms.Items.Remove(item);
                    }
                }
            }
        }

        #endregion
    }
}