namespace hotelmgt
{
    partial class FrmBF
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
            this.gbBFInfo = new System.Windows.Forms.GroupBox();
            this.dgvBFInfo = new System.Windows.Forms.DataGridView();
            this.cBFType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBFPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsBFAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBFAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBF = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBFModifyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiBFAppend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBFRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.gbBFInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBFInfo)).BeginInit();
            this.cmsBFAdd.SuspendLayout();
            this.cmsBF.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBFInfo
            // 
            this.gbBFInfo.Controls.Add(this.dgvBFInfo);
            this.gbBFInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBFInfo.Location = new System.Drawing.Point(10, 10);
            this.gbBFInfo.Name = "gbBFInfo";
            this.gbBFInfo.Size = new System.Drawing.Size(362, 333);
            this.gbBFInfo.TabIndex = 6;
            this.gbBFInfo.TabStop = false;
            this.gbBFInfo.Text = "餐费信息";
            // 
            // dgvBFInfo
            // 
            this.dgvBFInfo.AllowUserToAddRows = false;
            this.dgvBFInfo.AllowUserToDeleteRows = false;
            this.dgvBFInfo.AllowUserToResizeColumns = false;
            this.dgvBFInfo.AllowUserToResizeRows = false;
            this.dgvBFInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBFInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBFInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBFInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBFInfo.ColumnHeadersHeight = 29;
            this.dgvBFInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBFInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cBFType,
            this.cBFPrice});
            this.dgvBFInfo.ContextMenuStrip = this.cmsBFAdd;
            this.dgvBFInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBFInfo.Location = new System.Drawing.Point(3, 21);
            this.dgvBFInfo.MultiSelect = false;
            this.dgvBFInfo.Name = "dgvBFInfo";
            this.dgvBFInfo.RowHeadersWidth = 29;
            this.dgvBFInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBFInfo.RowTemplate.Height = 27;
            this.dgvBFInfo.Size = new System.Drawing.Size(356, 309);
            this.dgvBFInfo.TabIndex = 1;
            this.dgvBFInfo.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvBFInfo_RowsAdded);
            // 
            // cBFType
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cBFType.DefaultCellStyle = dataGridViewCellStyle2;
            this.cBFType.HeaderText = "餐票类型";
            this.cBFType.MinimumWidth = 6;
            this.cBFType.Name = "cBFType";
            this.cBFType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cBFPrice
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cBFPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.cBFPrice.HeaderText = "餐票价格";
            this.cBFPrice.MinimumWidth = 6;
            this.cBFPrice.Name = "cBFPrice";
            this.cBFPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmsBFAdd
            // 
            this.cmsBFAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBFAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBFAdd});
            this.cmsBFAdd.Name = "cmsBFAdd";
            this.cmsBFAdd.Size = new System.Drawing.Size(159, 28);
            // 
            // tsmiBFAdd
            // 
            this.tsmiBFAdd.Name = "tsmiBFAdd";
            this.tsmiBFAdd.Size = new System.Drawing.Size(158, 24);
            this.tsmiBFAdd.Text = "添加新餐票";
            this.tsmiBFAdd.Click += new System.EventHandler(this.tsmiBFAdd_Click);
            // 
            // cmsBF
            // 
            this.cmsBF.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBFModifyItem,
            this.toolStripSeparator1,
            this.tsmiBFAppend,
            this.tsmiBFRemove});
            this.cmsBF.Name = "cmsBF";
            this.cmsBF.Size = new System.Drawing.Size(159, 82);
            // 
            // tsmiBFModifyItem
            // 
            this.tsmiBFModifyItem.Name = "tsmiBFModifyItem";
            this.tsmiBFModifyItem.Size = new System.Drawing.Size(158, 24);
            this.tsmiBFModifyItem.Text = "修改此项";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiBFAppend
            // 
            this.tsmiBFAppend.Name = "tsmiBFAppend";
            this.tsmiBFAppend.Size = new System.Drawing.Size(158, 24);
            this.tsmiBFAppend.Text = "添加新餐票";
            this.tsmiBFAppend.Click += new System.EventHandler(this.tsmiBFAppend_Click);
            // 
            // tsmiBFRemove
            // 
            this.tsmiBFRemove.Name = "tsmiBFRemove";
            this.tsmiBFRemove.Size = new System.Drawing.Size(158, 24);
            this.tsmiBFRemove.Text = "删除此餐票";
            // 
            // FrmBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.gbBFInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBF";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理餐费信息";
            this.Load += new System.EventHandler(this.FrmBF_Load);
            this.gbBFInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBFInfo)).EndInit();
            this.cmsBFAdd.ResumeLayout(false);
            this.cmsBF.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBFInfo;
        private System.Windows.Forms.DataGridView dgvBFInfo;
        private System.Windows.Forms.ContextMenuStrip cmsBFAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiBFAdd;
        private System.Windows.Forms.ContextMenuStrip cmsBF;
        private System.Windows.Forms.ToolStripMenuItem tsmiBFModifyItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBFAppend;
        private System.Windows.Forms.ToolStripMenuItem tsmiBFRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBFType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBFPrice;
    }
}