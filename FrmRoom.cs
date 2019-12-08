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
    public partial class FrmRoom : Form
    {
        public FrmRoom()
        {
            InitializeComponent();
        }

        private void FrmRoom_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            FrmRoom_Resize(sender, e);
            // 插入房间类型项
            dgvRoomType.Rows.Add("1", "大床房", "140", true, "2", "40");
            dgvRoomType.Rows.Add("2", "双床房", "180", true, "3", "60");
            dgvRoomType.Rows.Add("3", "三床房", "220", true, "3", "80");
            dgvRoomType.Rows.Add("4", "套房", "260", true, "3", "100");
            // 插入房间状态项
            dgvRoomState.Rows.Add("空房");
            dgvRoomState.Rows.Add("已预订");
            dgvRoomState.Rows.Add("已入住");
            dgvRoomState.Rows.Add("等待维修");
            dgvRoomState.Rows.Add("等待清洁");
            dgvRoomState.Rows.Add("保留");
            // 选择默认过滤选项
            cbRoomType.SelectedIndex = 0;
            cbBuildingNo.SelectedIndex = 0;
            cbFloorNo.SelectedIndex = 0;
            cbRoomState.SelectedIndex = 0;
            // 插入房间信息项
            dgvRoomInfo.Rows.Add("0201", "大床房", "1", "2", "2", "A", "空房", "");
        }

        private void FrmRoom_Resize(object sender, EventArgs e)
        {
            // 自动调整控件的位置和大小
            gbStdTime.Width = gbHourTime.Width = (this.Width - this.Padding.Left - this.Padding.Right - gbStdTime.Margin.Left - gbStdTime.Margin.Right - 28) / 2;
            gbHourTime.Left = gbStdTime.Left + gbStdTime.Width - 1;
            gbRoomType.Width = this.Width - gbRoomType.Left - gbRoomState.Width - 28;
            gbRoomState.Left = this.Width - gbRoomState.Width - 24;
            gbRoomInfo.Width = this.Width - gbRoomInfo.Left - gbRoomInfo.Margin.Right - this.Padding.Left - 23;
            gbRoomInfo.Height = this.Height - gbRoomInfo.Top - gbRoomInfo.Margin.Bottom - this.Padding.Bottom - 43;
            dgvRoomInfo.Width = gbRoomInfo.Width - 1;
            dgvRoomInfo.Height = gbRoomInfo.Height - gbRoomInfo.Padding.Bottom - dgvRoomInfo.Top - dgvRoomInfo.Margin.Bottom;
            btnSearchRoom.Left = gbRoomInfo.Width - btnSearchRoom.Width - btnSearchRoom.Margin.Right - gbRoomInfo.Padding.Left;
            tbRoomNo.Left = btnSearchRoom.Left - tbRoomNo.Width - tbRoomNo.Margin.Right - btnSearchRoom.Padding.Left;
            lblRoomNo.Left = tbRoomNo.Left - lblRoomNo.Width - lblRoomNo.Margin.Right - tbRoomNo.Padding.Left;
        }

        private void dgvRoomType_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // 设置序号
            dgvRoomType.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            // 设置上下文菜单
            foreach (DataGridViewCell cell in dgvRoomType.Rows[e.RowIndex].Cells)
            {
                cell.ContextMenuStrip = cmsRoomType;
            }
        }

        private void dgvRoomState_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach(DataGridViewCell cell in dgvRoomState.Rows[e.RowIndex].Cells)
            {
                cell.ContextMenuStrip = cmsRoomState;
            }
        }

        private void dgvRoomInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // 设置序号
            dgvRoomInfo.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            // 设置上下文菜单
            foreach (DataGridViewCell cell in dgvRoomInfo.Rows[e.RowIndex].Cells)
            {
                cell.ContextMenuStrip = cmsRoomInfo;
            }
        }
        // 添加新类型
        private void tsmiRoomTypeAdd_Click(object sender, EventArgs e)
        {
            dgvRoomType.Rows.Add();
        }
        // 添加新类型
        private void tsmiRoomTypeAppend_Click(object sender, EventArgs e)
        {
            dgvRoomType.Rows.Add();
        }
        // 添加新状态
        private void tsmiRoomStateAdd_Click(object sender, EventArgs e)
        {
            dgvRoomState.Rows.Add();
        }
        // 添加新状态
        private void tsmiRoomStateAppend_Click(object sender, EventArgs e)
        {
            dgvRoomState.Rows.Add();
        }
        // 添加新房间
        private void tsmiRoomInfoAdd_Click(object sender, EventArgs e)
        {
            dgvRoomInfo.Rows.Add();
        }
        // 添加新房间
        private void tsmiRoomInfoAppend_Click(object sender, EventArgs e)
        {
            dgvRoomInfo.Rows.Add();
        }
    }
}
