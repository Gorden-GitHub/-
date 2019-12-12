using hotelmgt.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace hotelmgt
{
    public partial class FrmCheckIn : Form
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        #region 窗体事件

        private void FrmCheckIn_Load(object sender, System.EventArgs e)
        {
            // 添加客户信息
            dgvCust.Rows.Add("1", "Customer1", "12345678901", "身份证", "123456789012345678", "Address1", "登记会员", "0201");

            // 添加房间信息
            dgvRoom.Rows.Add("0201", "大床房","1", false, "", "2019-01-01 14:00", "2019-01-02 12:00", true, "2019-01-02 07:00", "140", "");
        }

        #endregion



        #region 客户信息列表事件

        // 添加行，自动编号、为单元格绑定右键菜单
        private void dgvCust_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvCust.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();  // 自动编号
            dgvCust.Rows[e.RowIndex].ContextMenuStrip = cmsCustCell;
        }

        // 删除行，修改下方客户信息的编号
        private void dgvCust_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = e.RowIndex; i < dgvCust.Rows.Count - 1; i++)
            {
                dgvCust.Rows[i].Cells[0].Value = (i + 1).ToString();    // 修改被删除行往后的行编号
            }
        }

        #endregion

        #region 客户信息列表右键菜单事件

        // 添加新客户
        private void tsmiCustAdd_Click(object sender, System.EventArgs e)
        {
            dgvCust.Rows.Add();     // 插入新行
        }

        #endregion

        #region 客户信息列表单元格事件
        // 右键单击单元格时自动选中该单元格
        private void dgvCust_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)    // 需判断行索引，因为列标题的行索引为-1
            {
                dgvCust.CurrentCell = dgvCust[e.ColumnIndex, e.RowIndex];
                dgvCust.CurrentCell.Selected = true;
            }
        }
        // 点击登记会员时弹出对话框
        private void dgvCust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)     // 登记会员
            {
                FrmMemberAdd frmMember = new FrmMemberAdd();
                frmMember.ShowDialog();
            }
        }
        #endregion

        #region 客户信息列表单元格右键菜单事件
        // 修改此项
        private void tsmiCustCellModify_Click(object sender, System.EventArgs e)
        {
            dgvCust.BeginEdit(false);   // 进入编辑状态
        }
        // 添加新客户
        private void tsmiCustRowAdd_Click(object sender, System.EventArgs e)
        {
            dgvCust.Rows.Add();     // 插入新行
        }
        // 删除此客户
        private void tsmiCustRowRemove_Click(object sender, System.EventArgs e)
        {
            int ri = dgvCust.CurrentCell.RowIndex;
            if (MessageBox.Show(
                string.Format("删除此客户的信息：{0}.{1}？",
                dgvCust.Rows[ri].Cells[0].Value,
                dgvCust.Rows[ri].Cells[1].Value),
                "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvCust.Rows.Remove(dgvCust.Rows[ri]);      // 删除行
            }
        }
        #endregion



        #region 房间信息列表事件
        // 添加行，为单元格绑定右键菜单
        private void dgvRoom_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvRoom.Rows[e.RowIndex].ContextMenuStrip = cmsRoomCell;
        }
        // 右键单击单元格，选中该单元格
        private void dgvRoom_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)    // 需判断行索引，因为列标题的行索引为-1
            {
                dgvRoom.CurrentCell = dgvRoom[e.ColumnIndex, e.RowIndex];
                dgvRoom.CurrentCell.Selected = true;
                switch (e.ColumnIndex)
                {
                    case 4:     // 入住时间
                    case 5:     // 预离时间
                    case 6:     // 叫早
                    case 7:     // 叫早时间
                    case 11:    // 备注
                        cmsRoomCell.Items[0].Enabled = true;    // 允许使用修改此项菜单
                        break;
                    default:
                        cmsRoomCell.Items[0].Enabled = false;   // 禁止使用修改此项菜单
                        break;
                }
            }
        }
        #endregion

        #region 房间信息列表右键菜单事件
        // 添加新房间，点击添加房间按钮
        private void tsmiRoomAdd_Click(object sender, System.EventArgs e)
        {
            btnAddRoom.PerformClick();  // 点击添加房间按钮
        }
        #endregion

        #region 房间信息列表单元格右键菜单事件
        // 修改此项
        private void tsmiRoomCellModify_Click(object sender, System.EventArgs e)
        {
            dgvRoom.BeginEdit(false);   // 进入编辑状态
        }
        // 添加新房间
        private void tsmiRoomCellAdd_Click(object sender, System.EventArgs e)
        {
            btnAddRoom.PerformClick();  // 点击添加房间按钮
        }
        // 删除此房间
        private void tsmiRoomCellRemove_Click(object sender, System.EventArgs e)
        {
            int ri = dgvRoom.CurrentCell.RowIndex;
            if (MessageBox.Show(
                string.Format("删除此房间：{0} {1}？",
                dgvRoom.Rows[ri].Cells[0].Value,
                dgvRoom.Rows[ri].Cells[1].Value),
                "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvRoom.Rows.Remove(dgvRoom.Rows[ri]);      // 删除行
            }
        }

        #endregion



        #region 按钮事件
        // 添加房间
        private void btnAddRoom_Click(object sender, System.EventArgs e)
        {
            FrmRoomAdd frmRoomAdd = new FrmRoomAdd();
            if(frmRoomAdd.ShowDialog() == DialogResult.OK)      // 打开选择房间对话框
            {
                List<Room> rooms = frmRoomAdd.Tag as List<Room>;    // 获取选择的房间信息
                foreach(Room room in rooms)     // 插入选择的房间
                {
                    dgvRoom.Rows.Add(
                        room.RoomNo,
                        room.RoomType,
                        room.BedNum);
                }
            }
        }
        // 确定
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("预订成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        // 取消
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("确定要取消入住登记？",
                "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }
        #endregion
    }
}
