namespace hotelmgt
{
    partial class FrmMember
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
            this.dgvMemberInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.tbStaffPhone = new System.Windows.Forms.TextBox();
            this.lblStaffPhone = new System.Windows.Forms.Label();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMemberInfo
            // 
            this.dgvMemberInfo.AllowUserToAddRows = false;
            this.dgvMemberInfo.AllowUserToDeleteRows = false;
            this.dgvMemberInfo.AllowUserToResizeColumns = false;
            this.dgvMemberInfo.AllowUserToResizeRows = false;
            this.dgvMemberInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMemberInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberInfo.ColumnHeadersHeight = 29;
            this.dgvMemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMemberInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNo,
            this.cName,
            this.cPhone,
            this.cTime});
            this.dgvMemberInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberInfo.Location = new System.Drawing.Point(10, 120);
            this.dgvMemberInfo.MultiSelect = false;
            this.dgvMemberInfo.Name = "dgvMemberInfo";
            this.dgvMemberInfo.RowHeadersWidth = 29;
            this.dgvMemberInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMemberInfo.RowTemplate.Height = 23;
            this.dgvMemberInfo.Size = new System.Drawing.Size(666, 435);
            this.dgvMemberInfo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSearchStaff);
            this.panel1.Controls.Add(this.tbStaffPhone);
            this.panel1.Controls.Add(this.lblStaffPhone);
            this.panel1.Controls.Add(this.tbStaffName);
            this.panel1.Controls.Add(this.lblStaffName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(666, 110);
            this.panel1.TabIndex = 22;
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Location = new System.Drawing.Point(145, 55);
            this.btnSearchStaff.Margin = new System.Windows.Forms.Padding(10);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(105, 35);
            this.btnSearchStaff.TabIndex = 26;
            this.btnSearchStaff.Text = "查找会员";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            // 
            // tbStaffPhone
            // 
            this.tbStaffPhone.Location = new System.Drawing.Point(350, 15);
            this.tbStaffPhone.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.tbStaffPhone.Name = "tbStaffPhone";
            this.tbStaffPhone.Size = new System.Drawing.Size(150, 25);
            this.tbStaffPhone.TabIndex = 25;
            // 
            // lblStaffPhone
            // 
            this.lblStaffPhone.Location = new System.Drawing.Point(265, 15);
            this.lblStaffPhone.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblStaffPhone.Name = "lblStaffPhone";
            this.lblStaffPhone.Size = new System.Drawing.Size(85, 25);
            this.lblStaffPhone.TabIndex = 24;
            this.lblStaffPhone.Text = "手机号码：";
            this.lblStaffPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(100, 15);
            this.tbStaffName.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.Size = new System.Drawing.Size(150, 25);
            this.tbStaffName.TabIndex = 23;
            // 
            // lblStaffName
            // 
            this.lblStaffName.Location = new System.Drawing.Point(15, 15);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(85, 25);
            this.lblStaffName.TabIndex = 22;
            this.lblStaffName.Text = "员工姓名：";
            this.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cNo
            // 
            this.cNo.FillWeight = 40F;
            this.cNo.HeaderText = "序号";
            this.cNo.MinimumWidth = 6;
            this.cNo.Name = "cNo";
            this.cNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cName
            // 
            this.cName.HeaderText = "会员姓名";
            this.cName.MinimumWidth = 6;
            this.cName.Name = "cName";
            this.cName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "手机号码";
            this.cPhone.MinimumWidth = 6;
            this.cPhone.Name = "cPhone";
            this.cPhone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cTime
            // 
            this.cTime.HeaderText = "登记时间";
            this.cTime.MinimumWidth = 6;
            this.cTime.Name = "cTime";
            this.cTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "添加会员";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "删除会员";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(686, 565);
            this.Controls.Add(this.dgvMemberInfo);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "FrmMember";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理会员信息";
            this.Load += new System.EventHandler(this.FrmMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMemberInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbStaffPhone;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}