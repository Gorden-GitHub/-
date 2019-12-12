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
    public partial class FrmMember : Form
    {
        public FrmMember()
        {
            InitializeComponent();
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            // 初始化窗体位置及大小
            this.Top = 0;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }
    }
}
