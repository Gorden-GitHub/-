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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbBFInfo = new System.Windows.Forms.GroupBox();
            this.dgvBFInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTicketType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTicketPrice = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.gbBFInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBFInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBFInfo
            // 
            this.gbBFInfo.Controls.Add(this.dgvBFInfo);
            this.gbBFInfo.Location = new System.Drawing.Point(6, 99);
            this.gbBFInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbBFInfo.Name = "gbBFInfo";
            this.gbBFInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbBFInfo.Size = new System.Drawing.Size(290, 266);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBFInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBFInfo.ColumnHeadersHeight = 29;
            this.dgvBFInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBFInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBFInfo.Location = new System.Drawing.Point(2, 16);
            this.dgvBFInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBFInfo.MultiSelect = false;
            this.dgvBFInfo.Name = "dgvBFInfo";
            this.dgvBFInfo.RowHeadersWidth = 29;
            this.dgvBFInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBFInfo.RowTemplate.Height = 27;
            this.dgvBFInfo.Size = new System.Drawing.Size(286, 248);
            this.dgvBFInfo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.tbTicketPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbTicketType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 100);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "餐票类型：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTicketType
            // 
            this.tbTicketType.Location = new System.Drawing.Point(59, 3);
            this.tbTicketType.Name = "tbTicketType";
            this.tbTicketType.Size = new System.Drawing.Size(100, 21);
            this.tbTicketType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "餐票价格：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTicketPrice
            // 
            this.tbTicketPrice.Location = new System.Drawing.Point(59, 33);
            this.tbTicketPrice.Name = "tbTicketPrice";
            this.tbTicketPrice.Size = new System.Drawing.Size(100, 21);
            this.tbTicketPrice.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(35, 60);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "添加餐费";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(169, 60);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "删除餐费";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // FrmBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(306, 371);
            this.Controls.Add(this.gbBFInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBF";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理餐费信息";
            this.Load += new System.EventHandler(this.FrmBF_Load);
            this.gbBFInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBFInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBFInfo;
        private System.Windows.Forms.DataGridView dgvBFInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTicketType;
        private System.Windows.Forms.TextBox tbTicketPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
    }
}