using hotelmgt.Model;
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
    public partial class FrmRoomAdd : Form
    {
        public FrmRoomAdd()
        {
            InitializeComponent();
        }

        private void FrmRoomAdd_Load(object sender, EventArgs e)
        {
            cbRoomType.SelectedIndex = 0;
            for (int i = 1; i <= 10; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "02" + (i < 10 ? "0" + i : "" + i);
                item.SubItems.Add("大床房");
                item.SubItems.Add("1");
                lvRoomsAvailable.Items.Add(item);
            }
        }

        #region 按钮事件
        // 确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            List<Room> rooms = new List<Room>();
            foreach (ListViewItem item in lvRoomsSelected.Items)
            {
                Room room = new Room();
                room.RoomNo = item.Text;
                room.RoomType = item.SubItems[1].Text;
                room.BedNum = int.Parse(item.SubItems[2].Text);
                rooms.Add(room);
            }
            this.Tag = rooms;
            this.DialogResult = DialogResult.OK;
            Close();
        }
        #endregion

        #region 可选列表
        // 双击项目，移动房间到已选列表
        private void lvRoomsAvailable_DoubleClick(object sender, EventArgs e)
        {
            if(lvRoomsAvailable.SelectedItems.Count > 0)
            {
                ListViewItem item = lvRoomsAvailable.SelectedItems[0];  // 取得项目
                lvRoomsAvailable.SelectedItems[0].Remove();     // 从原列表分离
                item.Selected = false;      // 取消选择
                lvRoomsSelected.Items.Add(item);    // 插入到新列表中
            }
        }
        #endregion

        #region 已选列表
        // 移动房间到可选列表
        private void lvRoomsSelected_DoubleClick(object sender, EventArgs e)
        {
            if (lvRoomsSelected.SelectedItems.Count > 0)
            {
                ListViewItem item = lvRoomsSelected.SelectedItems[0];  // 取得项目
                lvRoomsSelected.SelectedItems[0].Remove();     // 从原列表分离
                item.Selected = false;      // 取消选择
                lvRoomsAvailable.Items.Add(item);    // 插入到新列表中
            }
        }
        #endregion
    }
}
