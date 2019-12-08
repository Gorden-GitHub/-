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
            FrmStaff_Resize(sender, e);
            // 添加员工信息
            dgvStaffInfo.Rows.Add("1", "A", "12345678901", "123456789012345678", "清洁员", "0201");
        }

        private void FrmStaff_Resize(object sender, EventArgs e)
        {
            gbStaffInfo.Width = this.Width - gbStaffInfo.Margin.Right - 31;
            gbStaffInfo.Height = this.Height - 53;
            dgvStaffInfo.Width = gbStaffInfo.Width - 1;
            dgvStaffInfo.Height = gbStaffInfo.Height - dgvStaffInfo.Top - 2;
        }

        private void dgvStaffInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach(DataGridViewCell cell in dgvStaffInfo.Rows[e.RowIndex].Cells)
            {
                cell.ContextMenuStrip = cmsStaffInfo;
            }
        }

        private void tsmiAddStaff_Click(object sender, EventArgs e)
        {
            dgvStaffInfo.Rows.Add();
        }

        private void dgvStaffInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmStaffRoom frmStaffRoom = new FrmStaffRoom();
            frmStaffRoom.ShowDialog();
        }
    }
}