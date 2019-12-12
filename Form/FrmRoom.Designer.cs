namespace hotelmgt
{
    partial class FrmRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsRoomType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRoomTypeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.gbRoomInfo = new System.Windows.Forms.GroupBox();
            this.dgvRoomInfo = new System.Windows.Forms.DataGridView();
            this.cRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRoomType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cBuildingNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFloorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBedNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRoomStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRoomState = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsRoomInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRoomInfoAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbRoomState = new System.Windows.Forms.ComboBox();
            this.lblRoomState = new System.Windows.Forms.Label();
            this.cbFloorNo = new System.Windows.Forms.ComboBox();
            this.lblFloorNo = new System.Windows.Forms.Label();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.tbRoomNo = new System.Windows.Forms.TextBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmsRoomTypeCell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRoomTypeCellModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRoomTypeCellAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomTypeCellRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRoomInfoRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRoomInfoItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRoomInfoAppend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomInfoRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRoomState = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRoomStateAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRoomStateRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRoomStateModifyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRoomStateAppend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomStateRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbRoomType = new System.Windows.Forms.GroupBox();
            this.dgvRoomType = new System.Windows.Forms.DataGridView();
            this.gbRoomState = new System.Windows.Forms.GroupBox();
            this.dgvRoomState = new System.Windows.Forms.DataGridView();
            this.cRoomStates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHourAllowed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cHourHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHourPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsRoomType.SuspendLayout();
            this.gbRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).BeginInit();
            this.cmsRoomInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cmsRoomTypeCell.SuspendLayout();
            this.cmsRoomInfoRow.SuspendLayout();
            this.cmsRoomState.SuspendLayout();
            this.cmsRoomStateRow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbRoomType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).BeginInit();
            this.gbRoomState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomState)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsRoomType
            // 
            this.cmsRoomType.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoomType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomTypeAdd});
            this.cmsRoomType.Name = "cmsRoomTypeAdd";
            this.cmsRoomType.Size = new System.Drawing.Size(159, 28);
            // 
            // tsmiRoomTypeAdd
            // 
            this.tsmiRoomTypeAdd.Name = "tsmiRoomTypeAdd";
            this.tsmiRoomTypeAdd.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomTypeAdd.Text = "添加新类型";
            this.tsmiRoomTypeAdd.Click += new System.EventHandler(this.tsmiRoomTypeAdd_Click);
            // 
            // gbRoomInfo
            // 
            this.gbRoomInfo.Controls.Add(this.dgvRoomInfo);
            this.gbRoomInfo.Controls.Add(this.panel2);
            this.gbRoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRoomInfo.Location = new System.Drawing.Point(10, 260);
            this.gbRoomInfo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 5);
            this.gbRoomInfo.Name = "gbRoomInfo";
            this.gbRoomInfo.Size = new System.Drawing.Size(1089, 356);
            this.gbRoomInfo.TabIndex = 1;
            this.gbRoomInfo.TabStop = false;
            this.gbRoomInfo.Text = "房间信息";
            // 
            // dgvRoomInfo
            // 
            this.dgvRoomInfo.AllowUserToAddRows = false;
            this.dgvRoomInfo.AllowUserToDeleteRows = false;
            this.dgvRoomInfo.AllowUserToResizeColumns = false;
            this.dgvRoomInfo.AllowUserToResizeRows = false;
            this.dgvRoomInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRoomInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoomInfo.ColumnHeadersHeight = 29;
            this.dgvRoomInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoomInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRoomNo,
            this.cRoomType,
            this.cBuildingNo,
            this.cFloorNo,
            this.cBedNum,
            this.cRoomStaff,
            this.cRoomState,
            this.cRemarks});
            this.dgvRoomInfo.ContextMenuStrip = this.cmsRoomInfo;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomInfo.Location = new System.Drawing.Point(3, 66);
            this.dgvRoomInfo.Margin = new System.Windows.Forms.Padding(5);
            this.dgvRoomInfo.MultiSelect = false;
            this.dgvRoomInfo.Name = "dgvRoomInfo";
            this.dgvRoomInfo.RowHeadersWidth = 29;
            this.dgvRoomInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRoomInfo.RowTemplate.Height = 27;
            this.dgvRoomInfo.Size = new System.Drawing.Size(1083, 287);
            this.dgvRoomInfo.TabIndex = 1;
            this.dgvRoomInfo.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvRoomInfo_RowsAdded);
            // 
            // cRoomNo
            // 
            this.cRoomNo.HeaderText = "房间编号";
            this.cRoomNo.MinimumWidth = 6;
            this.cRoomNo.Name = "cRoomNo";
            this.cRoomNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRoomType
            // 
            this.cRoomType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cRoomType.HeaderText = "房间类型";
            this.cRoomType.Items.AddRange(new object[] {
            "大床房",
            "双床房",
            "三床房",
            "套房"});
            this.cRoomType.MinimumWidth = 6;
            this.cRoomType.Name = "cRoomType";
            // 
            // cBuildingNo
            // 
            this.cBuildingNo.FillWeight = 60F;
            this.cBuildingNo.HeaderText = "楼栋号";
            this.cBuildingNo.MinimumWidth = 6;
            this.cBuildingNo.Name = "cBuildingNo";
            this.cBuildingNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cFloorNo
            // 
            this.cFloorNo.FillWeight = 60F;
            this.cFloorNo.HeaderText = "楼层号";
            this.cFloorNo.MinimumWidth = 6;
            this.cFloorNo.Name = "cFloorNo";
            this.cFloorNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cBedNum
            // 
            this.cBedNum.FillWeight = 60F;
            this.cBedNum.HeaderText = "床位数";
            this.cBedNum.MinimumWidth = 6;
            this.cBedNum.Name = "cBedNum";
            this.cBedNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRoomStaff
            // 
            this.cRoomStaff.HeaderText = "负责的员工";
            this.cRoomStaff.MinimumWidth = 6;
            this.cRoomStaff.Name = "cRoomStaff";
            this.cRoomStaff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRoomState
            // 
            this.cRoomState.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cRoomState.HeaderText = "房间状态";
            this.cRoomState.Items.AddRange(new object[] {
            "空房",
            "已预订",
            "已入住",
            "等待维修",
            "等待清洁",
            "保留"});
            this.cRoomState.MinimumWidth = 6;
            this.cRoomState.Name = "cRoomState";
            // 
            // cRemarks
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cRemarks.DefaultCellStyle = dataGridViewCellStyle2;
            this.cRemarks.HeaderText = "备注";
            this.cRemarks.MinimumWidth = 6;
            this.cRemarks.Name = "cRemarks";
            this.cRemarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmsRoomInfo
            // 
            this.cmsRoomInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoomInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomInfoAdd});
            this.cmsRoomInfo.Name = "cmsRoomInfoAppend";
            this.cmsRoomInfo.Size = new System.Drawing.Size(159, 28);
            // 
            // tsmiRoomInfoAdd
            // 
            this.tsmiRoomInfoAdd.Name = "tsmiRoomInfoAdd";
            this.tsmiRoomInfoAdd.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomInfoAdd.Text = "添加新房间";
            this.tsmiRoomInfoAdd.Click += new System.EventHandler(this.tsmiRoomInfoAdd_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.cbRoomState);
            this.panel2.Controls.Add(this.lblRoomState);
            this.panel2.Controls.Add(this.cbFloorNo);
            this.panel2.Controls.Add(this.lblFloorNo);
            this.panel2.Controls.Add(this.btnSearchRoom);
            this.panel2.Controls.Add(this.tbRoomNo);
            this.panel2.Controls.Add(this.lblRoomNo);
            this.panel2.Controls.Add(this.cbRoomType);
            this.panel2.Controls.Add(this.lblRoomType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 45);
            this.panel2.TabIndex = 16;
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
            this.cbRoomState.Location = new System.Drawing.Point(475, 5);
            this.cbRoomState.Margin = new System.Windows.Forms.Padding(0, 5, 10, 17);
            this.cbRoomState.Name = "cbRoomState";
            this.cbRoomState.Size = new System.Drawing.Size(135, 23);
            this.cbRoomState.TabIndex = 25;
            // 
            // lblRoomState
            // 
            this.lblRoomState.Location = new System.Drawing.Point(390, 5);
            this.lblRoomState.Margin = new System.Windows.Forms.Padding(5, 5, 0, 15);
            this.lblRoomState.Name = "lblRoomState";
            this.lblRoomState.Size = new System.Drawing.Size(85, 25);
            this.lblRoomState.TabIndex = 24;
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
            this.cbFloorNo.Location = new System.Drawing.Point(310, 5);
            this.cbFloorNo.Margin = new System.Windows.Forms.Padding(0, 5, 10, 17);
            this.cbFloorNo.Name = "cbFloorNo";
            this.cbFloorNo.Size = new System.Drawing.Size(65, 23);
            this.cbFloorNo.TabIndex = 23;
            // 
            // lblFloorNo
            // 
            this.lblFloorNo.Location = new System.Drawing.Point(240, 5);
            this.lblFloorNo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 15);
            this.lblFloorNo.Name = "lblFloorNo";
            this.lblFloorNo.Size = new System.Drawing.Size(70, 25);
            this.lblFloorNo.TabIndex = 22;
            this.lblFloorNo.Text = "楼层号：";
            this.lblFloorNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.Location = new System.Drawing.Point(985, 2);
            this.btnSearchRoom.Margin = new System.Windows.Forms.Padding(5, 5, 10, 12);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(90, 31);
            this.btnSearchRoom.TabIndex = 19;
            this.btnSearchRoom.Text = "查找";
            this.btnSearchRoom.UseVisualStyleBackColor = true;
            // 
            // tbRoomNo
            // 
            this.tbRoomNo.HideSelection = false;
            this.tbRoomNo.Location = new System.Drawing.Point(885, 5);
            this.tbRoomNo.Margin = new System.Windows.Forms.Padding(5, 5, 10, 15);
            this.tbRoomNo.Name = "tbRoomNo";
            this.tbRoomNo.Size = new System.Drawing.Size(85, 25);
            this.tbRoomNo.TabIndex = 18;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.Location = new System.Drawing.Point(795, 5);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 15);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(85, 25);
            this.lblRoomNo.TabIndex = 17;
            this.lblRoomNo.Text = "房间编号：";
            this.lblRoomNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cbRoomType.Location = new System.Drawing.Point(90, 5);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(0, 5, 10, 17);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(135, 23);
            this.cbRoomType.TabIndex = 16;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Location = new System.Drawing.Point(5, 5);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(5, 5, 0, 15);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(85, 25);
            this.lblRoomType.TabIndex = 15;
            this.lblRoomType.Text = "房间类型：";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmsRoomTypeCell
            // 
            this.cmsRoomTypeCell.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoomTypeCell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomTypeCellModify,
            this.toolStripSeparator1,
            this.tsmiRoomTypeCellAdd,
            this.tsmiRoomTypeCellRemove});
            this.cmsRoomTypeCell.Name = "cmsRoomType";
            this.cmsRoomTypeCell.Size = new System.Drawing.Size(159, 82);
            // 
            // tsmiRoomTypeCellModify
            // 
            this.tsmiRoomTypeCellModify.Name = "tsmiRoomTypeCellModify";
            this.tsmiRoomTypeCellModify.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomTypeCellModify.Text = "修改此项";
            this.tsmiRoomTypeCellModify.Click += new System.EventHandler(this.tsmiRoomTypeCellModify_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiRoomTypeCellAdd
            // 
            this.tsmiRoomTypeCellAdd.Name = "tsmiRoomTypeCellAdd";
            this.tsmiRoomTypeCellAdd.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomTypeCellAdd.Text = "添加新类型";
            this.tsmiRoomTypeCellAdd.Click += new System.EventHandler(this.tsmiRoomTypeCellAdd_Click);
            // 
            // tsmiRoomTypeCellRemove
            // 
            this.tsmiRoomTypeCellRemove.Name = "tsmiRoomTypeCellRemove";
            this.tsmiRoomTypeCellRemove.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomTypeCellRemove.Text = "删除此类型";
            this.tsmiRoomTypeCellRemove.Click += new System.EventHandler(this.tsmiRoomTypeCellRemove_Click);
            // 
            // cmsRoomInfoRow
            // 
            this.cmsRoomInfoRow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoomInfoRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomInfoItemModify,
            this.toolStripSeparator2,
            this.tsmiRoomInfoAppend,
            this.tsmiRoomInfoRemove});
            this.cmsRoomInfoRow.Name = "cmsRoomInfo";
            this.cmsRoomInfoRow.Size = new System.Drawing.Size(159, 82);
            // 
            // tsmiRoomInfoItemModify
            // 
            this.tsmiRoomInfoItemModify.Name = "tsmiRoomInfoItemModify";
            this.tsmiRoomInfoItemModify.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomInfoItemModify.Text = "修改此项";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiRoomInfoAppend
            // 
            this.tsmiRoomInfoAppend.Name = "tsmiRoomInfoAppend";
            this.tsmiRoomInfoAppend.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomInfoAppend.Text = "添加新房间";
            this.tsmiRoomInfoAppend.Click += new System.EventHandler(this.tsmiRoomInfoAppend_Click);
            // 
            // tsmiRoomInfoRemove
            // 
            this.tsmiRoomInfoRemove.Name = "tsmiRoomInfoRemove";
            this.tsmiRoomInfoRemove.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomInfoRemove.Text = "移除此房间";
            // 
            // cmsRoomState
            // 
            this.cmsRoomState.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoomState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomStateAdd});
            this.cmsRoomState.Name = "cmsRoomStateAdd";
            this.cmsRoomState.Size = new System.Drawing.Size(159, 28);
            // 
            // tsmiRoomStateAdd
            // 
            this.tsmiRoomStateAdd.Name = "tsmiRoomStateAdd";
            this.tsmiRoomStateAdd.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomStateAdd.Text = "添加新状态";
            this.tsmiRoomStateAdd.Click += new System.EventHandler(this.tsmiRoomStateAdd_Click);
            // 
            // cmsRoomStateRow
            // 
            this.cmsRoomStateRow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoomStateRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomStateModifyItem,
            this.toolStripSeparator3,
            this.tsmiRoomStateAppend,
            this.tsmiRoomStateRemove});
            this.cmsRoomStateRow.Name = "cmsRoomState";
            this.cmsRoomStateRow.Size = new System.Drawing.Size(159, 82);
            // 
            // tsmiRoomStateModifyItem
            // 
            this.tsmiRoomStateModifyItem.Name = "tsmiRoomStateModifyItem";
            this.tsmiRoomStateModifyItem.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomStateModifyItem.Text = "修改此项";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiRoomStateAppend
            // 
            this.tsmiRoomStateAppend.Name = "tsmiRoomStateAppend";
            this.tsmiRoomStateAppend.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomStateAppend.Text = "添加新状态";
            this.tsmiRoomStateAppend.Click += new System.EventHandler(this.tsmiRoomStateAppend_Click);
            // 
            // tsmiRoomStateRemove
            // 
            this.tsmiRoomStateRemove.Name = "tsmiRoomStateRemove";
            this.tsmiRoomStateRemove.Size = new System.Drawing.Size(158, 24);
            this.tsmiRoomStateRemove.Text = "删除此状态";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbRoomType);
            this.panel1.Controls.Add(this.gbRoomState);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 250);
            this.panel1.TabIndex = 9;
            // 
            // gbRoomType
            // 
            this.gbRoomType.Controls.Add(this.dgvRoomType);
            this.gbRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRoomType.Location = new System.Drawing.Point(0, 0);
            this.gbRoomType.Margin = new System.Windows.Forms.Padding(1, 1, 1, 5);
            this.gbRoomType.Name = "gbRoomType";
            this.gbRoomType.Padding = new System.Windows.Forms.Padding(2);
            this.gbRoomType.Size = new System.Drawing.Size(839, 250);
            this.gbRoomType.TabIndex = 6;
            this.gbRoomType.TabStop = false;
            this.gbRoomType.Text = "房间类型";
            // 
            // dgvRoomType
            // 
            this.dgvRoomType.AllowUserToAddRows = false;
            this.dgvRoomType.AllowUserToDeleteRows = false;
            this.dgvRoomType.AllowUserToResizeColumns = false;
            this.dgvRoomType.AllowUserToResizeRows = false;
            this.dgvRoomType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomType.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRoomType.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRoomType.ColumnHeadersHeight = 29;
            this.dgvRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoomType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNo,
            this.cTypeName,
            this.cStdPrice,
            this.cHourAllowed,
            this.cHourHours,
            this.cHourPrice});
            this.dgvRoomType.ContextMenuStrip = this.cmsRoomType;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomType.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomType.Location = new System.Drawing.Point(2, 20);
            this.dgvRoomType.Margin = new System.Windows.Forms.Padding(5);
            this.dgvRoomType.MultiSelect = false;
            this.dgvRoomType.Name = "dgvRoomType";
            this.dgvRoomType.RowHeadersWidth = 29;
            this.dgvRoomType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRoomType.RowTemplate.Height = 27;
            this.dgvRoomType.Size = new System.Drawing.Size(835, 228);
            this.dgvRoomType.TabIndex = 0;
            this.dgvRoomType.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoomType_CellMouseUp);
            this.dgvRoomType.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvRoomType_RowsAdded);
            // 
            // gbRoomState
            // 
            this.gbRoomState.Controls.Add(this.dgvRoomState);
            this.gbRoomState.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbRoomState.Location = new System.Drawing.Point(839, 0);
            this.gbRoomState.Margin = new System.Windows.Forms.Padding(1, 1, 1, 5);
            this.gbRoomState.Name = "gbRoomState";
            this.gbRoomState.Padding = new System.Windows.Forms.Padding(2);
            this.gbRoomState.Size = new System.Drawing.Size(250, 250);
            this.gbRoomState.TabIndex = 7;
            this.gbRoomState.TabStop = false;
            this.gbRoomState.Text = "房间状态";
            // 
            // dgvRoomState
            // 
            this.dgvRoomState.AllowUserToAddRows = false;
            this.dgvRoomState.AllowUserToDeleteRows = false;
            this.dgvRoomState.AllowUserToResizeColumns = false;
            this.dgvRoomState.AllowUserToResizeRows = false;
            this.dgvRoomState.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomState.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRoomState.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomState.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRoomState.ColumnHeadersHeight = 29;
            this.dgvRoomState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoomState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRoomStates});
            this.dgvRoomState.ContextMenuStrip = this.cmsRoomState;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomState.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRoomState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomState.Location = new System.Drawing.Point(2, 20);
            this.dgvRoomState.Margin = new System.Windows.Forms.Padding(5);
            this.dgvRoomState.MultiSelect = false;
            this.dgvRoomState.Name = "dgvRoomState";
            this.dgvRoomState.RowHeadersWidth = 29;
            this.dgvRoomState.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRoomState.RowTemplate.Height = 27;
            this.dgvRoomState.Size = new System.Drawing.Size(246, 228);
            this.dgvRoomState.TabIndex = 1;
            this.dgvRoomState.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvRoomState_RowsAdded);
            // 
            // cRoomStates
            // 
            this.cRoomStates.HeaderText = "房间状态";
            this.cRoomStates.MinimumWidth = 6;
            this.cRoomStates.Name = "cRoomStates";
            this.cRoomStates.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cNo
            // 
            this.cNo.FillWeight = 40F;
            this.cNo.HeaderText = "序号";
            this.cNo.MinimumWidth = 6;
            this.cNo.Name = "cNo";
            this.cNo.ReadOnly = true;
            this.cNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cTypeName
            // 
            this.cTypeName.HeaderText = "类型名称";
            this.cTypeName.MinimumWidth = 6;
            this.cTypeName.Name = "cTypeName";
            this.cTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cStdPrice
            // 
            this.cStdPrice.HeaderText = "标准价格（/天）";
            this.cStdPrice.MinimumWidth = 6;
            this.cStdPrice.Name = "cStdPrice";
            this.cStdPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cHourAllowed
            // 
            this.cHourAllowed.FillWeight = 60F;
            this.cHourAllowed.HeaderText = "允许钟点房";
            this.cHourAllowed.MinimumWidth = 6;
            this.cHourAllowed.Name = "cHourAllowed";
            // 
            // cHourHours
            // 
            this.cHourHours.HeaderText = "钟点房时长（小时）";
            this.cHourHours.MinimumWidth = 6;
            this.cHourHours.Name = "cHourHours";
            this.cHourHours.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cHourPrice
            // 
            this.cHourPrice.HeaderText = "钟点房价（/小时）";
            this.cHourPrice.MinimumWidth = 6;
            this.cHourPrice.Name = "cHourPrice";
            this.cHourPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1109, 626);
            this.Controls.Add(this.gbRoomInfo);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "FrmRoom";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理客房信息";
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            this.Resize += new System.EventHandler(this.FrmRoom_Resize);
            this.cmsRoomType.ResumeLayout(false);
            this.gbRoomInfo.ResumeLayout(false);
            this.gbRoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).EndInit();
            this.cmsRoomInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cmsRoomTypeCell.ResumeLayout(false);
            this.cmsRoomInfoRow.ResumeLayout(false);
            this.cmsRoomState.ResumeLayout(false);
            this.cmsRoomStateRow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbRoomType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).EndInit();
            this.gbRoomState.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbRoomInfo;
        private System.Windows.Forms.DataGridView dgvRoomInfo;
        private System.Windows.Forms.ContextMenuStrip cmsRoomTypeCell;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomTypeCellAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomTypeCellRemove;
        private System.Windows.Forms.ContextMenuStrip cmsRoomInfoRow;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomInfoItemModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomInfoAppend;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomInfoRemove;
        private System.Windows.Forms.ContextMenuStrip cmsRoomType;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomTypeAdd;
        private System.Windows.Forms.ContextMenuStrip cmsRoomInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomInfoAdd;
        private System.Windows.Forms.ContextMenuStrip cmsRoomStateRow;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomStateModifyItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomStateAppend;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomStateRemove;
        private System.Windows.Forms.ContextMenuStrip cmsRoomState;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomStateAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbRoomState;
        private System.Windows.Forms.DataGridView dgvRoomState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoomStates;
        private System.Windows.Forms.GroupBox gbRoomType;
        private System.Windows.Forms.DataGridView dgvRoomType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbRoomState;
        private System.Windows.Forms.Label lblRoomState;
        private System.Windows.Forms.ComboBox cbFloorNo;
        private System.Windows.Forms.Label lblFloorNo;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.TextBox tbRoomNo;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomTypeCellModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoomNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn cRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBuildingNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFloorNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBedNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoomStaff;
        private System.Windows.Forms.DataGridViewComboBoxColumn cRoomState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStdPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cHourAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHourHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHourPrice;
    }
}