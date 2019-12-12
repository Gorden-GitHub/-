namespace hotelmgt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsStaff = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiStaffAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsStaffCell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiStaffCellModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiStaffCellAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaffCellRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbStaffNo = new System.Windows.Forms.TextBox();
            this.lblStaffNo = new System.Windows.Forms.Label();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.tbStaffPhone = new System.Windows.Forms.TextBox();
            this.lblStaffPhone = new System.Windows.Forms.Label();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.cStaffNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStaffPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStaffCretNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStaffDuty = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cStaffRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsStaff.SuspendLayout();
            this.cmsStaffCell.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsStaff
            // 
            this.cmsStaff.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsStaff.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStaffAdd});
            this.cmsStaff.Name = "cmsStaffAppend";
            this.cmsStaff.Size = new System.Drawing.Size(159, 28);
            // 
            // tsmiStaffAdd
            // 
            this.tsmiStaffAdd.Name = "tsmiStaffAdd";
            this.tsmiStaffAdd.Size = new System.Drawing.Size(158, 24);
            this.tsmiStaffAdd.Text = "添加新员工";
            this.tsmiStaffAdd.Click += new System.EventHandler(this.tsmiStaffAdd_Click);
            // 
            // cmsStaffCell
            // 
            this.cmsStaffCell.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsStaffCell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStaffCellModify,
            this.toolStripSeparator1,
            this.tsmiStaffCellAdd,
            this.tsmiStaffCellRemove});
            this.cmsStaffCell.Name = "cmsStaffInfo";
            this.cmsStaffCell.Size = new System.Drawing.Size(159, 82);
            // 
            // tsmiStaffCellModify
            // 
            this.tsmiStaffCellModify.Name = "tsmiStaffCellModify";
            this.tsmiStaffCellModify.Size = new System.Drawing.Size(158, 24);
            this.tsmiStaffCellModify.Text = "修改此项";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiStaffCellAdd
            // 
            this.tsmiStaffCellAdd.Name = "tsmiStaffCellAdd";
            this.tsmiStaffCellAdd.Size = new System.Drawing.Size(158, 24);
            this.tsmiStaffCellAdd.Text = "添加新员工";
            // 
            // tsmiStaffCellRemove
            // 
            this.tsmiStaffCellRemove.Name = "tsmiStaffCellRemove";
            this.tsmiStaffCellRemove.Size = new System.Drawing.Size(158, 24);
            this.tsmiStaffCellRemove.Text = "删除此员工";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tbStaffNo);
            this.panel1.Controls.Add(this.lblStaffNo);
            this.panel1.Controls.Add(this.btnSearchStaff);
            this.panel1.Controls.Add(this.tbStaffPhone);
            this.panel1.Controls.Add(this.lblStaffPhone);
            this.panel1.Controls.Add(this.tbStaffName);
            this.panel1.Controls.Add(this.lblStaffName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 18;
            // 
            // tbStaffNo
            // 
            this.tbStaffNo.Location = new System.Drawing.Point(90, 5);
            this.tbStaffNo.Margin = new System.Windows.Forms.Padding(0, 5, 10, 20);
            this.tbStaffNo.Name = "tbStaffNo";
            this.tbStaffNo.Size = new System.Drawing.Size(150, 25);
            this.tbStaffNo.TabIndex = 18;
            // 
            // lblStaffNo
            // 
            this.lblStaffNo.Location = new System.Drawing.Point(5, 5);
            this.lblStaffNo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 20);
            this.lblStaffNo.Name = "lblStaffNo";
            this.lblStaffNo.Size = new System.Drawing.Size(85, 25);
            this.lblStaffNo.TabIndex = 17;
            this.lblStaffNo.Text = "员工编号：";
            this.lblStaffNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Location = new System.Drawing.Point(755, 2);
            this.btnSearchStaff.Margin = new System.Windows.Forms.Padding(5, 2, 5, 17);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(90, 31);
            this.btnSearchStaff.TabIndex = 23;
            this.btnSearchStaff.Text = "查找";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            // 
            // tbStaffPhone
            // 
            this.tbStaffPhone.Location = new System.Drawing.Point(590, 5);
            this.tbStaffPhone.Margin = new System.Windows.Forms.Padding(0, 5, 10, 20);
            this.tbStaffPhone.Name = "tbStaffPhone";
            this.tbStaffPhone.Size = new System.Drawing.Size(150, 25);
            this.tbStaffPhone.TabIndex = 22;
            // 
            // lblStaffPhone
            // 
            this.lblStaffPhone.Location = new System.Drawing.Point(505, 5);
            this.lblStaffPhone.Margin = new System.Windows.Forms.Padding(5, 5, 0, 20);
            this.lblStaffPhone.Name = "lblStaffPhone";
            this.lblStaffPhone.Size = new System.Drawing.Size(85, 25);
            this.lblStaffPhone.TabIndex = 21;
            this.lblStaffPhone.Text = "手机号码：";
            this.lblStaffPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(340, 5);
            this.tbStaffName.Margin = new System.Windows.Forms.Padding(0, 5, 10, 20);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.Size = new System.Drawing.Size(150, 25);
            this.tbStaffName.TabIndex = 20;
            // 
            // lblStaffName
            // 
            this.lblStaffName.Location = new System.Drawing.Point(255, 5);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(5, 5, 0, 20);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(85, 25);
            this.lblStaffName.TabIndex = 19;
            this.lblStaffName.Text = "员工姓名：";
            this.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToResizeColumns = false;
            this.dgvStaff.AllowUserToResizeRows = false;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStaff.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.ColumnHeadersHeight = 29;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStaffNo,
            this.cStaffName,
            this.cStaffPhone,
            this.cStaffCretNumber,
            this.cStaffDuty,
            this.cStaffRoomNo});
            this.dgvStaff.ContextMenuStrip = this.cmsStaff;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(10, 60);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 29;
            this.dgvStaff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStaff.RowTemplate.Height = 23;
            this.dgvStaff.Size = new System.Drawing.Size(1000, 492);
            this.dgvStaff.TabIndex = 19;
            this.dgvStaff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellDoubleClick);
            this.dgvStaff.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvStaff_RowsAdded);
            // 
            // cStaffNo
            // 
            this.cStaffNo.FillWeight = 60F;
            this.cStaffNo.HeaderText = "员工编号";
            this.cStaffNo.MinimumWidth = 6;
            this.cStaffNo.Name = "cStaffNo";
            this.cStaffNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cStaffName
            // 
            this.cStaffName.HeaderText = "员工姓名";
            this.cStaffName.MinimumWidth = 6;
            this.cStaffName.Name = "cStaffName";
            this.cStaffName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cStaffPhone
            // 
            this.cStaffPhone.HeaderText = "手机号码";
            this.cStaffPhone.MinimumWidth = 6;
            this.cStaffPhone.Name = "cStaffPhone";
            this.cStaffPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cStaffCretNumber
            // 
            this.cStaffCretNumber.FillWeight = 150F;
            this.cStaffCretNumber.HeaderText = "身份证号码";
            this.cStaffCretNumber.MinimumWidth = 6;
            this.cStaffCretNumber.Name = "cStaffCretNumber";
            this.cStaffCretNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cStaffDuty
            // 
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cStaffRoomNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.cStaffRoomNo.FillWeight = 200F;
            this.cStaffRoomNo.HeaderText = "负责的房间编号";
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
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmStaff";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员工信息";
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            this.cmsStaff.ResumeLayout(false);
            this.cmsStaffCell.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsStaffCell;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffCellModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffCellAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffCellRemove;
        private System.Windows.Forms.ContextMenuStrip cmsStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbStaffNo;
        private System.Windows.Forms.Label lblStaffNo;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.TextBox tbStaffPhone;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStaffNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStaffPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStaffCretNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn cStaffDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStaffRoomNo;
    }
}