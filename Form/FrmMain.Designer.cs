namespace hotelmgt
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tsState = new System.Windows.Forms.StatusStrip();
            this.tsslState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpReserve = new System.Windows.Forms.TabPage();
            this.dgvReserve = new System.Windows.Forms.DataGridView();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCustoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCustoPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cArriveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLeaveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cReserveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cReserveState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsReserveAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNewReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.pReserveInfoSelector = new System.Windows.Forms.Panel();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tpRoom = new System.Windows.Forms.TabPage();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsRoomState = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiManageRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.pRoomInfo = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pRoomInfoSelector = new System.Windows.Forms.Panel();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbRoomNo = new System.Windows.Forms.TextBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.cbRoomState = new System.Windows.Forms.ComboBox();
            this.lblRoomState = new System.Windows.Forms.Label();
            this.cbFloorNo = new System.Windows.Forms.ComboBox();
            this.lblFloorNo = new System.Windows.Forms.Label();
            this.cbBuildingNo = new System.Windows.Forms.ComboBox();
            this.lblBuildingNo = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmsRoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetRoomState = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomStateEmpty = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomStateReserved = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomCheckedIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomStateRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomStateClean = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomStateRetained = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tsbReserve = new System.Windows.Forms.ToolStripButton();
            this.tsbCheckIn = new System.Windows.Forms.ToolStripButton();
            this.tsbMember = new System.Windows.Forms.ToolStripButton();
            this.tsbTicket = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRoomMgt = new System.Windows.Forms.ToolStripButton();
            this.tsbBFMgt = new System.Windows.Forms.ToolStripButton();
            this.tsbStaffMgt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSwitchUser = new System.Windows.Forms.ToolStripButton();
            this.tsbLockSystem = new System.Windows.Forms.ToolStripButton();
            this.tsbExitSystem = new System.Windows.Forms.ToolStripButton();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbCheckOut = new System.Windows.Forms.ToolStripButton();
            this.tsbMemberMgt = new System.Windows.Forms.ToolStripButton();
            this.tsbSystemSettings = new System.Windows.Forms.ToolStripButton();
            this.cmsReserveMgt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReserveAppend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReserveModiify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReserveCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReserveCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsState.SuspendLayout();
            this.tpReserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserve)).BeginInit();
            this.cmsReserveAdd.SuspendLayout();
            this.pReserveInfoSelector.SuspendLayout();
            this.tpRoom.SuspendLayout();
            this.cmsRoomState.SuspendLayout();
            this.pRoomInfo.SuspendLayout();
            this.pRoomInfoSelector.SuspendLayout();
            this.cmsRoom.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.cmsReserveMgt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsState
            // 
            this.tsState.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tsState.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslState});
            this.tsState.Location = new System.Drawing.Point(0, 594);
            this.tsState.Name = "tsState";
            this.tsState.Size = new System.Drawing.Size(1335, 26);
            this.tsState.TabIndex = 0;
            this.tsState.Text = "statusStrip1";
            // 
            // tsslState
            // 
            this.tsslState.AutoSize = false;
            this.tsslState.Name = "tsslState";
            this.tsslState.Size = new System.Drawing.Size(60, 20);
            this.tsslState.Text = "状态";
            // 
            // tpReserve
            // 
            this.tpReserve.Controls.Add(this.dgvReserve);
            this.tpReserve.Controls.Add(this.pReserveInfoSelector);
            this.tpReserve.Location = new System.Drawing.Point(4, 34);
            this.tpReserve.Name = "tpReserve";
            this.tpReserve.Size = new System.Drawing.Size(1327, 472);
            this.tpReserve.TabIndex = 5;
            this.tpReserve.Text = "预订管理";
            this.tpReserve.UseVisualStyleBackColor = true;
            // 
            // dgvReserve
            // 
            this.dgvReserve.AllowUserToAddRows = false;
            this.dgvReserve.AllowUserToDeleteRows = false;
            this.dgvReserve.AllowUserToResizeColumns = false;
            this.dgvReserve.AllowUserToResizeRows = false;
            this.dgvReserve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReserve.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReserve.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReserve.ColumnHeadersHeight = 29;
            this.dgvReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReserve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNo,
            this.cCustoName,
            this.cCustoPhone,
            this.cRoomType,
            this.cArriveTime,
            this.cLeaveTime,
            this.cReserveTime,
            this.cReserveState,
            this.cRemarks});
            this.dgvReserve.ContextMenuStrip = this.cmsReserveAdd;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserve.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReserve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReserve.Location = new System.Drawing.Point(0, 55);
            this.dgvReserve.MultiSelect = false;
            this.dgvReserve.Name = "dgvReserve";
            this.dgvReserve.ReadOnly = true;
            this.dgvReserve.RowHeadersWidth = 29;
            this.dgvReserve.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReserve.RowTemplate.Height = 27;
            this.dgvReserve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReserve.Size = new System.Drawing.Size(1327, 417);
            this.dgvReserve.TabIndex = 0;
            this.dgvReserve.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvReserve_RowsAdded);
            // 
            // cNo
            // 
            this.cNo.FillWeight = 60F;
            this.cNo.HeaderText = "序号";
            this.cNo.MinimumWidth = 6;
            this.cNo.Name = "cNo";
            this.cNo.ReadOnly = true;
            this.cNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cCustoName
            // 
            this.cCustoName.HeaderText = "客户姓名";
            this.cCustoName.MinimumWidth = 6;
            this.cCustoName.Name = "cCustoName";
            this.cCustoName.ReadOnly = true;
            this.cCustoName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cCustoPhone
            // 
            this.cCustoPhone.HeaderText = "手机号码";
            this.cCustoPhone.MinimumWidth = 6;
            this.cCustoPhone.Name = "cCustoPhone";
            this.cCustoPhone.ReadOnly = true;
            this.cCustoPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRoomType
            // 
            this.cRoomType.HeaderText = "房间编号";
            this.cRoomType.MinimumWidth = 6;
            this.cRoomType.Name = "cRoomType";
            this.cRoomType.ReadOnly = true;
            this.cRoomType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cArriveTime
            // 
            this.cArriveTime.HeaderText = "预达时间";
            this.cArriveTime.MinimumWidth = 6;
            this.cArriveTime.Name = "cArriveTime";
            this.cArriveTime.ReadOnly = true;
            this.cArriveTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cLeaveTime
            // 
            this.cLeaveTime.HeaderText = "预离时间";
            this.cLeaveTime.MinimumWidth = 6;
            this.cLeaveTime.Name = "cLeaveTime";
            this.cLeaveTime.ReadOnly = true;
            this.cLeaveTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cReserveTime
            // 
            this.cReserveTime.HeaderText = "预订时间";
            this.cReserveTime.MinimumWidth = 6;
            this.cReserveTime.Name = "cReserveTime";
            this.cReserveTime.ReadOnly = true;
            this.cReserveTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cReserveState
            // 
            this.cReserveState.FillWeight = 150F;
            this.cReserveState.HeaderText = "预订状态";
            this.cReserveState.MinimumWidth = 6;
            this.cReserveState.Name = "cReserveState";
            this.cReserveState.ReadOnly = true;
            this.cReserveState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRemarks
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cRemarks.DefaultCellStyle = dataGridViewCellStyle5;
            this.cRemarks.FillWeight = 150F;
            this.cRemarks.HeaderText = "备注";
            this.cRemarks.MinimumWidth = 6;
            this.cRemarks.Name = "cRemarks";
            this.cRemarks.ReadOnly = true;
            this.cRemarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmsReserveAdd
            // 
            this.cmsReserveAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsReserveAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewReservation});
            this.cmsReserveAdd.Name = "cmsReserve";
            this.cmsReserveAdd.Size = new System.Drawing.Size(143, 28);
            this.cmsReserveAdd.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsReserve_ItemClicked);
            // 
            // tsmiNewReservation
            // 
            this.tsmiNewReservation.Name = "tsmiNewReservation";
            this.tsmiNewReservation.Size = new System.Drawing.Size(142, 24);
            this.tsmiNewReservation.Text = "新增预订";
            // 
            // pReserveInfoSelector
            // 
            this.pReserveInfoSelector.AutoSize = true;
            this.pReserveInfoSelector.Controls.Add(this.btnReserve);
            this.pReserveInfoSelector.Controls.Add(this.btnOK);
            this.pReserveInfoSelector.Controls.Add(this.tbPhone);
            this.pReserveInfoSelector.Controls.Add(this.lblPhone);
            this.pReserveInfoSelector.Controls.Add(this.tbName);
            this.pReserveInfoSelector.Controls.Add(this.label16);
            this.pReserveInfoSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.pReserveInfoSelector.Location = new System.Drawing.Point(0, 0);
            this.pReserveInfoSelector.Name = "pReserveInfoSelector";
            this.pReserveInfoSelector.Padding = new System.Windows.Forms.Padding(10);
            this.pReserveInfoSelector.Size = new System.Drawing.Size(1327, 55);
            this.pReserveInfoSelector.TabIndex = 25;
            // 
            // btnReserve
            // 
            this.btnReserve.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReserve.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReserve.Location = new System.Drawing.Point(1207, 10);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(105, 35);
            this.btnReserve.TabIndex = 11;
            this.btnReserve.Text = "新增预订";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOK.Location = new System.Drawing.Point(515, 10);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 35);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "查找";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // tbPhone
            // 
            this.tbPhone.HideSelection = false;
            this.tbPhone.Location = new System.Drawing.Point(350, 15);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(150, 25);
            this.tbPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(265, 15);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(85, 25);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "手机号码：";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.HideSelection = false;
            this.tbName.Location = new System.Drawing.Point(100, 15);
            this.tbName.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 25);
            this.tbName.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(15, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 25);
            this.label16.TabIndex = 4;
            this.label16.Text = "客户姓名：";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpRoom
            // 
            this.tpRoom.Controls.Add(this.flpRoom);
            this.tpRoom.Controls.Add(this.pRoomInfo);
            this.tpRoom.Controls.Add(this.pRoomInfoSelector);
            this.tpRoom.Location = new System.Drawing.Point(4, 34);
            this.tpRoom.Name = "tpRoom";
            this.tpRoom.Size = new System.Drawing.Size(1327, 472);
            this.tpRoom.TabIndex = 6;
            this.tpRoom.Text = "客房状态";
            this.tpRoom.UseVisualStyleBackColor = true;
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpRoom.ContextMenuStrip = this.cmsRoomState;
            this.flpRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRoom.Location = new System.Drawing.Point(0, 55);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Padding = new System.Windows.Forms.Padding(3);
            this.flpRoom.Size = new System.Drawing.Size(1027, 417);
            this.flpRoom.TabIndex = 0;
            // 
            // cmsRoomState
            // 
            this.cmsRoomState.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoomState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageRoom});
            this.cmsRoomState.Name = "cmsRoomState";
            this.cmsRoomState.Size = new System.Drawing.Size(143, 28);
            // 
            // tsmiManageRoom
            // 
            this.tsmiManageRoom.Name = "tsmiManageRoom";
            this.tsmiManageRoom.Size = new System.Drawing.Size(142, 24);
            this.tsmiManageRoom.Text = "管理客房";
            // 
            // pRoomInfo
            // 
            this.pRoomInfo.AutoScroll = true;
            this.pRoomInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRoomInfo.Controls.Add(this.label14);
            this.pRoomInfo.Controls.Add(this.label15);
            this.pRoomInfo.Controls.Add(this.label12);
            this.pRoomInfo.Controls.Add(this.label13);
            this.pRoomInfo.Controls.Add(this.label10);
            this.pRoomInfo.Controls.Add(this.label11);
            this.pRoomInfo.Controls.Add(this.label8);
            this.pRoomInfo.Controls.Add(this.label9);
            this.pRoomInfo.Controls.Add(this.label6);
            this.pRoomInfo.Controls.Add(this.label7);
            this.pRoomInfo.Controls.Add(this.label4);
            this.pRoomInfo.Controls.Add(this.label5);
            this.pRoomInfo.Controls.Add(this.label2);
            this.pRoomInfo.Controls.Add(this.label3);
            this.pRoomInfo.Controls.Add(this.label1);
            this.pRoomInfo.Controls.Add(this.lblName);
            this.pRoomInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRoomInfo.Location = new System.Drawing.Point(1027, 55);
            this.pRoomInfo.Name = "pRoomInfo";
            this.pRoomInfo.Size = new System.Drawing.Size(300, 417);
            this.pRoomInfo.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(102, 262);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 25);
            this.label14.TabIndex = 17;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(17, 262);
            this.label15.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "备注信息：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(102, 227);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 25);
            this.label12.TabIndex = 15;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(17, 227);
            this.label13.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "客房状态：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(102, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 13;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(17, 192);
            this.label11.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "员工编号：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(102, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 11;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(17, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "床位数：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(102, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 9;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(17, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "楼层号：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(102, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 7;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "楼栋号：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(102, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "客房类型：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(102, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 15, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(17, 17);
            this.lblName.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "客房编号：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pRoomInfoSelector
            // 
            this.pRoomInfoSelector.AutoSize = true;
            this.pRoomInfoSelector.Controls.Add(this.tbCustName);
            this.pRoomInfoSelector.Controls.Add(this.lblCustName);
            this.pRoomInfoSelector.Controls.Add(this.btnSearch);
            this.pRoomInfoSelector.Controls.Add(this.tbRoomNo);
            this.pRoomInfoSelector.Controls.Add(this.lblRoomNo);
            this.pRoomInfoSelector.Controls.Add(this.cbRoomState);
            this.pRoomInfoSelector.Controls.Add(this.lblRoomState);
            this.pRoomInfoSelector.Controls.Add(this.cbFloorNo);
            this.pRoomInfoSelector.Controls.Add(this.lblFloorNo);
            this.pRoomInfoSelector.Controls.Add(this.cbBuildingNo);
            this.pRoomInfoSelector.Controls.Add(this.lblBuildingNo);
            this.pRoomInfoSelector.Controls.Add(this.cbRoomType);
            this.pRoomInfoSelector.Controls.Add(this.lblRoomType);
            this.pRoomInfoSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRoomInfoSelector.Location = new System.Drawing.Point(0, 0);
            this.pRoomInfoSelector.Name = "pRoomInfoSelector";
            this.pRoomInfoSelector.Padding = new System.Windows.Forms.Padding(10);
            this.pRoomInfoSelector.Size = new System.Drawing.Size(1327, 55);
            this.pRoomInfoSelector.TabIndex = 24;
            // 
            // tbCustName
            // 
            this.tbCustName.HideSelection = false;
            this.tbCustName.Location = new System.Drawing.Point(1057, 15);
            this.tbCustName.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(120, 25);
            this.tbCustName.TabIndex = 35;
            // 
            // lblCustName
            // 
            this.lblCustName.Location = new System.Drawing.Point(972, 15);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(85, 25);
            this.lblCustName.TabIndex = 34;
            this.lblCustName.Text = "客户姓名：";
            this.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1192, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 35);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbRoomNo
            // 
            this.tbRoomNo.HideSelection = false;
            this.tbRoomNo.Location = new System.Drawing.Point(872, 15);
            this.tbRoomNo.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.tbRoomNo.Name = "tbRoomNo";
            this.tbRoomNo.Size = new System.Drawing.Size(85, 25);
            this.tbRoomNo.TabIndex = 32;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.Location = new System.Drawing.Point(785, 15);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(85, 25);
            this.lblRoomNo.TabIndex = 31;
            this.lblRoomNo.Text = "房间编号：";
            this.lblRoomNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRoomState
            // 
            this.cbRoomState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomState.Items.AddRange(new object[] {
            "全部",
            "空房",
            "已预订",
            "已入住",
            "等待维修",
            "等待清洁",
            "保留"});
            this.cbRoomState.Location = new System.Drawing.Point(635, 15);
            this.cbRoomState.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.cbRoomState.Name = "cbRoomState";
            this.cbRoomState.Size = new System.Drawing.Size(135, 23);
            this.cbRoomState.TabIndex = 30;
            // 
            // lblRoomState
            // 
            this.lblRoomState.Location = new System.Drawing.Point(550, 15);
            this.lblRoomState.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblRoomState.Name = "lblRoomState";
            this.lblRoomState.Size = new System.Drawing.Size(85, 25);
            this.lblRoomState.TabIndex = 29;
            this.lblRoomState.Text = "房间状态：";
            this.lblRoomState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFloorNo
            // 
            this.cbFloorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFloorNo.Items.AddRange(new object[] {
            "全部",
            "1",
            "2"});
            this.cbFloorNo.Location = new System.Drawing.Point(470, 15);
            this.cbFloorNo.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.cbFloorNo.Name = "cbFloorNo";
            this.cbFloorNo.Size = new System.Drawing.Size(65, 23);
            this.cbFloorNo.TabIndex = 28;
            // 
            // lblFloorNo
            // 
            this.lblFloorNo.Location = new System.Drawing.Point(400, 15);
            this.lblFloorNo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblFloorNo.Name = "lblFloorNo";
            this.lblFloorNo.Size = new System.Drawing.Size(70, 25);
            this.lblFloorNo.TabIndex = 27;
            this.lblFloorNo.Text = "楼层号：";
            this.lblFloorNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBuildingNo
            // 
            this.cbBuildingNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuildingNo.Items.AddRange(new object[] {
            "全部",
            "1"});
            this.cbBuildingNo.Location = new System.Drawing.Point(320, 15);
            this.cbBuildingNo.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.cbBuildingNo.Name = "cbBuildingNo";
            this.cbBuildingNo.Size = new System.Drawing.Size(65, 23);
            this.cbBuildingNo.TabIndex = 26;
            // 
            // lblBuildingNo
            // 
            this.lblBuildingNo.Location = new System.Drawing.Point(250, 15);
            this.lblBuildingNo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblBuildingNo.Name = "lblBuildingNo";
            this.lblBuildingNo.Size = new System.Drawing.Size(70, 25);
            this.lblBuildingNo.TabIndex = 25;
            this.lblBuildingNo.Text = "楼栋号：";
            this.lblBuildingNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cbRoomType.Location = new System.Drawing.Point(100, 15);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(135, 23);
            this.cbRoomType.TabIndex = 24;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Location = new System.Drawing.Point(15, 15);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(85, 25);
            this.lblRoomType.TabIndex = 23;
            this.lblRoomType.Text = "房间类型：";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmsRoom
            // 
            this.cmsRoom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReserve,
            this.tsmiCheckIn,
            this.tsmiCheckOut,
            this.tss1,
            this.tsmiManage,
            this.tsmiSetRoomState});
            this.cmsRoom.Name = "cmsRoom";
            this.cmsRoom.Size = new System.Drawing.Size(143, 130);
            this.cmsRoom.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsRoom_ItemClicked);
            // 
            // tsmiReserve
            // 
            this.tsmiReserve.Name = "tsmiReserve";
            this.tsmiReserve.Size = new System.Drawing.Size(142, 24);
            this.tsmiReserve.Text = "预订此房";
            // 
            // tsmiCheckIn
            // 
            this.tsmiCheckIn.Name = "tsmiCheckIn";
            this.tsmiCheckIn.Size = new System.Drawing.Size(142, 24);
            this.tsmiCheckIn.Text = "登记入住";
            // 
            // tsmiCheckOut
            // 
            this.tsmiCheckOut.Name = "tsmiCheckOut";
            this.tsmiCheckOut.Size = new System.Drawing.Size(142, 24);
            this.tsmiCheckOut.Text = "结账退房";
            this.tsmiCheckOut.Click += new System.EventHandler(this.tsmiCheckOut_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(139, 6);
            // 
            // tsmiManage
            // 
            this.tsmiManage.Name = "tsmiManage";
            this.tsmiManage.Size = new System.Drawing.Size(142, 24);
            this.tsmiManage.Text = "管理客房";
            // 
            // tsmiSetRoomState
            // 
            this.tsmiSetRoomState.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomStateEmpty,
            this.tsmiRoomStateReserved,
            this.tsmiRoomCheckedIn,
            this.tsmiRoomStateRepair,
            this.tsmiRoomStateClean,
            this.tsmiRoomStateRetained});
            this.tsmiSetRoomState.Name = "tsmiSetRoomState";
            this.tsmiSetRoomState.Size = new System.Drawing.Size(142, 24);
            this.tsmiSetRoomState.Text = "置状态为";
            // 
            // tsmiRoomStateEmpty
            // 
            this.tsmiRoomStateEmpty.Name = "tsmiRoomStateEmpty";
            this.tsmiRoomStateEmpty.Size = new System.Drawing.Size(156, 26);
            this.tsmiRoomStateEmpty.Text = "空房";
            // 
            // tsmiRoomStateReserved
            // 
            this.tsmiRoomStateReserved.Name = "tsmiRoomStateReserved";
            this.tsmiRoomStateReserved.Size = new System.Drawing.Size(156, 26);
            this.tsmiRoomStateReserved.Text = "已预订";
            // 
            // tsmiRoomCheckedIn
            // 
            this.tsmiRoomCheckedIn.Name = "tsmiRoomCheckedIn";
            this.tsmiRoomCheckedIn.Size = new System.Drawing.Size(156, 26);
            this.tsmiRoomCheckedIn.Text = "已入住";
            // 
            // tsmiRoomStateRepair
            // 
            this.tsmiRoomStateRepair.Name = "tsmiRoomStateRepair";
            this.tsmiRoomStateRepair.Size = new System.Drawing.Size(156, 26);
            this.tsmiRoomStateRepair.Text = "等待维修";
            // 
            // tsmiRoomStateClean
            // 
            this.tsmiRoomStateClean.Name = "tsmiRoomStateClean";
            this.tsmiRoomStateClean.Size = new System.Drawing.Size(156, 26);
            this.tsmiRoomStateClean.Text = "等待清洁";
            // 
            // tsmiRoomStateRetained
            // 
            this.tsmiRoomStateRetained.Name = "tsmiRoomStateRetained";
            this.tsmiRoomStateRetained.Size = new System.Drawing.Size(156, 26);
            this.tsmiRoomStateRetained.Text = "保留";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpRoom);
            this.tcMain.Controls.Add(this.tpReserve);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.ItemSize = new System.Drawing.Size(120, 30);
            this.tcMain.Location = new System.Drawing.Point(0, 84);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1335, 510);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMain.TabIndex = 3;
            // 
            // tsbReserve
            // 
            this.tsbReserve.AutoSize = false;
            this.tsbReserve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReserve.Image = ((System.Drawing.Image)(resources.GetObject("tsbReserve.Image")));
            this.tsbReserve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReserve.Name = "tsbReserve";
            this.tsbReserve.Size = new System.Drawing.Size(80, 80);
            this.tsbReserve.Text = "新增预订";
            this.tsbReserve.Click += new System.EventHandler(this.tsbReserve_Click);
            // 
            // tsbCheckIn
            // 
            this.tsbCheckIn.AutoSize = false;
            this.tsbCheckIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbCheckIn.Image")));
            this.tsbCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckIn.Name = "tsbCheckIn";
            this.tsbCheckIn.Size = new System.Drawing.Size(80, 80);
            this.tsbCheckIn.Text = "入住登记";
            this.tsbCheckIn.Click += new System.EventHandler(this.tsbCheckIn_Click);
            // 
            // tsbMember
            // 
            this.tsbMember.AutoSize = false;
            this.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMember.Image = ((System.Drawing.Image)(resources.GetObject("tsbMember.Image")));
            this.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMember.Name = "tsbMember";
            this.tsbMember.Size = new System.Drawing.Size(80, 80);
            this.tsbMember.Text = "会员登记";
            this.tsbMember.Click += new System.EventHandler(this.tsbMemberAdd_Click);
            // 
            // tsbTicket
            // 
            this.tsbTicket.AutoSize = false;
            this.tsbTicket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTicket.Image = ((System.Drawing.Image)(resources.GetObject("tsbTicket.Image")));
            this.tsbTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTicket.Name = "tsbTicket";
            this.tsbTicket.Size = new System.Drawing.Size(80, 80);
            this.tsbTicket.Text = "早餐票";
            this.tsbTicket.Click += new System.EventHandler(this.tsbTicket_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 83);
            // 
            // tsbRoomMgt
            // 
            this.tsbRoomMgt.AutoSize = false;
            this.tsbRoomMgt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRoomMgt.Image = ((System.Drawing.Image)(resources.GetObject("tsbRoomMgt.Image")));
            this.tsbRoomMgt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRoomMgt.Name = "tsbRoomMgt";
            this.tsbRoomMgt.Size = new System.Drawing.Size(80, 80);
            this.tsbRoomMgt.Text = "客房管理";
            this.tsbRoomMgt.Click += new System.EventHandler(this.tsbRoomMgt_Click);
            // 
            // tsbBFMgt
            // 
            this.tsbBFMgt.AutoSize = false;
            this.tsbBFMgt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBFMgt.Image = ((System.Drawing.Image)(resources.GetObject("tsbBFMgt.Image")));
            this.tsbBFMgt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBFMgt.Name = "tsbBFMgt";
            this.tsbBFMgt.Size = new System.Drawing.Size(80, 80);
            this.tsbBFMgt.Text = "餐费管理";
            this.tsbBFMgt.Click += new System.EventHandler(this.tsbTicketMgt_Click);
            // 
            // tsbStaffMgt
            // 
            this.tsbStaffMgt.AutoSize = false;
            this.tsbStaffMgt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStaffMgt.Image = ((System.Drawing.Image)(resources.GetObject("tsbStaffMgt.Image")));
            this.tsbStaffMgt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStaffMgt.Name = "tsbStaffMgt";
            this.tsbStaffMgt.Size = new System.Drawing.Size(80, 80);
            this.tsbStaffMgt.Text = "员工管理";
            this.tsbStaffMgt.Click += new System.EventHandler(this.tsbStaffMgt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 83);
            // 
            // tsbSwitchUser
            // 
            this.tsbSwitchUser.AutoSize = false;
            this.tsbSwitchUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSwitchUser.Image = ((System.Drawing.Image)(resources.GetObject("tsbSwitchUser.Image")));
            this.tsbSwitchUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSwitchUser.Name = "tsbSwitchUser";
            this.tsbSwitchUser.Size = new System.Drawing.Size(80, 80);
            this.tsbSwitchUser.Text = "切换用户";
            this.tsbSwitchUser.Click += new System.EventHandler(this.tsbSwitchUser_Click);
            // 
            // tsbLockSystem
            // 
            this.tsbLockSystem.AutoSize = false;
            this.tsbLockSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLockSystem.Image = ((System.Drawing.Image)(resources.GetObject("tsbLockSystem.Image")));
            this.tsbLockSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLockSystem.Name = "tsbLockSystem";
            this.tsbLockSystem.Size = new System.Drawing.Size(80, 80);
            this.tsbLockSystem.Text = "锁定系统";
            this.tsbLockSystem.Click += new System.EventHandler(this.tsbLockSystem_Click);
            // 
            // tsbExitSystem
            // 
            this.tsbExitSystem.AutoSize = false;
            this.tsbExitSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExitSystem.Image = ((System.Drawing.Image)(resources.GetObject("tsbExitSystem.Image")));
            this.tsbExitSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExitSystem.Name = "tsbExitSystem";
            this.tsbExitSystem.Size = new System.Drawing.Size(80, 80);
            this.tsbExitSystem.Text = "退出系统";
            this.tsbExitSystem.Click += new System.EventHandler(this.tsbExitSystem_Click);
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReserve,
            this.tsbCheckIn,
            this.tsbMember,
            this.tsbTicket,
            this.tsbCheckOut,
            this.toolStripSeparator1,
            this.tsbRoomMgt,
            this.tsbMemberMgt,
            this.tsbBFMgt,
            this.tsbStaffMgt,
            this.toolStripSeparator2,
            this.tsbSwitchUser,
            this.tsbSystemSettings,
            this.tsbLockSystem,
            this.tsbExitSystem});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.tsMain.Size = new System.Drawing.Size(1335, 84);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "tsMain";
            // 
            // tsbCheckOut
            // 
            this.tsbCheckOut.AutoSize = false;
            this.tsbCheckOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbCheckOut.Image")));
            this.tsbCheckOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckOut.Name = "tsbCheckOut";
            this.tsbCheckOut.Size = new System.Drawing.Size(80, 80);
            this.tsbCheckOut.Text = "退房结账";
            this.tsbCheckOut.Click += new System.EventHandler(this.tsbCheckOut_Click);
            // 
            // tsbMemberMgt
            // 
            this.tsbMemberMgt.AutoSize = false;
            this.tsbMemberMgt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMemberMgt.Image = ((System.Drawing.Image)(resources.GetObject("tsbMemberMgt.Image")));
            this.tsbMemberMgt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMemberMgt.Name = "tsbMemberMgt";
            this.tsbMemberMgt.Size = new System.Drawing.Size(80, 80);
            this.tsbMemberMgt.Text = "会员管理";
            this.tsbMemberMgt.Click += new System.EventHandler(this.tsbMemberMgt_Click);
            // 
            // tsbSystemSettings
            // 
            this.tsbSystemSettings.AutoSize = false;
            this.tsbSystemSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSystemSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsbSystemSettings.Image")));
            this.tsbSystemSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSystemSettings.Name = "tsbSystemSettings";
            this.tsbSystemSettings.Size = new System.Drawing.Size(80, 80);
            this.tsbSystemSettings.Text = "系统设置";
            this.tsbSystemSettings.Click += new System.EventHandler(this.tsbSystemSettings_Click);
            // 
            // cmsReserveMgt
            // 
            this.cmsReserveMgt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsReserveMgt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReserveAppend,
            this.tsmiReserveModiify,
            this.tsmiReserveCancel,
            this.toolStripSeparator3,
            this.tsmiReserveCheckIn});
            this.cmsReserveMgt.Name = "cmsReserveMgr";
            this.cmsReserveMgt.Size = new System.Drawing.Size(143, 106);
            // 
            // tsmiReserveAppend
            // 
            this.tsmiReserveAppend.Name = "tsmiReserveAppend";
            this.tsmiReserveAppend.Size = new System.Drawing.Size(142, 24);
            this.tsmiReserveAppend.Text = "新增预订";
            this.tsmiReserveAppend.Click += new System.EventHandler(this.tsmiReserveAppend_Click);
            // 
            // tsmiReserveModiify
            // 
            this.tsmiReserveModiify.Name = "tsmiReserveModiify";
            this.tsmiReserveModiify.Size = new System.Drawing.Size(142, 24);
            this.tsmiReserveModiify.Text = "修改预订";
            this.tsmiReserveModiify.Click += new System.EventHandler(this.tsmiReserveModiify_Click);
            // 
            // tsmiReserveCancel
            // 
            this.tsmiReserveCancel.Name = "tsmiReserveCancel";
            this.tsmiReserveCancel.Size = new System.Drawing.Size(142, 24);
            this.tsmiReserveCancel.Text = "取消预订";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(139, 6);
            // 
            // tsmiReserveCheckIn
            // 
            this.tsmiReserveCheckIn.Name = "tsmiReserveCheckIn";
            this.tsmiReserveCheckIn.Size = new System.Drawing.Size(142, 24);
            this.tsmiReserveCheckIn.Text = "入住登记";
            this.tsmiReserveCheckIn.Click += new System.EventHandler(this.tsmiReserveCheckIn_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1335, 620);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.tsState);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "客房管理信息系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tsState.ResumeLayout(false);
            this.tsState.PerformLayout();
            this.tpReserve.ResumeLayout(false);
            this.tpReserve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserve)).EndInit();
            this.cmsReserveAdd.ResumeLayout(false);
            this.pReserveInfoSelector.ResumeLayout(false);
            this.pReserveInfoSelector.PerformLayout();
            this.tpRoom.ResumeLayout(false);
            this.tpRoom.PerformLayout();
            this.cmsRoomState.ResumeLayout(false);
            this.pRoomInfo.ResumeLayout(false);
            this.pRoomInfoSelector.ResumeLayout(false);
            this.pRoomInfoSelector.PerformLayout();
            this.cmsRoom.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.cmsReserveMgt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip tsState;
        private System.Windows.Forms.ToolStripStatusLabel tsslState;
        private System.Windows.Forms.TabPage tpReserve;
        private System.Windows.Forms.TabPage tpRoom;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.ContextMenuStrip cmsRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserve;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckOut;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripMenuItem tsmiManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetRoomState;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomStateEmpty;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomStateReserved;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomCheckedIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomStateRepair;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomStateClean;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomStateRetained;
        public System.Windows.Forms.DataGridView dgvReserve;
        private System.Windows.Forms.ContextMenuStrip cmsReserveAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewReservation;
        private System.Windows.Forms.ContextMenuStrip cmsRoomState;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageRoom;
        private System.Windows.Forms.ToolStripButton tsbReserve;
        private System.Windows.Forms.ToolStripButton tsbCheckIn;
        private System.Windows.Forms.ToolStripButton tsbMember;
        private System.Windows.Forms.ToolStripButton tsbTicket;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRoomMgt;
        private System.Windows.Forms.ToolStripButton tsbBFMgt;
        private System.Windows.Forms.ToolStripButton tsbStaffMgt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSwitchUser;
        private System.Windows.Forms.ToolStripButton tsbLockSystem;
        private System.Windows.Forms.ToolStripButton tsbExitSystem;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ContextMenuStrip cmsReserveMgt;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserveAppend;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserveModiify;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserveCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserveCheckIn;
        private System.Windows.Forms.ToolStripButton tsbSystemSettings;
        private System.Windows.Forms.Panel pRoomInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStripButton tsbMemberMgt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCustoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCustoPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cArriveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLeaveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cReserveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cReserveState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRemarks;
        private System.Windows.Forms.Panel pRoomInfoSelector;
        private System.Windows.Forms.ComboBox cbRoomState;
        private System.Windows.Forms.Label lblRoomState;
        private System.Windows.Forms.ComboBox cbFloorNo;
        private System.Windows.Forms.Label lblFloorNo;
        private System.Windows.Forms.ComboBox cbBuildingNo;
        private System.Windows.Forms.Label lblBuildingNo;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Panel pReserveInfoSelector;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbRoomNo;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.ToolStripButton tsbCheckOut;
    }
}