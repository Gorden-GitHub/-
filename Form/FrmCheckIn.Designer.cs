namespace hotelmgt
{
    partial class FrmCheckIn
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbRoomInfo = new System.Windows.Forms.GroupBox();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.cRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBedNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIsHourRoom = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLeaveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCall = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cCallTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDiscPct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRoomPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csmRoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRoomAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRoomCell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRoomCellModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRoomCellAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomCellRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCustInfo = new System.Windows.Forms.GroupBox();
            this.dgvCust = new System.Windows.Forms.DataGridView();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCertType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cCertNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIsMember = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cSelectedRoomNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmsCust = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.lblDepositVal = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblDiscRateVal = new System.Windows.Forms.Label();
            this.lblDiscRate = new System.Windows.Forms.Label();
            this.lblRoomPriceVal = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblRoomNumVal = new System.Windows.Forms.Label();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmsCustCell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustCellModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCustCellAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustCellRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.gbRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.csmRoom.SuspendLayout();
            this.cmsRoomCell.SuspendLayout();
            this.gbCustInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            this.cmsCust.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmsCustCell.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRoomInfo
            // 
            this.gbRoomInfo.Controls.Add(this.dgvRoom);
            this.gbRoomInfo.Location = new System.Drawing.Point(13, 252);
            this.gbRoomInfo.Name = "gbRoomInfo";
            this.gbRoomInfo.Size = new System.Drawing.Size(1198, 339);
            this.gbRoomInfo.TabIndex = 6;
            this.gbRoomInfo.TabStop = false;
            this.gbRoomInfo.Text = "房间信息";
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToResizeColumns = false;
            this.dgvRoom.AllowUserToResizeRows = false;
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRoom.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoom.ColumnHeadersHeight = 29;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRoomNo,
            this.cRoomType,
            this.cBedNum,
            this.cIsHourRoom,
            this.cHours,
            this.cCheckInTime,
            this.cLeaveTime,
            this.cCall,
            this.cCallTime,
            this.cRoomPrice,
            this.cDiscPct,
            this.cRoomPay,
            this.cRemarks});
            this.dgvRoom.ContextMenuStrip = this.csmRoom;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoom.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoom.Location = new System.Drawing.Point(3, 21);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 29;
            this.dgvRoom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRoom.RowTemplate.Height = 27;
            this.dgvRoom.Size = new System.Drawing.Size(1192, 315);
            this.dgvRoom.TabIndex = 7;
            this.dgvRoom.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoom_CellMouseUp);
            this.dgvRoom.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvRoom_RowsAdded);
            // 
            // cRoomNo
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            this.cRoomNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.cRoomNo.FillWeight = 60F;
            this.cRoomNo.HeaderText = "房间编号";
            this.cRoomNo.MinimumWidth = 6;
            this.cRoomNo.Name = "cRoomNo";
            this.cRoomNo.ReadOnly = true;
            this.cRoomNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRoomType
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            this.cRoomType.DefaultCellStyle = dataGridViewCellStyle3;
            this.cRoomType.HeaderText = "房间类型";
            this.cRoomType.MinimumWidth = 6;
            this.cRoomType.Name = "cRoomType";
            this.cRoomType.ReadOnly = true;
            this.cRoomType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cBedNum
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            this.cBedNum.DefaultCellStyle = dataGridViewCellStyle4;
            this.cBedNum.FillWeight = 60F;
            this.cBedNum.HeaderText = "床位数";
            this.cBedNum.MinimumWidth = 6;
            this.cBedNum.Name = "cBedNum";
            this.cBedNum.ReadOnly = true;
            this.cBedNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cIsHourRoom
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.NullValue = false;
            this.cIsHourRoom.DefaultCellStyle = dataGridViewCellStyle5;
            this.cIsHourRoom.FillWeight = 60F;
            this.cIsHourRoom.HeaderText = "钟点房";
            this.cIsHourRoom.MinimumWidth = 6;
            this.cIsHourRoom.Name = "cIsHourRoom";
            this.cIsHourRoom.ReadOnly = true;
            // 
            // cHours
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            this.cHours.DefaultCellStyle = dataGridViewCellStyle6;
            this.cHours.FillWeight = 40F;
            this.cHours.HeaderText = "时长";
            this.cHours.MinimumWidth = 6;
            this.cHours.Name = "cHours";
            this.cHours.ReadOnly = true;
            this.cHours.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cCheckInTime
            // 
            this.cCheckInTime.HeaderText = "入住时间";
            this.cCheckInTime.MinimumWidth = 6;
            this.cCheckInTime.Name = "cCheckInTime";
            this.cCheckInTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cLeaveTime
            // 
            this.cLeaveTime.HeaderText = "预离时间";
            this.cLeaveTime.MinimumWidth = 6;
            this.cLeaveTime.Name = "cLeaveTime";
            this.cLeaveTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cCall
            // 
            this.cCall.FalseValue = "";
            this.cCall.FillWeight = 40F;
            this.cCall.HeaderText = "叫早";
            this.cCall.IndeterminateValue = "";
            this.cCall.MinimumWidth = 6;
            this.cCall.Name = "cCall";
            this.cCall.TrueValue = "";
            // 
            // cCallTime
            // 
            this.cCallTime.HeaderText = "叫早时间";
            this.cCallTime.MinimumWidth = 6;
            this.cCallTime.Name = "cCallTime";
            this.cCallTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRoomPrice
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            this.cRoomPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.cRoomPrice.FillWeight = 40F;
            this.cRoomPrice.HeaderText = "价格";
            this.cRoomPrice.MinimumWidth = 6;
            this.cRoomPrice.Name = "cRoomPrice";
            this.cRoomPrice.ReadOnly = true;
            this.cRoomPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cDiscPct
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            this.cDiscPct.DefaultCellStyle = dataGridViewCellStyle8;
            this.cDiscPct.FillWeight = 60F;
            this.cDiscPct.HeaderText = "折扣率";
            this.cDiscPct.MinimumWidth = 6;
            this.cDiscPct.Name = "cDiscPct";
            this.cDiscPct.ReadOnly = true;
            this.cDiscPct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRoomPay
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
            this.cRoomPay.DefaultCellStyle = dataGridViewCellStyle9;
            this.cRoomPay.FillWeight = 60F;
            this.cRoomPay.HeaderText = "应收押金";
            this.cRoomPay.MinimumWidth = 6;
            this.cRoomPay.Name = "cRoomPay";
            this.cRoomPay.ReadOnly = true;
            this.cRoomPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRemarks
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cRemarks.DefaultCellStyle = dataGridViewCellStyle10;
            this.cRemarks.HeaderText = "备注";
            this.cRemarks.MinimumWidth = 6;
            this.cRemarks.Name = "cRemarks";
            this.cRemarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // csmRoom
            // 
            this.csmRoom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.csmRoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomAdd});
            this.csmRoom.Name = "csmRoom";
            this.csmRoom.Size = new System.Drawing.Size(159, 28);
            // 
            // tsmiRoomAdd
            // 
            this.tsmiRoomAdd.Name = "tsmiRoomAdd";
            this.tsmiRoomAdd.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomAdd.Text = "添加新房间";
            this.tsmiRoomAdd.Click += new System.EventHandler(this.tsmiRoomAdd_Click);
            // 
            // cmsRoomCell
            // 
            this.cmsRoomCell.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoomCell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomCellModify,
            this.toolStripSeparator2,
            this.tsmiRoomCellAdd,
            this.tsmiRoomCellRemove});
            this.cmsRoomCell.Name = "contextMenuStrip1";
            this.cmsRoomCell.Size = new System.Drawing.Size(159, 82);
            // 
            // tsmiRoomCellModify
            // 
            this.tsmiRoomCellModify.Name = "tsmiRoomCellModify";
            this.tsmiRoomCellModify.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomCellModify.Text = "修改此项";
            this.tsmiRoomCellModify.Click += new System.EventHandler(this.tsmiRoomCellModify_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiRoomCellAdd
            // 
            this.tsmiRoomCellAdd.Name = "tsmiRoomCellAdd";
            this.tsmiRoomCellAdd.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomCellAdd.Text = "添加新房间";
            this.tsmiRoomCellAdd.Click += new System.EventHandler(this.tsmiRoomCellAdd_Click);
            // 
            // tsmiRoomCellRemove
            // 
            this.tsmiRoomCellRemove.Name = "tsmiRoomCellRemove";
            this.tsmiRoomCellRemove.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomCellRemove.Text = "删除此房间";
            this.tsmiRoomCellRemove.Click += new System.EventHandler(this.tsmiRoomCellRemove_Click);
            // 
            // gbCustInfo
            // 
            this.gbCustInfo.Controls.Add(this.dgvCust);
            this.gbCustInfo.Location = new System.Drawing.Point(13, 13);
            this.gbCustInfo.Name = "gbCustInfo";
            this.gbCustInfo.Size = new System.Drawing.Size(1198, 233);
            this.gbCustInfo.TabIndex = 0;
            this.gbCustInfo.TabStop = false;
            this.gbCustInfo.Text = "客户信息";
            // 
            // dgvCust
            // 
            this.dgvCust.AllowUserToAddRows = false;
            this.dgvCust.AllowUserToDeleteRows = false;
            this.dgvCust.AllowUserToResizeColumns = false;
            this.dgvCust.AllowUserToResizeRows = false;
            this.dgvCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCust.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCust.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCust.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCust.ColumnHeadersHeight = 29;
            this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNo,
            this.cName,
            this.cPhone,
            this.cCertType,
            this.cCertNum,
            this.cAddress,
            this.cIsMember,
            this.cSelectedRoomNo});
            this.dgvCust.ContextMenuStrip = this.cmsCust;
            this.dgvCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCust.Location = new System.Drawing.Point(3, 21);
            this.dgvCust.MultiSelect = false;
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.RowHeadersWidth = 29;
            this.dgvCust.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCust.RowTemplate.Height = 27;
            this.dgvCust.Size = new System.Drawing.Size(1192, 209);
            this.dgvCust.TabIndex = 1;
            this.dgvCust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCust_CellClick);
            this.dgvCust.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCust_CellMouseUp);
            this.dgvCust.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCust_RowsAdded);
            this.dgvCust.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvCust_RowsRemoved);
            // 
            // cNo
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cNo.DefaultCellStyle = dataGridViewCellStyle13;
            this.cNo.FillWeight = 60F;
            this.cNo.HeaderText = "序号";
            this.cNo.MinimumWidth = 6;
            this.cNo.Name = "cNo";
            this.cNo.ReadOnly = true;
            this.cNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cName
            // 
            this.cName.FillWeight = 150F;
            this.cName.HeaderText = "客户姓名";
            this.cName.MinimumWidth = 6;
            this.cName.Name = "cName";
            this.cName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "手机号码";
            this.cPhone.MinimumWidth = 6;
            this.cPhone.Name = "cPhone";
            this.cPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cCertType
            // 
            dataGridViewCellStyle14.NullValue = "身份证";
            this.cCertType.DefaultCellStyle = dataGridViewCellStyle14;
            this.cCertType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cCertType.HeaderText = "证件类型";
            this.cCertType.Items.AddRange(new object[] {
            "身份证",
            "军官证",
            "护照"});
            this.cCertType.MinimumWidth = 6;
            this.cCertType.Name = "cCertType";
            // 
            // cCertNum
            // 
            this.cCertNum.FillWeight = 150F;
            this.cCertNum.HeaderText = "证件号码";
            this.cCertNum.MinimumWidth = 6;
            this.cCertNum.Name = "cCertNum";
            this.cCertNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cAddress
            // 
            this.cAddress.FillWeight = 300F;
            this.cAddress.HeaderText = "地址";
            this.cAddress.MinimumWidth = 6;
            this.cAddress.Name = "cAddress";
            this.cAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cIsMember
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = "登记会员";
            this.cIsMember.DefaultCellStyle = dataGridViewCellStyle15;
            this.cIsMember.HeaderText = "是否会员";
            this.cIsMember.MinimumWidth = 6;
            this.cIsMember.Name = "cIsMember";
            // 
            // cSelectedRoomNo
            // 
            this.cSelectedRoomNo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cSelectedRoomNo.HeaderText = "房间编号";
            this.cSelectedRoomNo.Items.AddRange(new object[] {
            "",
            "0201"});
            this.cSelectedRoomNo.MinimumWidth = 6;
            this.cSelectedRoomNo.Name = "cSelectedRoomNo";
            this.cSelectedRoomNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cmsCust
            // 
            this.cmsCust.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCust.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustAdd});
            this.cmsCust.Name = "cmsCust";
            this.cmsCust.Size = new System.Drawing.Size(159, 28);
            // 
            // tsmiCustAdd
            // 
            this.tsmiCustAdd.Name = "tsmiCustAdd";
            this.tsmiCustAdd.Size = new System.Drawing.Size(158, 24);
            this.tsmiCustAdd.Text = "添加新客户";
            this.tsmiCustAdd.Click += new System.EventHandler(this.tsmiCustAdd_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Controls.Add(this.lblDepositVal);
            this.panel1.Controls.Add(this.lblDeposit);
            this.panel1.Controls.Add(this.lblDiscRateVal);
            this.panel1.Controls.Add(this.lblDiscRate);
            this.panel1.Controls.Add(this.lblRoomPriceVal);
            this.panel1.Controls.Add(this.lblRoomPrice);
            this.panel1.Controls.Add(this.lblRoomNumVal);
            this.panel1.Controls.Add(this.lblRoomNum);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 597);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 45);
            this.panel1.TabIndex = 21;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(5, 5);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(105, 35);
            this.btnAddRoom.TabIndex = 29;
            this.btnAddRoom.Text = "添加房间";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // lblDepositVal
            // 
            this.lblDepositVal.ForeColor = System.Drawing.Color.Red;
            this.lblDepositVal.Location = new System.Drawing.Point(844, 5);
            this.lblDepositVal.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblDepositVal.Name = "lblDepositVal";
            this.lblDepositVal.Size = new System.Drawing.Size(65, 35);
            this.lblDepositVal.TabIndex = 28;
            this.lblDepositVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeposit
            // 
            this.lblDeposit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeposit.Location = new System.Drawing.Point(754, 5);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(90, 35);
            this.lblDeposit.TabIndex = 27;
            this.lblDeposit.Text = "应付押金：";
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscRateVal
            // 
            this.lblDiscRateVal.Location = new System.Drawing.Point(684, 5);
            this.lblDiscRateVal.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblDiscRateVal.Name = "lblDiscRateVal";
            this.lblDiscRateVal.Size = new System.Drawing.Size(65, 35);
            this.lblDiscRateVal.TabIndex = 24;
            this.lblDiscRateVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscRate
            // 
            this.lblDiscRate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDiscRate.Location = new System.Drawing.Point(594, 5);
            this.lblDiscRate.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblDiscRate.Name = "lblDiscRate";
            this.lblDiscRate.Size = new System.Drawing.Size(90, 35);
            this.lblDiscRate.TabIndex = 23;
            this.lblDiscRate.Text = "折扣率：";
            this.lblDiscRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomPriceVal
            // 
            this.lblRoomPriceVal.Location = new System.Drawing.Point(524, 5);
            this.lblRoomPriceVal.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblRoomPriceVal.Name = "lblRoomPriceVal";
            this.lblRoomPriceVal.Size = new System.Drawing.Size(65, 35);
            this.lblRoomPriceVal.TabIndex = 22;
            this.lblRoomPriceVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomPrice.Location = new System.Drawing.Point(434, 5);
            this.lblRoomPrice.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(90, 35);
            this.lblRoomPrice.TabIndex = 21;
            this.lblRoomPrice.Text = "总房价：";
            this.lblRoomPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomNumVal
            // 
            this.lblRoomNumVal.Location = new System.Drawing.Point(364, 5);
            this.lblRoomNumVal.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblRoomNumVal.Name = "lblRoomNumVal";
            this.lblRoomNumVal.Size = new System.Drawing.Size(65, 35);
            this.lblRoomNumVal.TabIndex = 20;
            this.lblRoomNumVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomNum.Location = new System.Drawing.Point(274, 5);
            this.lblRoomNum.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(90, 35);
            this.lblRoomNum.TabIndex = 19;
            this.lblRoomNum.Text = "房间数目：";
            this.lblRoomNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1094, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(979, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 35);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmsCustCell
            // 
            this.cmsCustCell.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCustCell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustCellModify,
            this.toolStripSeparator1,
            this.tsmiCustCellAdd,
            this.tsmiCustCellRemove});
            this.cmsCustCell.Name = "cmsCustRow";
            this.cmsCustCell.Size = new System.Drawing.Size(159, 82);
            // 
            // tsmiCustCellModify
            // 
            this.tsmiCustCellModify.Name = "tsmiCustCellModify";
            this.tsmiCustCellModify.Size = new System.Drawing.Size(158, 24);
            this.tsmiCustCellModify.Text = "修改此项";
            this.tsmiCustCellModify.Click += new System.EventHandler(this.tsmiCustCellModify_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiCustCellAdd
            // 
            this.tsmiCustCellAdd.Name = "tsmiCustCellAdd";
            this.tsmiCustCellAdd.Size = new System.Drawing.Size(158, 24);
            this.tsmiCustCellAdd.Text = "添加新客户";
            this.tsmiCustCellAdd.Click += new System.EventHandler(this.tsmiCustRowAdd_Click);
            // 
            // tsmiCustCellRemove
            // 
            this.tsmiCustCellRemove.Name = "tsmiCustCellRemove";
            this.tsmiCustCellRemove.Size = new System.Drawing.Size(158, 24);
            this.tsmiCustCellRemove.Text = "删除此客户";
            this.tsmiCustCellRemove.Click += new System.EventHandler(this.tsmiCustRowRemove_Click);
            // 
            // FrmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1224, 652);
            this.Controls.Add(this.gbRoomInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbCustInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCheckIn";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入住登记";
            this.Load += new System.EventHandler(this.FrmCheckIn_Load);
            this.gbRoomInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.csmRoom.ResumeLayout(false);
            this.cmsRoomCell.ResumeLayout(false);
            this.gbCustInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            this.cmsCust.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.cmsCustCell.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbRoomInfo;
        private System.Windows.Forms.ContextMenuStrip cmsRoomCell;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomCellAdd;
        private System.Windows.Forms.GroupBox gbCustInfo;
        private System.Windows.Forms.DataGridView dgvCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewComboBoxColumn cCertType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCertNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddress;
        private System.Windows.Forms.DataGridViewButtonColumn cIsMember;
        private System.Windows.Forms.DataGridViewComboBoxColumn cSelectedRoomNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Label lblDepositVal;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblDiscRateVal;
        private System.Windows.Forms.Label lblDiscRate;
        private System.Windows.Forms.Label lblRoomPriceVal;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblRoomNumVal;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ContextMenuStrip cmsCust;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustAdd;
        private System.Windows.Forms.ContextMenuStrip cmsCustCell;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustCellAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustCellRemove;
        private System.Windows.Forms.ContextMenuStrip csmRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomCellRemove;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustCellModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomCellModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBedNum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cIsHourRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCheckInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLeaveTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCall;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCallTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiscPct;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoomPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRemarks;
    }
}