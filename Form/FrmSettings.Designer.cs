namespace hotelmgt
{
    partial class FrmSettings
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
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbHourTime = new System.Windows.Forms.GroupBox();
            this.lblHourExtraChargePct = new System.Windows.Forms.Label();
            this.tbHourExtraCharge = new System.Windows.Forms.TextBox();
            this.lblHourExtraCharge = new System.Windows.Forms.Label();
            this.dtpHourLatest = new System.Windows.Forms.DateTimePicker();
            this.lblHourLatest = new System.Windows.Forms.Label();
            this.dtpHourEarliest = new System.Windows.Forms.DateTimePicker();
            this.lblHourEarliest = new System.Windows.Forms.Label();
            this.gbStdTime = new System.Windows.Forms.GroupBox();
            this.lblStdExtraCharge2 = new System.Windows.Forms.Label();
            this.dtpStdLeaveOver2 = new System.Windows.Forms.DateTimePicker();
            this.lblStdExtraChargePct2 = new System.Windows.Forms.Label();
            this.tbStdExtraCharge2 = new System.Windows.Forms.TextBox();
            this.lblStdLeaveOver2 = new System.Windows.Forms.Label();
            this.lblStdExtraCharge1 = new System.Windows.Forms.Label();
            this.dtpStdLeaveOver1 = new System.Windows.Forms.DateTimePicker();
            this.lblStdExtraChargePct1 = new System.Windows.Forms.Label();
            this.tbStdExtraCharge1 = new System.Windows.Forms.TextBox();
            this.lblStdLeaveOver1 = new System.Windows.Forms.Label();
            this.dtpStdLatest = new System.Windows.Forms.DateTimePicker();
            this.lblStdLatest = new System.Windows.Forms.Label();
            this.dtpStdEarliest = new System.Windows.Forms.DateTimePicker();
            this.lblStdEarliest = new System.Windows.Forms.Label();
            this.tcSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbHourTime.SuspendLayout();
            this.gbStdTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tabPage1);
            this.tcSettings.Controls.Add(this.tabPage2);
            this.tcSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSettings.ItemSize = new System.Drawing.Size(120, 30);
            this.tcSettings.Location = new System.Drawing.Point(10, 10);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(565, 430);
            this.tcSettings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcSettings.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbHourTime);
            this.tabPage1.Controls.Add(this.gbStdTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(557, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "入离时间";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(557, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbHourTime
            // 
            this.gbHourTime.Controls.Add(this.lblHourExtraChargePct);
            this.gbHourTime.Controls.Add(this.tbHourExtraCharge);
            this.gbHourTime.Controls.Add(this.lblHourExtraCharge);
            this.gbHourTime.Controls.Add(this.dtpHourLatest);
            this.gbHourTime.Controls.Add(this.lblHourLatest);
            this.gbHourTime.Controls.Add(this.dtpHourEarliest);
            this.gbHourTime.Controls.Add(this.lblHourEarliest);
            this.gbHourTime.Location = new System.Drawing.Point(6, 112);
            this.gbHourTime.Name = "gbHourTime";
            this.gbHourTime.Size = new System.Drawing.Size(545, 100);
            this.gbHourTime.TabIndex = 8;
            this.gbHourTime.TabStop = false;
            this.gbHourTime.Text = "钟点房";
            // 
            // lblHourExtraChargePct
            // 
            this.lblHourExtraChargePct.Location = new System.Drawing.Point(452, 60);
            this.lblHourExtraChargePct.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblHourExtraChargePct.Name = "lblHourExtraChargePct";
            this.lblHourExtraChargePct.Size = new System.Drawing.Size(25, 25);
            this.lblHourExtraChargePct.TabIndex = 16;
            this.lblHourExtraChargePct.Text = "%";
            this.lblHourExtraChargePct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbHourExtraCharge
            // 
            this.tbHourExtraCharge.HideSelection = false;
            this.tbHourExtraCharge.Location = new System.Drawing.Point(392, 60);
            this.tbHourExtraCharge.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.tbHourExtraCharge.Name = "tbHourExtraCharge";
            this.tbHourExtraCharge.Size = new System.Drawing.Size(50, 25);
            this.tbHourExtraCharge.TabIndex = 15;
            this.tbHourExtraCharge.Text = "50";
            this.tbHourExtraCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHourExtraCharge
            // 
            this.lblHourExtraCharge.Location = new System.Drawing.Point(232, 60);
            this.lblHourExtraCharge.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblHourExtraCharge.Name = "lblHourExtraCharge";
            this.lblHourExtraCharge.Size = new System.Drawing.Size(155, 25);
            this.lblHourExtraCharge.TabIndex = 12;
            this.lblHourExtraCharge.Text = "超时加收（/小时）：";
            this.lblHourExtraCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpHourLatest
            // 
            this.dtpHourLatest.CustomFormat = "HH:mm";
            this.dtpHourLatest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHourLatest.Location = new System.Drawing.Point(132, 60);
            this.dtpHourLatest.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.dtpHourLatest.Name = "dtpHourLatest";
            this.dtpHourLatest.ShowUpDown = true;
            this.dtpHourLatest.Size = new System.Drawing.Size(85, 25);
            this.dtpHourLatest.TabIndex = 11;
            this.dtpHourLatest.Value = new System.DateTime(2019, 11, 10, 21, 0, 0, 0);
            // 
            // lblHourLatest
            // 
            this.lblHourLatest.Location = new System.Drawing.Point(7, 60);
            this.lblHourLatest.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblHourLatest.Name = "lblHourLatest";
            this.lblHourLatest.Size = new System.Drawing.Size(120, 25);
            this.lblHourLatest.TabIndex = 10;
            this.lblHourLatest.Text = "最晚退房时间：";
            this.lblHourLatest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpHourEarliest
            // 
            this.dtpHourEarliest.CustomFormat = "HH:mm";
            this.dtpHourEarliest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHourEarliest.Location = new System.Drawing.Point(132, 25);
            this.dtpHourEarliest.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.dtpHourEarliest.Name = "dtpHourEarliest";
            this.dtpHourEarliest.ShowUpDown = true;
            this.dtpHourEarliest.Size = new System.Drawing.Size(85, 25);
            this.dtpHourEarliest.TabIndex = 9;
            this.dtpHourEarliest.Value = new System.DateTime(2019, 11, 10, 8, 0, 0, 0);
            // 
            // lblHourEarliest
            // 
            this.lblHourEarliest.Location = new System.Drawing.Point(7, 25);
            this.lblHourEarliest.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblHourEarliest.Name = "lblHourEarliest";
            this.lblHourEarliest.Size = new System.Drawing.Size(120, 25);
            this.lblHourEarliest.TabIndex = 8;
            this.lblHourEarliest.Text = "最早入住时间：";
            this.lblHourEarliest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbStdTime
            // 
            this.gbStdTime.Controls.Add(this.lblStdExtraCharge2);
            this.gbStdTime.Controls.Add(this.dtpStdLeaveOver2);
            this.gbStdTime.Controls.Add(this.lblStdExtraChargePct2);
            this.gbStdTime.Controls.Add(this.tbStdExtraCharge2);
            this.gbStdTime.Controls.Add(this.lblStdLeaveOver2);
            this.gbStdTime.Controls.Add(this.lblStdExtraCharge1);
            this.gbStdTime.Controls.Add(this.dtpStdLeaveOver1);
            this.gbStdTime.Controls.Add(this.lblStdExtraChargePct1);
            this.gbStdTime.Controls.Add(this.tbStdExtraCharge1);
            this.gbStdTime.Controls.Add(this.lblStdLeaveOver1);
            this.gbStdTime.Controls.Add(this.dtpStdLatest);
            this.gbStdTime.Controls.Add(this.lblStdLatest);
            this.gbStdTime.Controls.Add(this.dtpStdEarliest);
            this.gbStdTime.Controls.Add(this.lblStdEarliest);
            this.gbStdTime.Location = new System.Drawing.Point(6, 6);
            this.gbStdTime.Name = "gbStdTime";
            this.gbStdTime.Size = new System.Drawing.Size(545, 100);
            this.gbStdTime.TabIndex = 7;
            this.gbStdTime.TabStop = false;
            this.gbStdTime.Text = "标准房";
            // 
            // lblStdExtraCharge2
            // 
            this.lblStdExtraCharge2.Location = new System.Drawing.Point(402, 60);
            this.lblStdExtraCharge2.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblStdExtraCharge2.Name = "lblStdExtraCharge2";
            this.lblStdExtraCharge2.Size = new System.Drawing.Size(40, 25);
            this.lblStdExtraCharge2.TabIndex = 21;
            this.lblStdExtraCharge2.Text = "加收";
            this.lblStdExtraCharge2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStdLeaveOver2
            // 
            this.dtpStdLeaveOver2.CustomFormat = "HH:mm";
            this.dtpStdLeaveOver2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStdLeaveOver2.Location = new System.Drawing.Point(307, 60);
            this.dtpStdLeaveOver2.Margin = new System.Windows.Forms.Padding(5);
            this.dtpStdLeaveOver2.Name = "dtpStdLeaveOver2";
            this.dtpStdLeaveOver2.ShowUpDown = true;
            this.dtpStdLeaveOver2.Size = new System.Drawing.Size(85, 25);
            this.dtpStdLeaveOver2.TabIndex = 20;
            this.dtpStdLeaveOver2.Value = new System.DateTime(2019, 11, 10, 18, 0, 0, 0);
            // 
            // lblStdExtraChargePct2
            // 
            this.lblStdExtraChargePct2.Location = new System.Drawing.Point(507, 60);
            this.lblStdExtraChargePct2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblStdExtraChargePct2.Name = "lblStdExtraChargePct2";
            this.lblStdExtraChargePct2.Size = new System.Drawing.Size(25, 25);
            this.lblStdExtraChargePct2.TabIndex = 19;
            this.lblStdExtraChargePct2.Text = "%";
            this.lblStdExtraChargePct2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbStdExtraCharge2
            // 
            this.tbStdExtraCharge2.HideSelection = false;
            this.tbStdExtraCharge2.Location = new System.Drawing.Point(447, 60);
            this.tbStdExtraCharge2.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.tbStdExtraCharge2.Name = "tbStdExtraCharge2";
            this.tbStdExtraCharge2.Size = new System.Drawing.Size(50, 25);
            this.tbStdExtraCharge2.TabIndex = 18;
            this.tbStdExtraCharge2.Text = "100";
            this.tbStdExtraCharge2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStdLeaveOver2
            // 
            this.lblStdLeaveOver2.Location = new System.Drawing.Point(232, 60);
            this.lblStdLeaveOver2.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblStdLeaveOver2.Name = "lblStdLeaveOver2";
            this.lblStdLeaveOver2.Size = new System.Drawing.Size(70, 25);
            this.lblStdLeaveOver2.TabIndex = 17;
            this.lblStdLeaveOver2.Text = "退房超过";
            this.lblStdLeaveOver2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStdExtraCharge1
            // 
            this.lblStdExtraCharge1.Location = new System.Drawing.Point(402, 25);
            this.lblStdExtraCharge1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblStdExtraCharge1.Name = "lblStdExtraCharge1";
            this.lblStdExtraCharge1.Size = new System.Drawing.Size(40, 25);
            this.lblStdExtraCharge1.TabIndex = 16;
            this.lblStdExtraCharge1.Text = "加收";
            this.lblStdExtraCharge1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStdLeaveOver1
            // 
            this.dtpStdLeaveOver1.CustomFormat = "HH:mm";
            this.dtpStdLeaveOver1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStdLeaveOver1.Location = new System.Drawing.Point(307, 25);
            this.dtpStdLeaveOver1.Margin = new System.Windows.Forms.Padding(5);
            this.dtpStdLeaveOver1.Name = "dtpStdLeaveOver1";
            this.dtpStdLeaveOver1.ShowUpDown = true;
            this.dtpStdLeaveOver1.Size = new System.Drawing.Size(85, 25);
            this.dtpStdLeaveOver1.TabIndex = 15;
            this.dtpStdLeaveOver1.Value = new System.DateTime(2019, 11, 10, 13, 0, 0, 0);
            // 
            // lblStdExtraChargePct1
            // 
            this.lblStdExtraChargePct1.Location = new System.Drawing.Point(507, 25);
            this.lblStdExtraChargePct1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblStdExtraChargePct1.Name = "lblStdExtraChargePct1";
            this.lblStdExtraChargePct1.Size = new System.Drawing.Size(25, 25);
            this.lblStdExtraChargePct1.TabIndex = 14;
            this.lblStdExtraChargePct1.Text = "%";
            this.lblStdExtraChargePct1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbStdExtraCharge1
            // 
            this.tbStdExtraCharge1.HideSelection = false;
            this.tbStdExtraCharge1.Location = new System.Drawing.Point(447, 25);
            this.tbStdExtraCharge1.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.tbStdExtraCharge1.Name = "tbStdExtraCharge1";
            this.tbStdExtraCharge1.Size = new System.Drawing.Size(50, 25);
            this.tbStdExtraCharge1.TabIndex = 13;
            this.tbStdExtraCharge1.Text = "50";
            this.tbStdExtraCharge1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStdLeaveOver1
            // 
            this.lblStdLeaveOver1.Location = new System.Drawing.Point(232, 25);
            this.lblStdLeaveOver1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblStdLeaveOver1.Name = "lblStdLeaveOver1";
            this.lblStdLeaveOver1.Size = new System.Drawing.Size(70, 25);
            this.lblStdLeaveOver1.TabIndex = 12;
            this.lblStdLeaveOver1.Text = "退房超过";
            this.lblStdLeaveOver1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStdLatest
            // 
            this.dtpStdLatest.CustomFormat = "HH:mm";
            this.dtpStdLatest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStdLatest.Location = new System.Drawing.Point(132, 60);
            this.dtpStdLatest.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.dtpStdLatest.Name = "dtpStdLatest";
            this.dtpStdLatest.ShowUpDown = true;
            this.dtpStdLatest.Size = new System.Drawing.Size(85, 25);
            this.dtpStdLatest.TabIndex = 11;
            this.dtpStdLatest.Value = new System.DateTime(2019, 11, 10, 13, 0, 0, 0);
            // 
            // lblStdLatest
            // 
            this.lblStdLatest.Location = new System.Drawing.Point(7, 60);
            this.lblStdLatest.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblStdLatest.Name = "lblStdLatest";
            this.lblStdLatest.Size = new System.Drawing.Size(120, 25);
            this.lblStdLatest.TabIndex = 10;
            this.lblStdLatest.Text = "最晚退房时间：";
            this.lblStdLatest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStdEarliest
            // 
            this.dtpStdEarliest.CustomFormat = "HH:mm";
            this.dtpStdEarliest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStdEarliest.Location = new System.Drawing.Point(132, 25);
            this.dtpStdEarliest.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.dtpStdEarliest.Name = "dtpStdEarliest";
            this.dtpStdEarliest.ShowUpDown = true;
            this.dtpStdEarliest.Size = new System.Drawing.Size(85, 25);
            this.dtpStdEarliest.TabIndex = 9;
            this.dtpStdEarliest.Value = new System.DateTime(2019, 11, 10, 8, 0, 0, 0);
            // 
            // lblStdEarliest
            // 
            this.lblStdEarliest.Location = new System.Drawing.Point(7, 25);
            this.lblStdEarliest.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblStdEarliest.Name = "lblStdEarliest";
            this.lblStdEarliest.Size = new System.Drawing.Size(120, 25);
            this.lblStdEarliest.TabIndex = 8;
            this.lblStdEarliest.Text = "最早入住时间：";
            this.lblStdEarliest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.tcSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSetting";
            this.tcSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbHourTime.ResumeLayout(false);
            this.gbHourTime.PerformLayout();
            this.gbStdTime.ResumeLayout(false);
            this.gbStdTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbHourTime;
        private System.Windows.Forms.Label lblHourExtraChargePct;
        private System.Windows.Forms.TextBox tbHourExtraCharge;
        private System.Windows.Forms.Label lblHourExtraCharge;
        private System.Windows.Forms.DateTimePicker dtpHourLatest;
        private System.Windows.Forms.Label lblHourLatest;
        private System.Windows.Forms.DateTimePicker dtpHourEarliest;
        private System.Windows.Forms.Label lblHourEarliest;
        private System.Windows.Forms.GroupBox gbStdTime;
        private System.Windows.Forms.Label lblStdExtraCharge2;
        private System.Windows.Forms.DateTimePicker dtpStdLeaveOver2;
        private System.Windows.Forms.Label lblStdExtraChargePct2;
        private System.Windows.Forms.TextBox tbStdExtraCharge2;
        private System.Windows.Forms.Label lblStdLeaveOver2;
        private System.Windows.Forms.Label lblStdExtraCharge1;
        private System.Windows.Forms.DateTimePicker dtpStdLeaveOver1;
        private System.Windows.Forms.Label lblStdExtraChargePct1;
        private System.Windows.Forms.TextBox tbStdExtraCharge1;
        private System.Windows.Forms.Label lblStdLeaveOver1;
        private System.Windows.Forms.DateTimePicker dtpStdLatest;
        private System.Windows.Forms.Label lblStdLatest;
        private System.Windows.Forms.DateTimePicker dtpStdEarliest;
        private System.Windows.Forms.Label lblStdEarliest;
        private System.Windows.Forms.TabPage tabPage2;
    }
}