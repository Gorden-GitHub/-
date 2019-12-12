namespace hotelmgt
{
    partial class FrmRoomAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbIsHour = new System.Windows.Forms.CheckBox();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.gbRoomsAvailable = new System.Windows.Forms.GroupBox();
            this.lvRoomsAvailable = new System.Windows.Forms.ListView();
            this.chRoomNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBedNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoomPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIsHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbRoomsSelected = new System.Windows.Forms.GroupBox();
            this.lvRoomsSelected = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.gbRoomsAvailable.SuspendLayout();
            this.gbRoomsSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.cbIsHour);
            this.panel1.Controls.Add(this.cbRoomType);
            this.panel1.Controls.Add(this.lblRoomType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 40);
            this.panel1.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOK.Location = new System.Drawing.Point(452, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 35);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbIsHour
            // 
            this.cbIsHour.Location = new System.Drawing.Point(240, 10);
            this.cbIsHour.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.cbIsHour.Name = "cbIsHour";
            this.cbIsHour.Size = new System.Drawing.Size(75, 25);
            this.cbIsHour.TabIndex = 12;
            this.cbIsHour.Text = "钟点房";
            this.cbIsHour.UseVisualStyleBackColor = true;
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
            this.cbRoomType.Location = new System.Drawing.Point(90, 10);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(0, 10, 10, 7);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(135, 23);
            this.cbRoomType.TabIndex = 11;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Location = new System.Drawing.Point(5, 10);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(5, 10, 0, 5);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(85, 25);
            this.lblRoomType.TabIndex = 10;
            this.lblRoomType.Text = "房间类型：";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbRoomsAvailable
            // 
            this.gbRoomsAvailable.Controls.Add(this.lvRoomsAvailable);
            this.gbRoomsAvailable.Location = new System.Drawing.Point(13, 56);
            this.gbRoomsAvailable.Name = "gbRoomsAvailable";
            this.gbRoomsAvailable.Size = new System.Drawing.Size(556, 250);
            this.gbRoomsAvailable.TabIndex = 11;
            this.gbRoomsAvailable.TabStop = false;
            this.gbRoomsAvailable.Text = "可选房间";
            // 
            // lvRoomsAvailable
            // 
            this.lvRoomsAvailable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRoomNo,
            this.chRoomType,
            this.chBedNum,
            this.chRoomPrice,
            this.chIsHour,
            this.chHour});
            this.lvRoomsAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRoomsAvailable.FullRowSelect = true;
            this.lvRoomsAvailable.GridLines = true;
            this.lvRoomsAvailable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRoomsAvailable.HideSelection = false;
            this.lvRoomsAvailable.Location = new System.Drawing.Point(3, 21);
            this.lvRoomsAvailable.MultiSelect = false;
            this.lvRoomsAvailable.Name = "lvRoomsAvailable";
            this.lvRoomsAvailable.Size = new System.Drawing.Size(550, 226);
            this.lvRoomsAvailable.TabIndex = 8;
            this.lvRoomsAvailable.UseCompatibleStateImageBehavior = false;
            this.lvRoomsAvailable.View = System.Windows.Forms.View.Details;
            this.lvRoomsAvailable.DoubleClick += new System.EventHandler(this.lvRoomsAvailable_DoubleClick);
            // 
            // chRoomNo
            // 
            this.chRoomNo.Text = "房间编号";
            this.chRoomNo.Width = 80;
            // 
            // chRoomType
            // 
            this.chRoomType.Text = "房间类型";
            this.chRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chBedNum
            // 
            this.chBedNum.Text = "床位数";
            this.chBedNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chRoomPrice
            // 
            this.chRoomPrice.Text = "房间价格";
            this.chRoomPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chIsHour
            // 
            this.chIsHour.Text = "是否钟点房";
            this.chIsHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chIsHour.Width = 80;
            // 
            // chHour
            // 
            this.chHour.Text = "钟点房时长";
            this.chHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHour.Width = 80;
            // 
            // gbRoomsSelected
            // 
            this.gbRoomsSelected.Controls.Add(this.lvRoomsSelected);
            this.gbRoomsSelected.Location = new System.Drawing.Point(13, 312);
            this.gbRoomsSelected.Name = "gbRoomsSelected";
            this.gbRoomsSelected.Size = new System.Drawing.Size(556, 200);
            this.gbRoomsSelected.TabIndex = 12;
            this.gbRoomsSelected.TabStop = false;
            this.gbRoomsSelected.Text = "已选房间";
            // 
            // lvRoomsSelected
            // 
            this.lvRoomsSelected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvRoomsSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRoomsSelected.FullRowSelect = true;
            this.lvRoomsSelected.GridLines = true;
            this.lvRoomsSelected.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRoomsSelected.HideSelection = false;
            this.lvRoomsSelected.Location = new System.Drawing.Point(3, 21);
            this.lvRoomsSelected.MultiSelect = false;
            this.lvRoomsSelected.Name = "lvRoomsSelected";
            this.lvRoomsSelected.Size = new System.Drawing.Size(550, 176);
            this.lvRoomsSelected.TabIndex = 8;
            this.lvRoomsSelected.UseCompatibleStateImageBehavior = false;
            this.lvRoomsSelected.View = System.Windows.Forms.View.Details;
            this.lvRoomsSelected.DoubleClick += new System.EventHandler(this.lvRoomsSelected_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "房间编号";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "房间类型";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "床位数";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "房间价格";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "是否钟点房";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "钟点房时长";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 80;
            // 
            // FrmRoomAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(582, 525);
            this.Controls.Add(this.gbRoomsAvailable);
            this.Controls.Add(this.gbRoomsSelected);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoomAdd";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择房间";
            this.Load += new System.EventHandler(this.FrmRoomAdd_Load);
            this.panel1.ResumeLayout(false);
            this.gbRoomsAvailable.ResumeLayout(false);
            this.gbRoomsSelected.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbIsHour;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.GroupBox gbRoomsAvailable;
        private System.Windows.Forms.ListView lvRoomsAvailable;
        private System.Windows.Forms.ColumnHeader chRoomNo;
        private System.Windows.Forms.ColumnHeader chRoomType;
        private System.Windows.Forms.ColumnHeader chBedNum;
        private System.Windows.Forms.ColumnHeader chRoomPrice;
        private System.Windows.Forms.ColumnHeader chIsHour;
        private System.Windows.Forms.ColumnHeader chHour;
        private System.Windows.Forms.GroupBox gbRoomsSelected;
        private System.Windows.Forms.ListView lvRoomsSelected;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}