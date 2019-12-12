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
            cbFloorNo.SelectedIndex = 0;
            cbRoomState.SelectedIndex = 0;
            // 插入房间信息项
            dgvRoomInfo.Rows.Add("0201", "大床房", "2", "2", "A", "空房", "");
        }

        private void dgvRoomInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // 设置序号
            dgvRoomInfo.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            // 设置上下文菜单
            foreach (DataGridViewCell cell in dgvRoomInfo.Rows[e.RowIndex].Cells)
            {
                cell.ContextMenuStrip = cmsRoomInfoRow;
            }
        }
        // 添加新类型
        private void tsmiRoomTypeAdd_Click(object sender, EventArgs e)
        {
            int index = dgvRoomType.Rows.Add();                     // 插入新行
            dgvRoomType.Rows[index].Cells[0].Value = index + 1;     // 自动编号
            dgvRoomType.CurrentCell = dgvRoomType[1, index];
            dgvRoomType.BeginEdit(false);                           // 进入编辑状态
        }

        // 添加新类型
        private void tsmiRoomTypeCellAdd_Click(object sender, EventArgs e)
        {
            tsmiRoomTypeAdd.PerformClick();     // 调用表格的事件
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

        private void FrmRoom_Resize(object sender, EventArgs e)
        {
            btnSearchRoom.Left = panel2.Width - btnSearchRoom.Width - btnSearchRoom.Margin.Right;
            tbRoomNo.Left = btnSearchRoom.Left - tbRoomNo.Width - tbRoomNo.Margin.Right;
            lblRoomNo.Left = tbRoomNo.Left - lblRoomNo.Width - lblRoomNo.Margin.Right;
        }

        private void dgvRoomState_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvRoomState.CurrentCell = dgvRoomState[0, e.RowIndex];
            dgvRoomState.BeginEdit(false);
        }


        // 修改此项
        private void tsmiRoomTypeCellModify_Click(object sender, EventArgs e)
        {
            dgvRoomType.BeginEdit(false);       // 进入编辑状态
        }

        // 鼠标右键单击单元格，选中该单元格
        private void dgvRoomType_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvRoomType.CurrentCell = dgvRoomType[e.ColumnIndex, e.RowIndex];   // 设置为当前单元格
            dgvRoomType.CurrentCell.Selected = true;    // 选中该单元格
        }

        private void tsmiRoomTypeCellRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("是否删除此房间类型？\n\n{0}.{1}", new string[]{
                dgvRoomType.CurrentRow.Cells[0].Value.ToString(),
                dgvRoomType.CurrentRow.Cells[1].Value.ToString()}),
                "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvRoomType.Rows.Remove(dgvRoomType.CurrentRow);
            }
        }

        private void dgvRoomType_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvRoomType.Rows[e.RowIndex].ContextMenuStrip = cmsRoomTypeCell;
        }
    }
}
