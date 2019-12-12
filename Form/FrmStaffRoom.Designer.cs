namespace hotelmgt
{
    partial class FrmStaffRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0201",
            "大床房",
            "2"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.gbAvailableRoom = new System.Windows.Forms.GroupBox();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lvAvailableRooms = new System.Windows.Forms.ListView();
            this.chRoomNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBedNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvSelectedRooms = new System.Windows.Forms.ListView();
            this.chSelectedRoomNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSelectedRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSelectedBedNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbAvailableRoom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(104, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbAvailableRoom
            // 
            this.gbAvailableRoom.Controls.Add(this.cbRoomType);
            this.gbAvailableRoom.Controls.Add(this.lblRoomType);
            this.gbAvailableRoom.Controls.Add(this.lvAvailableRooms);
            this.gbAvailableRoom.Location = new System.Drawing.Point(10, 49);
            this.gbAvailableRoom.Margin = new System.Windows.Forms.Padding(1, 5, 1, 1);
            this.gbAvailableRoom.Name = "gbAvailableRoom";
            this.gbAvailableRoom.Padding = new System.Windows.Forms.Padding(2);
            this.gbAvailableRoom.Size = new System.Drawing.Size(330, 390);
            this.gbAvailableRoom.TabIndex = 6;
            this.gbAvailableRoom.TabStop = false;
            this.gbAvailableRoom.Text = "可选房间";
            // 
            // cbRoomType
            // 
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.Items.AddRange(new object[] {
            "全部",
            "大床房",
            "双床房",
            "三床房",
            "套房"});
            this.cbRoomType.Location = new System.Drawing.Point(92, 25);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(226, 23);
            this.cbRoomType.TabIndex = 4;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Location = new System.Drawing.Point(7, 25);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(85, 25);
            this.lblRoomType.TabIndex = 3;
            this.lblRoomType.Text = "房间类型：";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvAvailableRooms
            // 
            this.lvAvailableRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRoomNo,
            this.chRoomType,
            this.chBedNum});
            this.lvAvailableRooms.FullRowSelect = true;
            this.lvAvailableRooms.HideSelection = false;
            this.lvAvailableRooms.Location = new System.Drawing.Point(0, 60);
            this.lvAvailableRooms.Margin = new System.Windows.Forms.Padding(5);
            this.lvAvailableRooms.Name = "lvAvailableRooms";
            this.lvAvailableRooms.Size = new System.Drawing.Size(329, 329);
            this.lvAvailableRooms.TabIndex = 5;
            this.lvAvailableRooms.UseCompatibleStateImageBehavior = false;
            this.lvAvailableRooms.View = System.Windows.Forms.View.Details;
            // 
            // chRoomNo
            // 
            this.chRoomNo.Text = "房间编号";
            // 
            // chRoomType
            // 
            this.chRoomType.Text = "房间类型";
            this.chRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRoomType.Width = 100;
            // 
            // chBedNum
            // 
            this.chBedNum.Text = "床位数";
            this.chBedNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbStaffName
            // 
            this.tbStaffName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbStaffName.Location = new System.Drawing.Point(104, 14);
            this.tbStaffName.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.ReadOnly = true;
            this.tbStaffName.Size = new System.Drawing.Size(224, 25);
            this.tbStaffName.TabIndex = 8;
            this.tbStaffName.Text = "1";
            // 
            // lblStaffName
            // 
            this.lblStaffName.Location = new System.Drawing.Point(14, 14);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(85, 25);
            this.lblStaffName.TabIndex = 7;
            this.lblStaffName.Text = "员工编号：";
            this.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(445, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(224, 25);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "A";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(355, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "员工姓名：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvSelectedRooms);
            this.groupBox1.Location = new System.Drawing.Point(351, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(330, 345);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已选房间";
            // 
            // lvSelectedRooms
            // 
            this.lvSelectedRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSelectedRoomNo,
            this.chSelectedRoomType,
            this.chSelectedBedNum});
            this.lvSelectedRooms.FullRowSelect = true;
            this.lvSelectedRooms.HideSelection = false;
            this.lvSelectedRooms.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvSelectedRooms.Location = new System.Drawing.Point(0, 25);
            this.lvSelectedRooms.Margin = new System.Windows.Forms.Padding(5);
            this.lvSelectedRooms.Name = "lvSelectedRooms";
            this.lvSelectedRooms.Size = new System.Drawing.Size(329, 319);
            this.lvSelectedRooms.TabIndex = 5;
            this.lvSelectedRooms.UseCompatibleStateImageBehavior = false;
            this.lvSelectedRooms.View = System.Windows.Forms.View.Details;
            // 
            // chSelectedRoomNo
            // 
            this.chSelectedRoomNo.Text = "房间编号";
            // 
            // chSelectedRoomType
            // 
            this.chSelectedRoomType.Text = "房间类型";
            this.chSelectedRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSelectedRoomType.Width = 100;
            // 
            // chSelectedBedNum
            // 
            this.chSelectedBedNum.Text = "床位数";
            this.chSelectedBedNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(575, 404);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(460, 404);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 35);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmStaffRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(694, 453);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStaffName);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.gbAvailableRoom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStaffRoom";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择负责的房间编号";
            this.Load += new System.EventHandler(this.FrmStaffRoom_Load);
            this.gbAvailableRoom.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAvailableRoom;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label lblRoomType;
        public System.Windows.Forms.ListView lvAvailableRooms;
        private System.Windows.Forms.ColumnHeader chRoomNo;
        private System.Windows.Forms.ColumnHeader chRoomType;
        private System.Windows.Forms.ColumnHeader chBedNum;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListView lvSelectedRooms;
        private System.Windows.Forms.ColumnHeader chSelectedRoomNo;
        private System.Windows.Forms.ColumnHeader chSelectedRoomType;
        private System.Windows.Forms.ColumnHeader chSelectedBedNum;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}