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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMemberInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.tbMemberPhone = new System.Windows.Forms.TextBox();
            this.lblMemberPhone = new System.Windows.Forms.Label();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
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
            this.dgvMemberInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberInfo.Location = new System.Drawing.Point(8, 96);
            this.dgvMemberInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMemberInfo.MultiSelect = false;
            this.dgvMemberInfo.Name = "dgvMemberInfo";
            this.dgvMemberInfo.ReadOnly = true;
            this.dgvMemberInfo.RowHeadersWidth = 29;
            this.dgvMemberInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMemberInfo.RowTemplate.Height = 23;
            this.dgvMemberInfo.Size = new System.Drawing.Size(533, 348);
            this.dgvMemberInfo.TabIndex = 0;
            this.dgvMemberInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMemberInfo_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.btnSearchMember);
            this.panel1.Controls.Add(this.tbMemberPhone);
            this.panel1.Controls.Add(this.lblMemberPhone);
            this.panel1.Controls.Add(this.tbMemberName);
            this.panel1.Controls.Add(this.lblMemberName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(533, 88);
            this.panel1.TabIndex = 22;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(216, 44);
            this.Delete.Margin = new System.Windows.Forms.Padding(8);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(84, 28);
            this.Delete.TabIndex = 28;
            this.Delete.Text = "删除会员";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(16, 44);
            this.Add.Margin = new System.Windows.Forms.Padding(8);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 28);
            this.Add.TabIndex = 27;
            this.Add.Text = "添加会员";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(116, 44);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(8);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(84, 28);
            this.btnSearchMember.TabIndex = 26;
            this.btnSearchMember.Text = "查找会员";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // tbMemberPhone
            // 
            this.tbMemberPhone.Location = new System.Drawing.Point(280, 12);
            this.tbMemberPhone.Margin = new System.Windows.Forms.Padding(0, 4, 8, 4);
            this.tbMemberPhone.Name = "tbMemberPhone";
            this.tbMemberPhone.Size = new System.Drawing.Size(121, 21);
            this.tbMemberPhone.TabIndex = 25;
            // 
            // lblMemberPhone
            // 
            this.lblMemberPhone.Location = new System.Drawing.Point(212, 12);
            this.lblMemberPhone.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.lblMemberPhone.Name = "lblMemberPhone";
            this.lblMemberPhone.Size = new System.Drawing.Size(68, 20);
            this.lblMemberPhone.TabIndex = 24;
            this.lblMemberPhone.Text = "手机号码：";
            this.lblMemberPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbMemberName
            // 
            this.tbMemberName.Location = new System.Drawing.Point(80, 12);
            this.tbMemberName.Margin = new System.Windows.Forms.Padding(0, 4, 8, 4);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(121, 21);
            this.tbMemberName.TabIndex = 23;
            // 
            // lblMemberName
            // 
            this.lblMemberName.Location = new System.Drawing.Point(12, 12);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(68, 20);
            this.lblMemberName.TabIndex = 22;
            this.lblMemberName.Text = "会员姓名：";
            this.lblMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(549, 452);
            this.Controls.Add(this.dgvMemberInfo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "FrmMember";
            this.Padding = new System.Windows.Forms.Padding(8);
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
        private System.Windows.Forms.TextBox tbMemberPhone;
        private System.Windows.Forms.Label lblMemberPhone;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
    }
}