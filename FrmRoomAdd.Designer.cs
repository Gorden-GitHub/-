namespace hotelmgr
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
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lvRoomInfo = new System.Windows.Forms.ListView();
            this.chRoomNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBedNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIsHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoomPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbIsHour = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cbRoomType.Location = new System.Drawing.Point(99, 19);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(0, 10, 10, 7);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(135, 23);
            this.cbRoomType.TabIndex = 6;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Location = new System.Drawing.Point(14, 19);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(5, 10, 0, 5);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(85, 25);
            this.lblRoomType.TabIndex = 5;
            this.lblRoomType.Text = "房间类型：";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvRoomInfo
            // 
            this.lvRoomInfo.CheckBoxes = true;
            this.lvRoomInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRoomNo,
            this.chRoomType,
            this.chBedNum,
            this.chRoomPrice,
            this.chIsHour,
            this.chHour});
            this.lvRoomInfo.FullRowSelect = true;
            this.lvRoomInfo.GridLines = true;
            this.lvRoomInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRoomInfo.HideSelection = false;
            this.lvRoomInfo.Location = new System.Drawing.Point(14, 54);
            this.lvRoomInfo.Margin = new System.Windows.Forms.Padding(5);
            this.lvRoomInfo.Name = "lvRoomInfo";
            this.lvRoomInfo.Size = new System.Drawing.Size(554, 285);
            this.lvRoomInfo.TabIndex = 7;
            this.lvRoomInfo.UseCompatibleStateImageBehavior = false;
            this.lvRoomInfo.View = System.Windows.Forms.View.Details;
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
            // chRoomPrice
            // 
            this.chRoomPrice.Text = "房间价格";
            this.chRoomPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbIsHour
            // 
            this.cbIsHour.Location = new System.Drawing.Point(249, 19);
            this.cbIsHour.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.cbIsHour.Name = "cbIsHour";
            this.cbIsHour.Size = new System.Drawing.Size(75, 25);
            this.cbIsHour.TabIndex = 8;
            this.cbIsHour.Text = "钟点房";
            this.cbIsHour.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOK.Location = new System.Drawing.Point(463, 16);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 7, 5, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 31);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmRoomAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbIsHour);
            this.Controls.Add(this.lvRoomInfo);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.lblRoomType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoomAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择房间";
            this.Load += new System.EventHandler(this.FrmRoomAdd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ColumnHeader chRoomNo;
        private System.Windows.Forms.ColumnHeader chRoomType;
        private System.Windows.Forms.ColumnHeader chBedNum;
        private System.Windows.Forms.ColumnHeader chIsHour;
        private System.Windows.Forms.ColumnHeader chRoomPrice;
        private System.Windows.Forms.CheckBox cbIsHour;
        private System.Windows.Forms.ColumnHeader chHour;
        private System.Windows.Forms.ListView lvRoomInfo;
        private System.Windows.Forms.Button btnOK;
    }
}