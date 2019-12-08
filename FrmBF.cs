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
    public partial class FrmBF : Form
    {
        public FrmBF()
        {
            InitializeComponent();
        }

        private void FrmBF_Load(object sender, EventArgs e)
        {
            dgvBFInfo.Rows.Add("赠送", "0");
            dgvBFInfo.Rows.Add("标准早餐票", "20");
        }

        private void tsmiBFAdd_Click(object sender, EventArgs e)
        {
            dgvBFInfo.Rows.Add();
        }

        private void tsmiBFAppend_Click(object sender, EventArgs e)
        {
            dgvBFInfo.Rows.Add();
        }

        private void dgvBFInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach(DataGridViewCell cell in dgvBFInfo.Rows[e.RowIndex].Cells)
            {
                cell.ContextMenuStrip = cmsBF;
            }
        }
    }
}
