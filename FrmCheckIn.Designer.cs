namespace hotelmgr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCustInfo = new System.Windows.Forms.GroupBox();
            this.dgvCustInfo = new System.Windows.Forms.DataGridView();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCertType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cCertNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIsMember = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cSelectedRoomNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gbRoomInfo = new System.Windows.Forms.GroupBox();
            this.dgvRoomInfo = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.lblRoomNumVal = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblRoomPriceVal = new System.Windows.Forms.Label();
            this.lblDiscRate = new System.Windows.Forms.Label();
            this.lblDiscRateVal = new System.Windows.Forms.Label();
            this.lblDepositVal = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.cmsRoomInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRoomItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRoomRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.cRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbCustInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustInfo)).BeginInit();
            this.gbRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).BeginInit();
            this.cmsRoomInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustInfo
            // 
            this.gbCustInfo.Controls.Add(this.dgvCustInfo);
            this.gbCustInfo.Location = new System.Drawing.Point(10, 10);
            this.gbCustInfo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 5);
            this.gbCustInfo.Name = "gbCustInfo";
            this.gbCustInfo.Size = new System.Drawing.Size(1207, 233);
            this.gbCustInfo.TabIndex = 0;
            this.gbCustInfo.TabStop = false;
            this.gbCustInfo.Text = "客户信息";
            // 
            // dgvCustInfo
            // 
            this.dgvCustInfo.AllowUserToResizeColumns = false;
            this.dgvCustInfo.AllowUserToResizeRows = false;
            this.dgvCustInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCustInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustInfo.ColumnHeadersHeight = 29;
            this.dgvCustInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNo,
            this.cName,
            this.cPhone,
            this.cCertType,
            this.cCertNum,
            this.cAddress,
            this.cIsMember,
            this.cSelectedRoomNo});
            this.dgvCustInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustInfo.Location = new System.Drawing.Point(3, 21);
            this.dgvCustInfo.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.dgvCustInfo.Name = "dgvCustInfo";
            this.dgvCustInfo.RowHeadersWidth = 29;
            this.dgvCustInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustInfo.RowTemplate.Height = 27;
            this.dgvCustInfo.Size = new System.Drawing.Size(1201, 209);
            this.dgvCustInfo.TabIndex = 1;
            this.dgvCustInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustInfo_CellClick);
            this.dgvCustInfo.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCheckIn_RowsAdded);
            this.dgvCustInfo.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvCheckIn_RowsRemoved);
            // 
            // cNo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cNo.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.NullValue = "身份证";
            this.cCertType.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "登记会员";
            this.cIsMember.DefaultCellStyle = dataGridViewCellStyle4;
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
            // gbRoomInfo
            // 
            this.gbRoomInfo.Controls.Add(this.dgvRoomInfo);
            this.gbRoomInfo.Location = new System.Drawing.Point(10, 249);
            this.gbRoomInfo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 5);
            this.gbRoomInfo.Name = "gbRoomInfo";
            this.gbRoomInfo.Size = new System.Drawing.Size(1207, 344);
            this.gbRoomInfo.TabIndex = 6;
            this.gbRoomInfo.TabStop = false;
            this.gbRoomInfo.Text = "房间信息";
            // 
            // dgvRoomInfo
            // 
            this.dgvRoomInfo.AllowUserToAddRows = false;
            this.dgvRoomInfo.AllowUserToResizeColumns = false;
            this.dgvRoomInfo.AllowUserToResizeRows = false;
            this.dgvRoomInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRoomInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRoomInfo.ColumnHeadersHeight = 29;
            this.dgvRoomInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoomInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRoomNo,
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
            this.dgvRoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomInfo.Location = new System.Drawing.Point(3, 21);
            this.dgvRoomInfo.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.dgvRoomInfo.Name = "dgvRoomInfo";
            this.dgvRoomInfo.RowHeadersWidth = 29;
            this.dgvRoomInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRoomInfo.RowTemplate.Height = 27;
            this.dgvRoomInfo.Size = new System.Drawing.Size(1201, 320);
            this.dgvRoomInfo.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1105, 603);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(990, 603);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 35);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomNum.Location = new System.Drawing.Point(283, 603);
            this.lblRoomNum.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(90, 25);
            this.lblRoomNum.TabIndex = 8;
            this.lblRoomNum.Text = "房间数目：";
            this.lblRoomNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomNumVal
            // 
            this.lblRoomNumVal.Location = new System.Drawing.Point(373, 603);
            this.lblRoomNumVal.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblRoomNumVal.Name = "lblRoomNumVal";
            this.lblRoomNumVal.Size = new System.Drawing.Size(65, 25);
            this.lblRoomNumVal.TabIndex = 9;
            this.lblRoomNumVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomPrice.Location = new System.Drawing.Point(443, 603);
            this.lblRoomPrice.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(90, 25);
            this.lblRoomPrice.TabIndex = 10;
            this.lblRoomPrice.Text = "总房价：";
            this.lblRoomPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomPriceVal
            // 
            this.lblRoomPriceVal.Location = new System.Drawing.Point(533, 603);
            this.lblRoomPriceVal.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblRoomPriceVal.Name = "lblRoomPriceVal";
            this.lblRoomPriceVal.Size = new System.Drawing.Size(65, 25);
            this.lblRoomPriceVal.TabIndex = 11;
            this.lblRoomPriceVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscRate
            // 
            this.lblDiscRate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDiscRate.Location = new System.Drawing.Point(603, 603);
            this.lblDiscRate.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblDiscRate.Name = "lblDiscRate";
            this.lblDiscRate.Size = new System.Drawing.Size(90, 25);
            this.lblDiscRate.TabIndex = 12;
            this.lblDiscRate.Text = "折扣率：";
            this.lblDiscRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscRateVal
            // 
            this.lblDiscRateVal.Location = new System.Drawing.Point(693, 603);
            this.lblDiscRateVal.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblDiscRateVal.Name = "lblDiscRateVal";
            this.lblDiscRateVal.Size = new System.Drawing.Size(65, 25);
            this.lblDiscRateVal.TabIndex = 13;
            this.lblDiscRateVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepositVal
            // 
            this.lblDepositVal.ForeColor = System.Drawing.Color.Red;
            this.lblDepositVal.Location = new System.Drawing.Point(853, 603);
            this.lblDepositVal.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblDepositVal.Name = "lblDepositVal";
            this.lblDepositVal.Size = new System.Drawing.Size(65, 25);
            this.lblDepositVal.TabIndex = 17;
            this.lblDepositVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeposit
            // 
            this.lblDeposit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeposit.Location = new System.Drawing.Point(763, 603);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(90, 25);
            this.lblDeposit.TabIndex = 16;
            this.lblDeposit.Text = "应付押金：";
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmsRoomInfo
            // 
            this.cmsRoomInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoomInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomItemModify,
            this.toolStripSeparator1,
            this.tsmiRoomRemove});
            this.cmsRoomInfo.Name = "contextMenuStrip1";
            this.cmsRoomInfo.Size = new System.Drawing.Size(159, 58);
            // 
            // tsmiRoomItemModify
            // 
            this.tsmiRoomItemModify.Name = "tsmiRoomItemModify";
            this.tsmiRoomItemModify.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomItemModify.Text = "修改此项";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiRoomRemove
            // 
            this.tsmiRoomRemove.Name = "tsmiRoomRemove";
            this.tsmiRoomRemove.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomRemove.Text = "删除此房间";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(14, 603);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(105, 35);
            this.btnAddRoom.TabIndex = 18;
            this.btnAddRoom.Text = "添加房间";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            // 
            // cRoomNo
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cRoomNo.DefaultCellStyle = dataGridViewCellStyle6;
            this.cRoomNo.FillWeight = 60F;
            this.cRoomNo.HeaderText = "房间编号";
            this.cRoomNo.MinimumWidth = 6;
            this.cRoomNo.Name = "cRoomNo";
            this.cRoomNo.ReadOnly = true;
            this.cRoomNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cIsHourRoom
            // 
            this.cIsHourRoom.FillWeight = 80F;
            this.cIsHourRoom.HeaderText = "是否钟点房";
            this.cIsHourRoom.MinimumWidth = 6;
            this.cIsHourRoom.Name = "cIsHourRoom";
            // 
            // cHours
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cHours.DefaultCellStyle = dataGridViewCellStyle7;
            this.cHours.FillWeight = 80F;
            this.cHours.HeaderText = "钟点房时长";
            this.cHours.MinimumWidth = 6;
            this.cHours.Name = "cHours";
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
            this.cCall.FillWeight = 60F;
            this.cCall.HeaderText = "叫早服务";
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cRoomPrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.cRoomPrice.FillWeight = 60F;
            this.cRoomPrice.HeaderText = "房间价格";
            this.cRoomPrice.MinimumWidth = 6;
            this.cRoomPrice.Name = "cRoomPrice";
            this.cRoomPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cDiscPct
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cDiscPct.DefaultCellStyle = dataGridViewCellStyle9;
            this.cDiscPct.FillWeight = 60F;
            this.cDiscPct.HeaderText = "折扣率";
            this.cDiscPct.MinimumWidth = 6;
            this.cDiscPct.Name = "cDiscPct";
            this.cDiscPct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRoomPay
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cRoomPay.DefaultCellStyle = dataGridViewCellStyle10;
            this.cRoomPay.FillWeight = 60F;
            this.cRoomPay.HeaderText = "应收押金";
            this.cRoomPay.MinimumWidth = 6;
            this.cRoomPay.Name = "cRoomPay";
            this.cRoomPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRemarks
            // 
            this.cRemarks.HeaderText = "备注";
            this.cRemarks.MinimumWidth = 6;
            this.cRemarks.Name = "cRemarks";
            this.cRemarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1224, 652);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.lblDepositVal);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblDiscRateVal);
            this.Controls.Add(this.lblDiscRate);
            this.Controls.Add(this.lblRoomPriceVal);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.lblRoomNumVal);
            this.Controls.Add(this.lblRoomNum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbRoomInfo);
            this.Controls.Add(this.gbCustInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCheckIn";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入住登记";
            this.Load += new System.EventHandler(this.FrmCheckIn_Load);
            this.gbCustInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustInfo)).EndInit();
            this.gbRoomInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).EndInit();
            this.cmsRoomInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCustInfo;
        private System.Windows.Forms.DataGridView dgvCustInfo;
        private System.Windows.Forms.GroupBox gbRoomInfo;
        private System.Windows.Forms.DataGridView dgvRoomInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.Label lblRoomNumVal;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblRoomPriceVal;
        private System.Windows.Forms.Label lblDiscRate;
        private System.Windows.Forms.Label lblDiscRateVal;
        private System.Windows.Forms.Label lblDepositVal;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.ContextMenuStrip cmsRoomInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomItemModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewComboBoxColumn cCertType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCertNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddress;
        private System.Windows.Forms.DataGridViewButtonColumn cIsMember;
        private System.Windows.Forms.DataGridViewComboBoxColumn cSelectedRoomNo;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoomNo;
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