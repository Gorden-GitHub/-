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
    public partial class FrmRoomAdd : Form
    {
        public FrmRoomAdd()
        {
            InitializeComponent();
        }

        private void FrmRoomAdd_Load(object sender, EventArgs e)
        {
            cbRoomType.SelectedIndex = 0;
        }
        // 确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
