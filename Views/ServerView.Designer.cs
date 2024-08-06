namespace Carriage_SMS_Project.Views
{
    partial class ServerView
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMyIP = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ClientIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Computer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConnectionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PingTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommunicationsDisplay = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIP6 = new System.Windows.Forms.ListBox();
            this.lblIP4 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMyIP
            // 
            this.labelMyIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMyIP.AutoSize = true;
            this.labelMyIP.BackColor = System.Drawing.Color.White;
            this.labelMyIP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelMyIP.ForeColor = System.Drawing.Color.Black;
            this.labelMyIP.Location = new System.Drawing.Point(861, 280);
            this.labelMyIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMyIP.Name = "labelMyIP";
            this.labelMyIP.Size = new System.Drawing.Size(39, 13);
            this.labelMyIP.TabIndex = 75;
            this.labelMyIP.Text = "My IP";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientIP,
            this.Computer,
            this.Version,
            this.ConnectionID,
            this.ClientName,
            this.PingTime});
            this.listView1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 25);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1105, 211);
            this.listView1.TabIndex = 74;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ClientIP
            // 
            this.ClientIP.Text = "Client IP";
            this.ClientIP.Width = 136;
            // 
            // Computer
            // 
            this.Computer.Text = "Computer";
            this.Computer.Width = 120;
            // 
            // Version
            // 
            this.Version.Text = "Version";
            this.Version.Width = 179;
            // 
            // ConnectionID
            // 
            this.ConnectionID.Text = "ClientID";
            this.ConnectionID.Width = 70;
            // 
            // ClientName
            // 
            this.ClientName.Text = "Name";
            this.ClientName.Width = 127;
            // 
            // PingTime
            // 
            this.PingTime.Text = "Ping Time";
            this.PingTime.Width = 164;
            // 
            // CommunicationsDisplay
            // 
            this.CommunicationsDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommunicationsDisplay.Location = new System.Drawing.Point(4, 17);
            this.CommunicationsDisplay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CommunicationsDisplay.MinimumSize = new System.Drawing.Size(23, 18);
            this.CommunicationsDisplay.Name = "CommunicationsDisplay";
            this.CommunicationsDisplay.Size = new System.Drawing.Size(816, 221);
            this.CommunicationsDisplay.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CommunicationsDisplay);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(22, 253);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(824, 241);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Events";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(862, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 91;
            this.label3.Text = "IP6 addresses";
            // 
            // lblIP6
            // 
            this.lblIP6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIP6.Enabled = false;
            this.lblIP6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIP6.FormattingEnabled = true;
            this.lblIP6.ItemHeight = 12;
            this.lblIP6.Location = new System.Drawing.Point(862, 396);
            this.lblIP6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblIP6.Name = "lblIP6";
            this.lblIP6.Size = new System.Drawing.Size(275, 52);
            this.lblIP6.TabIndex = 90;
            // 
            // lblIP4
            // 
            this.lblIP4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIP4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIP4.FormattingEnabled = true;
            this.lblIP4.ItemHeight = 12;
            this.lblIP4.Location = new System.Drawing.Point(862, 338);
            this.lblIP4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblIP4.Name = "lblIP4";
            this.lblIP4.Size = new System.Drawing.Size(275, 16);
            this.lblIP4.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(862, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "Host IP4 Address";
            // 
            // ServerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIP6);
            this.Controls.Add(this.lblIP4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelMyIP);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ServerView";
            this.Size = new System.Drawing.Size(1150, 536);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMyIP;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ClientIP;
        private System.Windows.Forms.ColumnHeader Computer;
        private System.Windows.Forms.ColumnHeader Version;
        private System.Windows.Forms.ColumnHeader ConnectionID;
        private System.Windows.Forms.ColumnHeader ClientName;
        private System.Windows.Forms.ColumnHeader PingTime;
        private System.Windows.Forms.WebBrowser CommunicationsDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lblIP6;
        private System.Windows.Forms.ListBox lblIP4;
        private System.Windows.Forms.Label label4;
    }
}
