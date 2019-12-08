namespace hotelmgr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsState = new System.Windows.Forms.StatusStrip();
            this.tsslState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpReserve = new System.Windows.Forms.TabPage();
            this.dgvReserve = new System.Windows.Forms.DataGridView();
            this.cmsReserveAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNewReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.tpRoomState = new System.Windows.Forms.TabPage();
            this.cbRoomState = new System.Windows.Forms.ComboBox();
            this.lblRoomState = new System.Windows.Forms.Label();
            this.cbFloorNo = new System.Windows.Forms.ComboBox();
            this.lblFloorNo = new System.Windows.Forms.Label();
            this.cbBuildingNo = new System.Windows.Forms.ComboBox();
            this.lblBuildingNo = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsRoomState = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiManageRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettle = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetRoomState = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomStateEmpty = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomStateReserved = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomCheckedIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomStateRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomStateClean = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomStateRetained = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tsbReserve = new System.Windows.Forms.ToolStripButton();
            this.tsbCheckIn = new System.Windows.Forms.ToolStripButton();
            this.tsbMember = new System.Windows.Forms.ToolStripButton();
            this.tsbBF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRoomMgr = new System.Windows.Forms.ToolStripButton();
            this.tsbBFMgr = new System.Windows.Forms.ToolStripButton();
            this.tsbStaffMgr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSwitchUser = new System.Windows.Forms.ToolStripButton();
            this.tsbLockSystem = new System.Windows.Forms.ToolStripButton();
            this.tsbExitSystem = new System.Windows.Forms.ToolStripButton();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbSystemCfg = new System.Windows.Forms.ToolStripButton();
            this.cmsReserveMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReserveAppend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReserveModiify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReserveCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReserveCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbMemberMgr = new System.Windows.Forms.ToolStripButton();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCustoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCustoPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cArriveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLeaveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cReserveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cReserveState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsState.SuspendLayout();
            this.tpReserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserve)).BeginInit();
            this.cmsReserveAdd.SuspendLayout();
            this.tpRoomState.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmsRoomState.SuspendLayout();
            this.cmsRoom.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.cmsReserveMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsState
            // 
            this.tsState.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslState});
            this.tsState.Location = new System.Drawing.Point(0, 514);
            this.tsState.Name = "tsState";
            this.tsState.Size = new System.Drawing.Size(1118, 26);
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
            this.tpReserve.Location = new System.Drawing.Point(4, 34);
            this.tpReserve.Name = "tpReserve";
            this.tpReserve.Size = new System.Drawing.Size(1110, 392);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReserve.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReserve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReserve.Location = new System.Drawing.Point(0, 0);
            this.dgvReserve.MultiSelect = false;
            this.dgvReserve.Name = "dgvReserve";
            this.dgvReserve.ReadOnly = true;
            this.dgvReserve.RowHeadersWidth = 29;
            this.dgvReserve.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReserve.RowTemplate.Height = 27;
            this.dgvReserve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReserve.Size = new System.Drawing.Size(1110, 392);
            this.dgvReserve.TabIndex = 0;
            this.dgvReserve.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvReserve_RowsAdded);
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
            // tpRoomState
            // 
            this.tpRoomState.Controls.Add(this.cbRoomState);
            this.tpRoomState.Controls.Add(this.lblRoomState);
            this.tpRoomState.Controls.Add(this.cbFloorNo);
            this.tpRoomState.Controls.Add(this.lblFloorNo);
            this.tpRoomState.Controls.Add(this.cbBuildingNo);
            this.tpRoomState.Controls.Add(this.lblBuildingNo);
            this.tpRoomState.Controls.Add(this.cbRoomType);
            this.tpRoomState.Controls.Add(this.lblRoomType);
            this.tpRoomState.Controls.Add(this.panel1);
            this.tpRoomState.Controls.Add(this.flpRoom);
            this.tpRoomState.Location = new System.Drawing.Point(4, 34);
            this.tpRoomState.Name = "tpRoomState";
            this.tpRoomState.Size = new System.Drawing.Size(1110, 392);
            this.tpRoomState.TabIndex = 6;
            this.tpRoomState.Text = "客房状态";
            this.tpRoomState.UseVisualStyleBackColor = true;
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
            this.cbRoomState.Location = new System.Drawing.Point(645, 15);
            this.cbRoomState.Margin = new System.Windows.Forms.Padding(0, 15, 10, 17);
            this.cbRoomState.Name = "cbRoomState";
            this.cbRoomState.Size = new System.Drawing.Size(135, 23);
            this.cbRoomState.TabIndex = 22;
            // 
            // lblRoomState
            // 
            this.lblRoomState.Location = new System.Drawing.Point(560, 15);
            this.lblRoomState.Margin = new System.Windows.Forms.Padding(5, 15, 0, 15);
            this.lblRoomState.Name = "lblRoomState";
            this.lblRoomState.Size = new System.Drawing.Size(85, 25);
            this.lblRoomState.TabIndex = 21;
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
            this.cbFloorNo.Location = new System.Drawing.Point(475, 15);
            this.cbFloorNo.Margin = new System.Windows.Forms.Padding(0, 15, 10, 17);
            this.cbFloorNo.Name = "cbFloorNo";
            this.cbFloorNo.Size = new System.Drawing.Size(65, 23);
            this.cbFloorNo.TabIndex = 20;
            // 
            // lblFloorNo
            // 
            this.lblFloorNo.Location = new System.Drawing.Point(405, 15);
            this.lblFloorNo.Margin = new System.Windows.Forms.Padding(5, 15, 0, 15);
            this.lblFloorNo.Name = "lblFloorNo";
            this.lblFloorNo.Size = new System.Drawing.Size(70, 25);
            this.lblFloorNo.TabIndex = 19;
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
            this.cbBuildingNo.Margin = new System.Windows.Forms.Padding(0, 15, 10, 17);
            this.cbBuildingNo.Name = "cbBuildingNo";
            this.cbBuildingNo.Size = new System.Drawing.Size(65, 23);
            this.cbBuildingNo.TabIndex = 18;
            // 
            // lblBuildingNo
            // 
            this.lblBuildingNo.Location = new System.Drawing.Point(250, 15);
            this.lblBuildingNo.Margin = new System.Windows.Forms.Padding(5, 15, 0, 15);
            this.lblBuildingNo.Name = "lblBuildingNo";
            this.lblBuildingNo.Size = new System.Drawing.Size(70, 25);
            this.lblBuildingNo.TabIndex = 17;
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
            this.cbRoomType.Location = new System.Drawing.Point(95, 15);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(0, 15, 10, 17);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(135, 23);
            this.cbRoomType.TabIndex = 16;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Location = new System.Drawing.Point(10, 15);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(5, 15, 0, 15);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(85, 25);
            this.lblRoomType.TabIndex = 15;
            this.lblRoomType.Text = "房间类型：";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(840, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 334);
            this.panel1.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(95, 255);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 25);
            this.label14.TabIndex = 17;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(10, 255);
            this.label15.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "备注信息：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(95, 220);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 25);
            this.label12.TabIndex = 15;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(10, 220);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "客房状态：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(95, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 13;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(10, 185);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "员工编号：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(95, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 11;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "床位数：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(95, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 9;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "楼层号：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(95, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 7;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "楼栋号：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(95, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "客房类型：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(95, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(10, 10);
            this.lblName.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "客房编号：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpRoom.ContextMenuStrip = this.cmsRoomState;
            this.flpRoom.Location = new System.Drawing.Point(0, 58);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(841, 335);
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
            // cmsRoom
            // 
            this.cmsRoom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReserve,
            this.tsmiCheckIn,
            this.tsmiSettle,
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
            // tsmiSettle
            // 
            this.tsmiSettle.Name = "tsmiSettle";
            this.tsmiSettle.Size = new System.Drawing.Size(142, 24);
            this.tsmiSettle.Text = "退房结账";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRoomState);
            this.tabControl1.Controls.Add(this.tpReserve);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 430);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
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
            this.tsbMember.Click += new System.EventHandler(this.tsbMember_Click);
            // 
            // tsbBF
            // 
            this.tsbBF.AutoSize = false;
            this.tsbBF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBF.Image = ((System.Drawing.Image)(resources.GetObject("tsbBF.Image")));
            this.tsbBF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBF.Name = "tsbBF";
            this.tsbBF.Size = new System.Drawing.Size(80, 80);
            this.tsbBF.Text = "早餐票";
            this.tsbBF.Click += new System.EventHandler(this.tsbBF_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 83);
            // 
            // tsbRoomMgr
            // 
            this.tsbRoomMgr.AutoSize = false;
            this.tsbRoomMgr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRoomMgr.Image = ((System.Drawing.Image)(resources.GetObject("tsbRoomMgr.Image")));
            this.tsbRoomMgr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRoomMgr.Name = "tsbRoomMgr";
            this.tsbRoomMgr.Size = new System.Drawing.Size(80, 80);
            this.tsbRoomMgr.Text = "客房管理";
            this.tsbRoomMgr.Click += new System.EventHandler(this.tsbRoomMgr_Click);
            // 
            // tsbBFMgr
            // 
            this.tsbBFMgr.AutoSize = false;
            this.tsbBFMgr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBFMgr.Image = ((System.Drawing.Image)(resources.GetObject("tsbBFMgr.Image")));
            this.tsbBFMgr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBFMgr.Name = "tsbBFMgr";
            this.tsbBFMgr.Size = new System.Drawing.Size(80, 80);
            this.tsbBFMgr.Text = "餐费管理";
            this.tsbBFMgr.Click += new System.EventHandler(this.tsbBFMgr_Click);
            // 
            // tsbStaffMgr
            // 
            this.tsbStaffMgr.AutoSize = false;
            this.tsbStaffMgr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStaffMgr.Image = ((System.Drawing.Image)(resources.GetObject("tsbStaffMgr.Image")));
            this.tsbStaffMgr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStaffMgr.Name = "tsbStaffMgr";
            this.tsbStaffMgr.Size = new System.Drawing.Size(80, 80);
            this.tsbStaffMgr.Text = "员工管理";
            this.tsbStaffMgr.Click += new System.EventHandler(this.tsbStaffMgr_Click);
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
            this.tsbExitSystem.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReserve,
            this.tsbCheckIn,
            this.tsbMember,
            this.tsbBF,
            this.toolStripSeparator1,
            this.tsbRoomMgr,
            this.tsbMemberMgr,
            this.tsbBFMgr,
            this.tsbStaffMgr,
            this.toolStripSeparator2,
            this.tsbSwitchUser,
            this.tsbSystemCfg,
            this.tsbLockSystem,
            this.tsbExitSystem});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.tsMain.Size = new System.Drawing.Size(1118, 84);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "tsMain";
            // 
            // tsbSystemCfg
            // 
            this.tsbSystemCfg.AutoSize = false;
            this.tsbSystemCfg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSystemCfg.Image = ((System.Drawing.Image)(resources.GetObject("tsbSystemCfg.Image")));
            this.tsbSystemCfg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSystemCfg.Name = "tsbSystemCfg";
            this.tsbSystemCfg.Size = new System.Drawing.Size(80, 80);
            this.tsbSystemCfg.Text = "系统设置";
            // 
            // cmsReserveMgr
            // 
            this.cmsReserveMgr.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsReserveMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReserveAppend,
            this.tsmiReserveModiify,
            this.tsmiReserveCancel,
            this.toolStripSeparator3,
            this.tsmiReserveCheckIn});
            this.cmsReserveMgr.Name = "cmsReserveMgr";
            this.cmsReserveMgr.Size = new System.Drawing.Size(143, 106);
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
            // tsbMemberMgr
            // 
            this.tsbMemberMgr.AutoSize = false;
            this.tsbMemberMgr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMemberMgr.Image = ((System.Drawing.Image)(resources.GetObject("tsbMemberMgr.Image")));
            this.tsbMemberMgr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMemberMgr.Name = "tsbMemberMgr";
            this.tsbMemberMgr.Size = new System.Drawing.Size(80, 80);
            this.tsbMemberMgr.Text = "会员管理";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cRemarks.DefaultCellStyle = dataGridViewCellStyle2;
            this.cRemarks.FillWeight = 150F;
            this.cRemarks.HeaderText = "备注";
            this.cRemarks.MinimumWidth = 6;
            this.cRemarks.Name = "cRemarks";
            this.cRemarks.ReadOnly = true;
            this.cRemarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1118, 540);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.tsState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "客房信息管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.tsState.ResumeLayout(false);
            this.tsState.PerformLayout();
            this.tpReserve.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserve)).EndInit();
            this.cmsReserveAdd.ResumeLayout(false);
            this.tpRoomState.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.cmsRoomState.ResumeLayout(false);
            this.cmsRoom.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.cmsReserveMgr.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip tsState;
        private System.Windows.Forms.ToolStripStatusLabel tsslState;
        private System.Windows.Forms.TabPage tpReserve;
        private System.Windows.Forms.TabPage tpRoomState;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ContextMenuStrip cmsRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserve;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettle;
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
        private System.Windows.Forms.ToolStripButton tsbBF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRoomMgr;
        private System.Windows.Forms.ToolStripButton tsbBFMgr;
        private System.Windows.Forms.ToolStripButton tsbStaffMgr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSwitchUser;
        private System.Windows.Forms.ToolStripButton tsbLockSystem;
        private System.Windows.Forms.ToolStripButton tsbExitSystem;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ContextMenuStrip cmsReserveMgr;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserveAppend;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserveModiify;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserveCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserveCheckIn;
        private System.Windows.Forms.ToolStripButton tsbSystemCfg;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.ComboBox cbRoomState;
        private System.Windows.Forms.Label lblRoomState;
        private System.Windows.Forms.ComboBox cbFloorNo;
        private System.Windows.Forms.Label lblFloorNo;
        private System.Windows.Forms.ComboBox cbBuildingNo;
        private System.Windows.Forms.Label lblBuildingNo;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ToolStripButton tsbMemberMgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCustoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCustoPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cArriveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLeaveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cReserveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cReserveState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRemarks;
    }
}