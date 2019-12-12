namespace hotelmgt
{
    partial class FrmReserve
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
            this.gbGuestInfo = new System.Windows.Forms.GroupBox();
            this.dtpLeaveTime = new System.Windows.Forms.DateTimePicker();
            this.lblLeaveTime = new System.Windows.Forms.Label();
            this.dtpArriveTime = new System.Windows.Forms.DateTimePicker();
            this.lblArriveTime = new System.Windows.Forms.Label();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbSelectedRooms = new System.Windows.Forms.GroupBox();
            this.lvSelectedRooms = new System.Windows.Forms.ListView();
            this.chRoomNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBedNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoomPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIsHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbGuestInfo.SuspendLayout();
            this.gbSelectedRooms.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGuestInfo
            // 
            this.gbGuestInfo.Controls.Add(this.dtpLeaveTime);
            this.gbGuestInfo.Controls.Add(this.lblLeaveTime);
            this.gbGuestInfo.Controls.Add(this.dtpArriveTime);
            this.gbGuestInfo.Controls.Add(this.lblArriveTime);
            this.gbGuestInfo.Controls.Add(this.tbRemarks);
            this.gbGuestInfo.Controls.Add(this.lblRemarks);
            this.gbGuestInfo.Controls.Add(this.tbPhone);
            this.gbGuestInfo.Controls.Add(this.lblPhone);
            this.gbGuestInfo.Controls.Add(this.tbName);
            this.gbGuestInfo.Controls.Add(this.lblName);
            this.gbGuestInfo.Location = new System.Drawing.Point(13, 13);
            this.gbGuestInfo.Name = "gbGuestInfo";
            this.gbGuestInfo.Size = new System.Drawing.Size(565, 146);
            this.gbGuestInfo.TabIndex = 0;
            this.gbGuestInfo.TabStop = false;
            this.gbGuestInfo.Text = "客户信息";
            // 
            // dtpLeaveTime
            // 
            this.dtpLeaveTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpLeaveTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLeaveTime.Location = new System.Drawing.Point(372, 60);
            this.dtpLeaveTime.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.dtpLeaveTime.Name = "dtpLeaveTime";
            this.dtpLeaveTime.Size = new System.Drawing.Size(180, 25);
            this.dtpLeaveTime.TabIndex = 9;
            // 
            // lblLeaveTime
            // 
            this.lblLeaveTime.Location = new System.Drawing.Point(287, 60);
            this.lblLeaveTime.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblLeaveTime.Name = "lblLeaveTime";
            this.lblLeaveTime.Size = new System.Drawing.Size(85, 25);
            this.lblLeaveTime.TabIndex = 8;
            this.lblLeaveTime.Text = "预离时间：";
            this.lblLeaveTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpArriveTime
            // 
            this.dtpArriveTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpArriveTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArriveTime.Location = new System.Drawing.Point(92, 60);
            this.dtpArriveTime.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.dtpArriveTime.Name = "dtpArriveTime";
            this.dtpArriveTime.Size = new System.Drawing.Size(180, 25);
            this.dtpArriveTime.TabIndex = 7;
            this.dtpArriveTime.ValueChanged += new System.EventHandler(this.dtpArriveTime_ValueChanged);
            // 
            // lblArriveTime
            // 
            this.lblArriveTime.Location = new System.Drawing.Point(7, 60);
            this.lblArriveTime.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblArriveTime.Name = "lblArriveTime";
            this.lblArriveTime.Size = new System.Drawing.Size(85, 25);
            this.lblArriveTime.TabIndex = 6;
            this.lblArriveTime.Text = "预达时间：";
            this.lblArriveTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRemarks
            // 
            this.tbRemarks.HideSelection = false;
            this.tbRemarks.Location = new System.Drawing.Point(92, 95);
            this.tbRemarks.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(460, 25);
            this.tbRemarks.TabIndex = 5;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(7, 95);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(85, 25);
            this.lblRemarks.TabIndex = 4;
            this.lblRemarks.Text = "备注：";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPhone
            // 
            this.tbPhone.HideSelection = false;
            this.tbPhone.Location = new System.Drawing.Point(372, 25);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(180, 25);
            this.tbPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(287, 25);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(85, 25);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "手机号码：";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.HideSelection = false;
            this.tbName.Location = new System.Drawing.Point(92, 25);
            this.tbName.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 25);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(7, 25);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "联系人：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbSelectedRooms
            // 
            this.gbSelectedRooms.Controls.Add(this.lvSelectedRooms);
            this.gbSelectedRooms.Location = new System.Drawing.Point(13, 165);
            this.gbSelectedRooms.Name = "gbSelectedRooms";
            this.gbSelectedRooms.Size = new System.Drawing.Size(565, 200);
            this.gbSelectedRooms.TabIndex = 1;
            this.gbSelectedRooms.TabStop = false;
            this.gbSelectedRooms.Text = "已选房间";
            // 
            // lvSelectedRooms
            // 
            this.lvSelectedRooms.CheckBoxes = true;
            this.lvSelectedRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRoomNo,
            this.chRoomType,
            this.chBedNum,
            this.chRoomPrice,
            this.chIsHour,
            this.chHours});
            this.lvSelectedRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSelectedRooms.FullRowSelect = true;
            this.lvSelectedRooms.GridLines = true;
            this.lvSelectedRooms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSelectedRooms.HideSelection = false;
            this.lvSelectedRooms.Location = new System.Drawing.Point(3, 21);
            this.lvSelectedRooms.Margin = new System.Windows.Forms.Padding(5);
            this.lvSelectedRooms.MultiSelect = false;
            this.lvSelectedRooms.Name = "lvSelectedRooms";
            this.lvSelectedRooms.Size = new System.Drawing.Size(559, 176);
            this.lvSelectedRooms.TabIndex = 8;
            this.lvSelectedRooms.UseCompatibleStateImageBehavior = false;
            this.lvSelectedRooms.View = System.Windows.Forms.View.Details;
            // 
            // chRoomNo
            // 
            this.chRoomNo.Text = "房间编号";
            this.chRoomNo.Width = 80;
            // 
            // chRoomType
            // 
            this.chRoomType.Text = "房间类型";
            this.chRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chBedNum
            // 
            this.chBedNum.Text = "床位数";
            this.chBedNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chRoomPrice
            // 
            this.chRoomPrice.Text = "房间价格";
            this.chRoomPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chIsHour
            // 
            this.chIsHour.Text = "是否钟点房";
            this.chIsHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chIsHour.Width = 80;
            // 
            // chHours
            // 
            this.chHours.Text = "钟点房时长";
            this.chHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHours.Width = 80;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnRemoveRoom);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 45);
            this.panel1.TabIndex = 24;
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Location = new System.Drawing.Point(120, 5);
            this.btnRemoveRoom.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(105, 35);
            this.btnRemoveRoom.TabIndex = 24;
            this.btnRemoveRoom.Text = "删除房间";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(5, 5);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(105, 35);
            this.btnAddRoom.TabIndex = 23;
            this.btnAddRoom.Text = "添加房间";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Location = new System.Drawing.Point(461, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOK.Location = new System.Drawing.Point(346, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 35);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(591, 426);
            this.Controls.Add(this.gbSelectedRooms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbGuestInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReserve";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加预订信息";
            this.Load += new System.EventHandler(this.FrmReserve_Load);
            this.gbGuestInfo.ResumeLayout(false);
            this.gbGuestInfo.PerformLayout();
            this.gbSelectedRooms.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGuestInfo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.DateTimePicker dtpLeaveTime;
        private System.Windows.Forms.Label lblLeaveTime;
        private System.Windows.Forms.GroupBox gbSelectedRooms;
        private System.Windows.Forms.DateTimePicker dtpArriveTime;
        private System.Windows.Forms.Label lblArriveTime;
        private System.Windows.Forms.ColumnHeader chRoomNo;
        private System.Windows.Forms.ColumnHeader chRoomType;
        private System.Windows.Forms.ColumnHeader chBedNum;
        private System.Windows.Forms.ColumnHeader chIsHour;
        private System.Windows.Forms.ColumnHeader chHours;
        private System.Windows.Forms.ColumnHeader chRoomPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoveRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.ListView lvSelectedRooms;
    }
}