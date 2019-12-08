using System;
using System.Drawing;
using System.Windows.Forms;

namespace hotelmgr
{
    public partial class FrmMain : Form
    {
        private FrmLogin mFrmLogin;
        public FrmMain(FrmLogin frmLogin)
        {
            InitializeComponent();
            mFrmLogin = frmLogin;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 初始化选项
            cbRoomType.SelectedIndex = 0;
            cbBuildingNo.SelectedIndex = 0;
            cbFloorNo.SelectedIndex = 0;
            cbRoomState.SelectedIndex = 0;
            // 添加房间
            for (int i = 2; i <= 10; i++)
            {
                // 添加标签显示楼层号
                Label lblFloor = new Label();
                lblFloor.Name = "lbl" + i.ToString();
                lblFloor.Text = i.ToString() + "楼";
                lblFloor.AutoSize = false;
                lblFloor.Width = 50;
                lblFloor.Height = 100;
                lblFloor.Font = new Font(lblFloor.Font.FontFamily, 12);
                lblFloor.TextAlign = ContentAlignment.MiddleCenter;
                flpRoom.Controls.Add(lblFloor);
                for (int j = 1; j <= 10; j++)
                {
                    // 添加单选框表示客房
                    RadioButton rb = new RadioButton();
                    rb.Name = "rb" + (i < 10 ? "0" + i.ToString() : i.ToString()) + (j < 10 ? "0" + j.ToString() : j.ToString());
                    rb.Text = (i < 10 ? "0" + i.ToString() : i.ToString()) + (j < 10 ? "0" + j.ToString() : j.ToString());
                    if (j <= 3)
                        rb.Text += "\n大床房\n空房";
                    else if (j <= 7)
                        rb.Text += "\n双床房\n空房";
                    else if (j <= 9)
                        rb.Text += "\n三床房\n空房";
                    else
                        rb.Text += "\n套房\n空房";
                    rb.AutoSize = false;
                    rb.Margin = new Padding(1);
                    rb.Width = 100;
                    rb.Height = 100;
                    rb.Appearance = Appearance.Button;
                    rb.ContextMenuStrip = cmsRoom;
                    rb.Font = new Font(rb.Font.FontFamily, 12);
                    rb.TextAlign = ContentAlignment.TopLeft;
                    flpRoom.Controls.Add(rb);
                    if (j == 10)
                    {
                        flpRoom.SetFlowBreak(rb, true); // 控件换行
                    }
                }
            }
        }

        #region 工具栏
        // 新增预订
        private void tsbReserve_Click(object sender, EventArgs e)
        {
            new FrmReserve(this).ShowDialog();
        }
        // 入住登记
        private void tsbCheckIn_Click(object sender, EventArgs e)
        {
            new FrmCheckIn().ShowDialog();
        }
        // 会员登记
        private void tsbMember_Click(object sender, EventArgs e)
        {
            new FrmMemberAdd().ShowDialog();
        }
        // 早餐票
        private void tsbBF_Click(object sender, EventArgs e)
        {
            new FrmBFSell().ShowDialog();
        }
        // 客房管理
        private void tsbRoomMgr_Click(object sender, EventArgs e)
        {
            new FrmRoom().ShowDialog();
        }
        // 餐费管理
        private void tsbBFMgr_Click(object sender, EventArgs e)
        {
            new FrmBF().ShowDialog();
        }
        // 员工管理
        private void tsbStaffMgr_Click(object sender, EventArgs e)
        {
            new FrmStaff().ShowDialog();
        }
        // 切换用户
        private void tsbSwitchUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出当前用户？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                mFrmLogin.tbUsername.Text = "";
                mFrmLogin.tbPassword.Text = "";
                mFrmLogin.Show();
                mFrmLogin.tbUsername.Focus();
                Close();
            }
        }
        // 锁定系统
        private void tsbLockSystem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要锁定系统？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                new FrmLockScreen(mFrmLogin, this).Show();
                this.Hide();
            }
        }
        // 退出系统
        private void tsbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出系统？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                System.Environment.Exit(System.Environment.ExitCode);
            }
        }
        #endregion

        /* 右键菜单 */

        // 房间状态右键菜单
        private void cmsRoom_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ContextMenuStrip cms = (ContextMenuStrip)sender;    // 获取菜单
            RadioButton rb = (RadioButton)cms.SourceControl;    // 获取被右击的 RadioButton
            if (e.ClickedItem == cms.Items[0])                  // 预订此房
            {
                FrmReserve frmReserve = new FrmReserve(this);
                frmReserve.lvSelectedRooms.Items.Clear();
                ListViewItem item = new ListViewItem();
                string[] strs = rb.Text.Split(new char[1] { '\n' });    // 分割房间信息
                item.Text = strs[0];                                    // 房间编号
                item.SubItems.Add(strs[1]);                             // 房间类型
                if (strs[1].Equals("大床房"))
                {
                    item.SubItems.Add("2");
                    item.SubItems.Add("140");
                    item.SubItems.Add("");
                    item.SubItems.Add("否");
                }
                else if (strs[1].Equals("双床房"))
                {
                    item.SubItems.Add("2");
                    item.SubItems.Add("180");
                    item.SubItems.Add("");
                    item.SubItems.Add("否");
                }
                else if (strs[1].Equals("三床房"))
                {
                    item.SubItems.Add("3");
                    item.SubItems.Add("220");
                    item.SubItems.Add("");
                    item.SubItems.Add("否");
                }
                else
                {
                    item.SubItems.Add("5");
                    item.SubItems.Add("260");
                    item.SubItems.Add("");
                    item.SubItems.Add("否");
                }
                frmReserve.lvSelectedRooms.Items.Add(item);     // 插入已选房间
                frmReserve.ShowDialog();
            }
            else if (e.ClickedItem == cms.Items[1])              // 登记入住
            {
                FrmCheckIn frmCheckIn = new FrmCheckIn();
                frmCheckIn.ShowDialog();
            }
            else if (e.ClickedItem == cms.Items[2])              // 退房结账
            {

            }
            else if (e.ClickedItem == cms.Items[4])              // 管理信息
            {
                FrmRoom frmRoom = new FrmRoom();
                frmRoom.ShowDialog();
            }
            else
            {

            }
        }
        // 预订管理右键菜单
        private void cmsReserve_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ContextMenuStrip cms = (ContextMenuStrip)sender;
            if (e.ClickedItem == cms.Items[0])       // 新增预定
            {
                new FrmReserve(this).ShowDialog();
            }
        }

        private void dgvReserve_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvReserve.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            foreach (DataGridViewCell cell in dgvReserve.Rows[e.RowIndex].Cells)
            {
                cell.ContextMenuStrip = cmsReserveMgr;
            }
        }
        // 新增预订
        private void tsmiReserveAppend_Click(object sender, EventArgs e)
        {
            FrmReserve frmReserve = new FrmReserve(this);
            frmReserve.ShowDialog();
        }
        // 修改预订
        private void tsmiReserveModiify_Click(object sender, EventArgs e)
        {
            FrmReserve frmReserve = new FrmReserve(this);
            frmReserve.ShowDialog();
        }
        // 入住登记
        private void tsmiReserveCheckIn_Click(object sender, EventArgs e)
        {
            FrmCheckIn frmCheckIn = new FrmCheckIn();
            frmCheckIn.ShowDialog();
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            panel1.Left = tabControl1.Width - panel1.Width;
            panel1.Height = tabControl1.Height - tabControl1.ItemSize.Height - 6;
            flpRoom.Width = panel1.Left;
            flpRoom.Height = tabControl1.Height - tabControl1.ItemSize.Height - 6;
        }
    }
}
