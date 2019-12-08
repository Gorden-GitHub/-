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
    public partial class FrmStaffRoom : Form
    {
        public FrmStaffRoom()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已修改该员工所负责的房间编号。", "提示");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmStaffRoom_Load(object sender, EventArgs e)
        {
            cbRoomType.SelectedIndex = 0;
        }
    }
}
