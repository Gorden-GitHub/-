namespace hotelmgt
{
    partial class FrmBFSell
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
            this.tbRoomNo = new System.Windows.Forms.TextBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblBFType = new System.Windows.Forms.Label();
            this.cbBFType = new System.Windows.Forms.ComboBox();
            this.lblBFPrice = new System.Windows.Forms.Label();
            this.lblBFPriceVal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblBFNum = new System.Windows.Forms.Label();
            this.tbBFNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbRoomNo
            // 
            this.tbRoomNo.HideSelection = false;
            this.tbRoomNo.Location = new System.Drawing.Point(135, 30);
            this.tbRoomNo.Margin = new System.Windows.Forms.Padding(5);
            this.tbRoomNo.Name = "tbRoomNo";
            this.tbRoomNo.Size = new System.Drawing.Size(150, 25);
            this.tbRoomNo.TabIndex = 1;
            this.tbRoomNo.Text = "0201";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.Location = new System.Drawing.Point(45, 30);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(85, 25);
            this.lblRoomNo.TabIndex = 0;
            this.lblRoomNo.Text = "房间编号：";
            this.lblRoomNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBFType
            // 
            this.lblBFType.Location = new System.Drawing.Point(45, 70);
            this.lblBFType.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblBFType.Name = "lblBFType";
            this.lblBFType.Size = new System.Drawing.Size(85, 25);
            this.lblBFType.TabIndex = 2;
            this.lblBFType.Text = "餐票类型：";
            this.lblBFType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBFType
            // 
            this.cbBFType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBFType.ItemHeight = 15;
            this.cbBFType.Items.AddRange(new object[] {
            "赠送",
            "标准早餐票"});
            this.cbBFType.Location = new System.Drawing.Point(135, 70);
            this.cbBFType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 7);
            this.cbBFType.Name = "cbBFType";
            this.cbBFType.Size = new System.Drawing.Size(150, 23);
            this.cbBFType.TabIndex = 3;
            // 
            // lblBFPrice
            // 
            this.lblBFPrice.Location = new System.Drawing.Point(45, 150);
            this.lblBFPrice.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblBFPrice.Name = "lblBFPrice";
            this.lblBFPrice.Size = new System.Drawing.Size(85, 25);
            this.lblBFPrice.TabIndex = 6;
            this.lblBFPrice.Text = "应收餐费：";
            this.lblBFPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBFPriceVal
            // 
            this.lblBFPriceVal.Location = new System.Drawing.Point(132, 150);
            this.lblBFPriceVal.Margin = new System.Windows.Forms.Padding(5);
            this.lblBFPriceVal.Name = "lblBFPriceVal";
            this.lblBFPriceVal.Size = new System.Drawing.Size(153, 25);
            this.lblBFPriceVal.TabIndex = 7;
            this.lblBFPriceVal.Text = "0";
            this.lblBFPriceVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(171, 195);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(56, 195);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 35);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "记账";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblBFNum
            // 
            this.lblBFNum.Location = new System.Drawing.Point(45, 110);
            this.lblBFNum.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblBFNum.Name = "lblBFNum";
            this.lblBFNum.Size = new System.Drawing.Size(85, 25);
            this.lblBFNum.TabIndex = 4;
            this.lblBFNum.Text = "餐票数量：";
            this.lblBFNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBFNum
            // 
            this.tbBFNum.HideSelection = false;
            this.tbBFNum.Location = new System.Drawing.Point(135, 110);
            this.tbBFNum.Margin = new System.Windows.Forms.Padding(5);
            this.tbBFNum.Name = "tbBFNum";
            this.tbBFNum.Size = new System.Drawing.Size(150, 25);
            this.tbBFNum.TabIndex = 5;
            this.tbBFNum.Text = "1";
            // 
            // FrmBFSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(332, 253);
            this.Controls.Add(this.tbBFNum);
            this.Controls.Add(this.lblBFNum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblBFPriceVal);
            this.Controls.Add(this.lblBFPrice);
            this.Controls.Add(this.cbBFType);
            this.Controls.Add(this.lblBFType);
            this.Controls.Add(this.tbRoomNo);
            this.Controls.Add(this.lblRoomNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBFSell";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出售/赠送早餐票";
            this.Load += new System.EventHandler(this.FrmSellBF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRoomNo;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblBFType;
        private System.Windows.Forms.ComboBox cbBFType;
        private System.Windows.Forms.Label lblBFPrice;
        private System.Windows.Forms.Label lblBFPriceVal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblBFNum;
        private System.Windows.Forms.TextBox tbBFNum;
    }
}