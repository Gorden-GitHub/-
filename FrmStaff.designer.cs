namespace hotelmgr
{
    partial class FrmStaff
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
            this.cmsStaffAppend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsStaffInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiStaffItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiStaffAppend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaffRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.gbStaffInfo = new System.Windows.Forms.GroupBox();
            this.tbStaffNo = new System.Windows.Forms.TextBox();
            this.lblStaffNo = new System.Windows.Forms.Label();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.tbStaffPhone = new System.Windows.Forms.TextBox();
            this.lblStaffPhone = new System.Windows.Forms.Label();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.dgvStaffInfo = new System.Windows.Forms.DataGridView();
            this.cStaffNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStaffPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStaffCretNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStaffDuty = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cStaffRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsStaffAppend.SuspendLayout();
            this.cmsStaffInfo.SuspendLayout();
            this.gbStaffInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsStaffAppend
            // 
            this.cmsStaffAppend.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsStaffAppend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStaff});
            this.cmsStaffAppend.Name = "cmsStaffAppend";
            this.cmsStaffAppend.Size = new System.Drawing.Size(154, 28);
            // 
            // tsmiAddStaff
            // 
            this.tsmiAddStaff.Name = "tsmiAddStaff";
            this.tsmiAddStaff.Size = new System.Drawing.Size(153, 24);
            this.tsmiAddStaff.Text = "添加新员工";
            this.tsmiAddStaff.Click += new System.EventHandler(this.tsmiAddStaff_Click);
            // 
            // cmsStaffInfo
            // 
            this.cmsStaffInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsStaffInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStaffItemModify,
            this.toolStripSeparator1,
            this.tsmiStaffAppend,
            this.tsmiStaffRemove});
            this.cmsStaffInfo.Name = "cmsStaffInfo";
            this.cmsStaffInfo.Size = new System.Drawing.Size(159, 82);
            // 
            // tsmiStaffItemModify
            // 
            this.tsmiStaffItemModify.Name = "tsmiStaffItemModify";
            this.tsmiStaffItemModify.Size = new System.Drawing.Size(158, 24);
            this.tsmiStaffItemModify.Text = "修改此项";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiStaffAppend
            // 
            this.tsmiStaffAppend.Name = "tsmiStaffAppend";
            this.tsmiStaffAppend.Size = new System.Drawing.Size(158, 24);
            this.tsmiStaffAppend.Text = "添加新员工";
            // 
            // tsmiStaffRemove
            // 
            this.tsmiStaffRemove.Name = "tsmiStaffRemove";
            this.tsmiStaffRemove.Size = new System.Drawing.Size(158, 24);
            this.tsmiStaffRemove.Text = "删除此员工";
            // 
            // gbStaffInfo
            // 
            this.gbStaffInfo.Controls.Add(this.tbStaffNo);
            this.gbStaffInfo.Controls.Add(this.lblStaffNo);
            this.gbStaffInfo.Controls.Add(this.btnSearchStaff);
            this.gbStaffInfo.Controls.Add(this.tbStaffPhone);
            this.gbStaffInfo.Controls.Add(this.lblStaffPhone);
            this.gbStaffInfo.Controls.Add(this.tbStaffName);
            this.gbStaffInfo.Controls.Add(this.lblStaffName);
            this.gbStaffInfo.Controls.Add(this.dgvStaffInfo);
            this.gbStaffInfo.Location = new System.Drawing.Point(10, 10);
            this.gbStaffInfo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 5);
            this.gbStaffInfo.Name = "gbStaffInfo";
            this.gbStaffInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbStaffInfo.Size = new System.Drawing.Size(1000, 538);
            this.gbStaffInfo.TabIndex = 10;
            this.gbStaffInfo.TabStop = false;
            this.gbStaffInfo.Text = "员工信息";
            // 
            // tbStaffNo
            // 
            this.tbStaffNo.Location = new System.Drawing.Point(92, 25);
            this.tbStaffNo.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.tbStaffNo.Name = "tbStaffNo";
            this.tbStaffNo.Size = new System.Drawing.Size(150, 25);
            this.tbStaffNo.TabIndex = 11;
            // 
            // lblStaffNo
            // 
            this.lblStaffNo.Location = new System.Drawing.Point(7, 25);
            this.lblStaffNo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 10);
            this.lblStaffNo.Name = "lblStaffNo";
            this.lblStaffNo.Size = new System.Drawing.Size(85, 25);
            this.lblStaffNo.TabIndex = 10;
            this.lblStaffNo.Text = "员工编号：";
            this.lblStaffNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Location = new System.Drawing.Point(757, 22);
            this.btnSearchStaff.Margin = new System.Windows.Forms.Padding(5, 2, 5, 7);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(90, 31);
            this.btnSearchStaff.TabIndex = 16;
            this.btnSearchStaff.Text = "搜索";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            // 
            // tbStaffPhone
            // 
            this.tbStaffPhone.Location = new System.Drawing.Point(592, 25);
            this.tbStaffPhone.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.tbStaffPhone.Name = "tbStaffPhone";
            this.tbStaffPhone.Size = new System.Drawing.Size(150, 25);
            this.tbStaffPhone.TabIndex = 15;
            // 
            // lblStaffPhone
            // 
            this.lblStaffPhone.Location = new System.Drawing.Point(507, 25);
            this.lblStaffPhone.Margin = new System.Windows.Forms.Padding(5, 5, 0, 10);
            this.lblStaffPhone.Name = "lblStaffPhone";
            this.lblStaffPhone.Size = new System.Drawing.Size(85, 25);
            this.lblStaffPhone.TabIndex = 14;
            this.lblStaffPhone.Text = "手机号码：";
            this.lblStaffPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(342, 25);
            this.tbStaffName.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.Size = new System.Drawing.Size(150, 25);
            this.tbStaffName.TabIndex = 13;
            // 
            // lblStaffName
            // 
            this.lblStaffName.Location = new System.Drawing.Point(257, 25);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(5, 5, 0, 10);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(85, 25);
            this.lblStaffName.TabIndex = 12;
            this.lblStaffName.Text = "员工姓名：";
            this.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvStaffInfo
            // 
            this.dgvStaffInfo.AllowUserToAddRows = false;
            this.dgvStaffInfo.AllowUserToDeleteRows = false;
            this.dgvStaffInfo.AllowUserToResizeColumns = false;
            this.dgvStaffInfo.AllowUserToResizeRows = false;
            this.dgvStaffInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaffInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStaffInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaffInfo.ColumnHeadersHeight = 29;
            this.dgvStaffInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaffInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStaffNo,
            this.cStaffName,
            this.cStaffPhone,
            this.cStaffCretNumber,
            this.cStaffDuty,
            this.cStaffRoomNo});
            this.dgvStaffInfo.ContextMenuStrip = this.cmsStaffAppend;
            this.dgvStaffInfo.Location = new System.Drawing.Point(0, 65);
            this.dgvStaffInfo.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.dgvStaffInfo.MultiSelect = false;
            this.dgvStaffInfo.Name = "dgvStaffInfo";
            this.dgvStaffInfo.RowHeadersWidth = 29;
            this.dgvStaffInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStaffInfo.RowTemplate.Height = 23;
            this.dgvStaffInfo.Size = new System.Drawing.Size(999, 471);
            this.dgvStaffInfo.TabIndex = 9;
            this.dgvStaffInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffInfo_CellDoubleClick);
            // 
            // cStaffNo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cStaffNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.cStaffNo.FillWeight = 60F;
            this.cStaffNo.HeaderText = "员工编号";
            this.cStaffNo.MinimumWidth = 6;
            this.cStaffNo.Name = "cStaffNo";
            this.cStaffNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cStaffName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cStaffName.DefaultCellStyle = dataGridViewCellStyle3;
            this.cStaffName.HeaderText = "员工姓名";
            this.cStaffName.MinimumWidth = 6;
            this.cStaffName.Name = "cStaffName";
            this.cStaffName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cStaffPhone
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cStaffPhone.DefaultCellStyle = dataGridViewCellStyle4;
            this.cStaffPhone.HeaderText = "手机号码";
            this.cStaffPhone.MinimumWidth = 6;
            this.cStaffPhone.Name = "cStaffPhone";
            this.cStaffPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cStaffCretNumber
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cStaffCretNumber.DefaultCellStyle = dataGridViewCellStyle5;
            this.cStaffCretNumber.FillWeight = 150F;
            this.cStaffCretNumber.HeaderText = "身份证号码";
            this.cStaffCretNumber.MinimumWidth = 6;
            this.cStaffCretNumber.Name = "cStaffCretNumber";
            this.cStaffCretNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cStaffDuty
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cStaffDuty.DefaultCellStyle = dataGridViewCellStyle6;
            this.cStaffDuty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cStaffDuty.HeaderText = "工作职责";
            this.cStaffDuty.Items.AddRange(new object[] {
            "前台接待员",
            "清洁员"});
            this.cStaffDuty.MinimumWidth = 6;
            this.cStaffDuty.Name = "cStaffDuty";
            // 
            // cStaffRoomNo
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cStaffRoomNo.DefaultCellStyle = dataGridViewCellStyle7;
            this.cStaffRoomNo.FillWeight = 200F;
            this.cStaffRoomNo.HeaderText = "负责的房间号";
            this.cStaffRoomNo.MinimumWidth = 6;
            this.cStaffRoomNo.Name = "cStaffRoomNo";
            this.cStaffRoomNo.ReadOnly = true;
            this.cStaffRoomNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1020, 562);
            this.Controls.Add(this.gbStaffInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmStaff";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员工信息";
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            this.Resize += new System.EventHandler(this.FrmStaff_Resize);
            this.cmsStaffAppend.ResumeLayout(false);
            this.cmsStaffInfo.ResumeLayout(false);
            this.gbStaffInfo.ResumeLayout(false);
            this.gbStaffInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsStaffInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffItemModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffAppend;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffRemove;
        private System.Windows.Forms.ContextMenuStrip cmsStaffAppend;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStaff;
        private System.Windows.Forms.GroupBox gbStaffInfo;
        private System.Windows.Forms.DataGridView dgvStaffInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStaffNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStaffPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStaffCretNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn cStaffDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStaffRoomNo;
        private System.Windows.Forms.TextBox tbStaffNo;
        private System.Windows.Forms.Label lblStaffNo;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.TextBox tbStaffPhone;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.Label lblStaffName;
    }
}