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
    public partial class FrmStaff : Form
    {
        public FrmStaff()
        {
            InitializeComponent();
        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            // 添加员工信息
            dgvStaff.Rows.Add("1", "A", "12345678901", "123456789012345678", "清洁员", "0201");
        }


        #region 员工列表
        // 添加行时绑定右键菜单
        private void dgvStaff_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewCell cell in dgvStaff.Rows[e.RowIndex].Cells)
            {
                cell.ContextMenuStrip = cmsStaffCell;
            }
        }
        // 双击单元格响应事件
        private void dgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                FrmStaffRoom frmStaffRoom = new FrmStaffRoom();
                frmStaffRoom.ShowDialog();
            }
        }
        #endregion

        #region 员工列表右键菜单
        // 添加新员工
        private void tsmiStaffAdd_Click(object sender, EventArgs e)
        {
            dgvStaff.Rows.Add();
        }
        #endregion
    }
}