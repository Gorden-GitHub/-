using System;
using System.Drawing;
using System.Windows.Forms;

namespace hotelmgt
{
    public partial class FrmMain : Form
    {
        public static FrmMain frmMain;      // 当前窗体实例

        public FrmMain()
        {
            InitializeComponent();
            frmMain = this;     // 保存当前窗体实例
        }

        #region 窗体事件

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
                Label lblFloor = new Label
                {
                    Name = "lbl" + i.ToString(),
                    Text = i.ToString() + "楼",
                    AutoSize = false,
                    Width = 45,
                    Height = 90
                };
                lblFloor.Font = new Font(lblFloor.Font.FontFamily, 11);
                lblFloor.TextAlign = ContentAlignment.MiddleCenter;
                flpRoom.Controls.Add(lblFloor);
                for (int j = 1; j <= 10; j++)
                {
                    // 添加单选框表示客房
                    RadioButton rb = new RadioButton
                    {
                        Name = "rb" + (i < 10 ? "0" + i.ToString() : i.ToString()) + (j < 10 ? "0" + j.ToString() : j.ToString()),
                        Text = (i < 10 ? "0" + i.ToString() : i.ToString()) + (j < 10 ? "0" + j.ToString() : j.ToString()),
                        AutoSize = false,
                        Margin = new Padding(1),
                        Width = 90,
                        Height = 90,
                        Appearance = Appearance.Button,
                        ContextMenuStrip = cmsRoom
                    };
                    rb.Font = new Font(rb.Font.FontFamily, 11);
                    rb.TextAlign = ContentAlignment.TopLeft;
                    if (j <= 3)
                        rb.Text += "\n大床房\n空房";
                    else if (j <= 7)
                        rb.Text += "\n双床房\n空房";
                    else if (j <= 9)
                        rb.Text += "\n三床房\n空房";
                    else
                        rb.Text += "\n套房\n空房";
                    flpRoom.Controls.Add(rb);
                    if (j == 10)
                    {
                        flpRoom.SetFlowBreak(rb, true); // 控件换行
                    }
                }
            }
        }

        // 关闭窗体时，弹出确认提示，调用工具栏的退出系统按钮事件
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #endregion

        #region 工具栏事件
        // 新增预订
        private void tsbReserve_Click(object sender, EventArgs e)
        {
            FrmReserve frmReserve = new FrmReserve();
            frmReserve.ShowDialog();
            frmReserve.Dispose();
        }

        // 入住登记
        private void tsbCheckIn_Click(object sender, EventArgs e)
        {
            FrmCheckIn frmCheckIn = new FrmCheckIn();
            frmCheckIn.ShowDialog();
            frmCheckIn.Dispose();
        }

        // 会员登记
        private void tsbMemberAdd_Click(object sender, EventArgs e)
        {
            FrmMemberAdd frmMemberAdd = new FrmMemberAdd();
            frmMemberAdd.ShowDialog();
            frmMemberAdd.Dispose();
        }

        // 早餐票
        private void tsbTicket_Click(object sender, EventArgs e)
        {
            FrmBFSell frmBFSell = new FrmBFSell();
            frmBFSell.ShowDialog();
            frmBFSell.Dispose();
        }

        // 退房结账
        private void tsbCheckOut_Click(object sender, EventArgs e)
        {
            FrmCheckOut frmCheckOut = new FrmCheckOut();
            frmCheckOut.ShowDialog();
            frmCheckOut.Dispose();
        }

        // 客房管理
        private void tsbRoomMgt_Click(object sender, EventArgs e)
        {
            FrmRoom frmRoom = new FrmRoom();
            frmRoom.ShowDialog();
            frmRoom.Dispose();
        }

        // 会员管理
        private void tsbMemberMgt_Click(object sender, EventArgs e)
        {
            FrmMember frmMember = new FrmMember();
            frmMember.ShowDialog();
            frmMember.Dispose();
        }

        // 餐费管理
        private void tsbTicketMgt_Click(object sender, EventArgs e)
        {
            FrmBF frmBF = new FrmBF();
            frmBF.ShowDialog();
            frmBF.Dispose();
        }

        // 员工管理
        private void tsbStaffMgt_Click(object sender, EventArgs e)
        {
            FrmStaff frmStaff = new FrmStaff();
            frmStaff.ShowDialog();
            frmStaff.Dispose();
        }

        // 切换用户
        private void tsbSwitchUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出当前用户？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                FrmLogin.frmLogin.tbUsername.Text = "";
                FrmLogin.frmLogin.tbPassword.Text = "";
                FrmLogin.frmLogin.Show();
                FrmLogin.frmLogin.tbUsername.Focus();
                Close();
            }
        }

        // 系统设置
        private void tsbSystemSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
            frmSettings.Dispose();
        }

        // 锁定系统
        private void tsbLockSystem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要锁定系统？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                new FrmLockScreen().Show();
                this.Hide();
            }
        }

        // 退出系统
        private void tsbExitSystem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("确定要退出系统？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                System.Environment.Exit(System.Environment.ExitCode);
            }
        }

        #endregion

        #region 房间状态

        // 单选框右键菜单
        private void cmsRoom_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ContextMenuStrip cms = (ContextMenuStrip)sender;    // 获取菜单
            RadioButton rb = (RadioButton)cms.SourceControl;    // 获取被右击的 RadioButton
            if (e.ClickedItem == cms.Items[0])                  // 预订此房
            {
                FrmReserve frmReserve = new FrmReserve();
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
                frmReserve.Dispose();
            }
            else if (e.ClickedItem == cms.Items[1])              // 登记入住
            {
                FrmCheckIn frmCheckIn = new FrmCheckIn();
                frmCheckIn.ShowDialog();
                frmCheckIn.Dispose();
            }
            else if (e.ClickedItem == cms.Items[2])              // 退房结账
            {

            }
            else if (e.ClickedItem == cms.Items[4])              // 管理信息
            {
                FrmRoom frmRoom = new FrmRoom();
                frmRoom.ShowDialog();
                frmRoom.Dispose();
            }
            else
            {

            }
        }

        // 按钮新增预订
        private void btnReserve_Click(object sender, EventArgs e)
        {
            FrmReserve frmReserve = new FrmReserve();
            frmReserve.ShowDialog();
            frmReserve.Dispose();
        }

        // 退房结账
        private void tsmiCheckOut_Click(object sender, EventArgs e)
        {
            FrmCheckOut frmCheckOut = new FrmCheckOut();
            frmCheckOut.ShowDialog();
            frmCheckOut.Dispose();
        }

        #endregion

        #region 预订管理

        // 选择列表右键菜单
        private void cmsReserve_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ContextMenuStrip cms = (ContextMenuStrip)sender;
            if (e.ClickedItem == cms.Items[0])       // 新增预定
            {
                FrmReserve frmReserve = new FrmReserve();
                frmReserve.ShowDialog();
                frmReserve.Dispose();
            }
        }

        // 新增预订
        private void tsmiReserveAppend_Click(object sender, EventArgs e)
        {
            FrmReserve frmReserve = new FrmReserve();
            frmReserve.ShowDialog();
            frmReserve.Dispose();
        }

        // 修改预订
        private void tsmiReserveModiify_Click(object sender, EventArgs e)
        {
            FrmReserve frmReserve = new FrmReserve();
            frmReserve.ShowDialog();
            frmReserve.Dispose();
        }

        // 入住登记
        private void tsmiReserveCheckIn_Click(object sender, EventArgs e)
        {
            FrmCheckIn frmCheckIn = new FrmCheckIn();
            frmCheckIn.ShowDialog();
            frmCheckIn.Dispose();
        }

        // 为列表新增项绑定右键菜单
        private void dgvReserve_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvReserve.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            foreach (DataGridViewCell cell in dgvReserve.Rows[e.RowIndex].Cells)
            {
                cell.ContextMenuStrip = cmsReserveMgt;
            }
        }

        #endregion
    }
}
