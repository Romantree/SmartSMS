namespace Carriage_SMS_Project.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.Header = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.lblTime = new Carriage_SMS_Project.Styler.RoundLabel();
            this.lblYear = new Carriage_SMS_Project.Styler.RoundLabel();
            this._btnSetting = new Carriage_SMS_Project.Styler.RoundButton1();
            this._btnServer = new Carriage_SMS_Project.Styler.RoundButton1();
            this._btnOpc = new Carriage_SMS_Project.Styler.RoundButton1();
            this._btnMessage = new Carriage_SMS_Project.Styler.RoundButton1();
            this._btnHome = new Carriage_SMS_Project.Styler.RoundButton1();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnServer = new System.Windows.Forms.PictureBox();
            this.btnMessage = new System.Windows.Forms.PictureBox();
            this.btnRealtime = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.PictureBox();
            this.btnOpc = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pMain = new System.Windows.Forms.Panel();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRealtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.btnMinimize);
            this.Header.Controls.Add(this.lblTime);
            this.Header.Controls.Add(this.lblYear);
            this.Header.Controls.Add(this._btnSetting);
            this.Header.Controls.Add(this._btnServer);
            this.Header.Controls.Add(this._btnOpc);
            this.Header.Controls.Add(this._btnMessage);
            this.Header.Controls.Add(this._btnHome);
            this.Header.Controls.Add(this.label7);
            this.Header.Controls.Add(this.label6);
            this.Header.Controls.Add(this.btnServer);
            this.Header.Controls.Add(this.btnMessage);
            this.Header.Controls.Add(this.btnRealtime);
            this.Header.Controls.Add(this.btnSetting);
            this.Header.Controls.Add(this.btnOpc);
            this.Header.Controls.Add(this.btnHome);
            this.Header.Controls.Add(this.btnClose);
            this.Header.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Header.Location = new System.Drawing.Point(12, 12);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1057, 176);
            this.Header.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(931, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(51, 40);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 237;
            this.btnMinimize.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(770, 116);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(111, 30);
            this.lblTime.TabIndex = 235;
            this.lblTime.Text = "--------------";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(765, 80);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(127, 34);
            this.lblYear.TabIndex = 234;
            this.lblYear.Text = "--------------";
            // 
            // _btnSetting
            // 
            this._btnSetting.BackColor = System.Drawing.Color.Black;
            this._btnSetting.BackgroundColor = System.Drawing.Color.Black;
            this._btnSetting.BorderColor = System.Drawing.Color.White;
            this._btnSetting.BorderRadius = 20;
            this._btnSetting.BorderSize = 0;
            this._btnSetting.FlatAppearance.BorderSize = 0;
            this._btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this._btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this._btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSetting.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSetting.ForeColor = System.Drawing.Color.White;
            this._btnSetting.Location = new System.Drawing.Point(630, 130);
            this._btnSetting.Name = "_btnSetting";
            this._btnSetting.Size = new System.Drawing.Size(96, 33);
            this._btnSetting.TabIndex = 233;
            this._btnSetting.Text = "SETTING";
            this._btnSetting.TextColor = System.Drawing.Color.White;
            this._btnSetting.UseVisualStyleBackColor = false;
            // 
            // _btnServer
            // 
            this._btnServer.BackColor = System.Drawing.Color.Black;
            this._btnServer.BackgroundColor = System.Drawing.Color.Black;
            this._btnServer.BorderColor = System.Drawing.Color.White;
            this._btnServer.BorderRadius = 20;
            this._btnServer.BorderSize = 0;
            this._btnServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this._btnServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this._btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnServer.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnServer.ForeColor = System.Drawing.Color.White;
            this._btnServer.Location = new System.Drawing.Point(507, 130);
            this._btnServer.Name = "_btnServer";
            this._btnServer.Size = new System.Drawing.Size(96, 33);
            this._btnServer.TabIndex = 232;
            this._btnServer.Text = "SERVER";
            this._btnServer.TextColor = System.Drawing.Color.White;
            this._btnServer.UseVisualStyleBackColor = false;
            // 
            // _btnOpc
            // 
            this._btnOpc.BackColor = System.Drawing.Color.Black;
            this._btnOpc.BackgroundColor = System.Drawing.Color.Black;
            this._btnOpc.BorderColor = System.Drawing.Color.White;
            this._btnOpc.BorderRadius = 20;
            this._btnOpc.BorderSize = 0;
            this._btnOpc.FlatAppearance.BorderSize = 0;
            this._btnOpc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this._btnOpc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this._btnOpc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOpc.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnOpc.ForeColor = System.Drawing.Color.White;
            this._btnOpc.Location = new System.Drawing.Point(373, 130);
            this._btnOpc.Name = "_btnOpc";
            this._btnOpc.Size = new System.Drawing.Size(96, 33);
            this._btnOpc.TabIndex = 231;
            this._btnOpc.Text = "OPC";
            this._btnOpc.TextColor = System.Drawing.Color.White;
            this._btnOpc.UseVisualStyleBackColor = false;
            // 
            // _btnMessage
            // 
            this._btnMessage.BackColor = System.Drawing.Color.Black;
            this._btnMessage.BackgroundColor = System.Drawing.Color.Black;
            this._btnMessage.BorderColor = System.Drawing.Color.White;
            this._btnMessage.BorderRadius = 20;
            this._btnMessage.BorderSize = 0;
            this._btnMessage.FlatAppearance.BorderSize = 0;
            this._btnMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this._btnMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this._btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMessage.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMessage.ForeColor = System.Drawing.Color.White;
            this._btnMessage.Location = new System.Drawing.Point(240, 130);
            this._btnMessage.Name = "_btnMessage";
            this._btnMessage.Size = new System.Drawing.Size(96, 33);
            this._btnMessage.TabIndex = 230;
            this._btnMessage.Text = "MESSAGE";
            this._btnMessage.TextColor = System.Drawing.Color.White;
            this._btnMessage.UseVisualStyleBackColor = false;
            // 
            // _btnHome
            // 
            this._btnHome.BackColor = System.Drawing.Color.Black;
            this._btnHome.BackgroundColor = System.Drawing.Color.Black;
            this._btnHome.BorderColor = System.Drawing.Color.White;
            this._btnHome.BorderRadius = 19;
            this._btnHome.BorderSize = 0;
            this._btnHome.FlatAppearance.BorderSize = 0;
            this._btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this._btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this._btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnHome.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnHome.ForeColor = System.Drawing.Color.White;
            this._btnHome.Location = new System.Drawing.Point(105, 130);
            this._btnHome.Name = "_btnHome";
            this._btnHome.Size = new System.Drawing.Size(96, 33);
            this._btnHome.TabIndex = 229;
            this._btnHome.Text = "HOME";
            this._btnHome.TextColor = System.Drawing.Color.White;
            this._btnHome.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(50)))));
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(768, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 17);
            this.label7.TabIndex = 226;
            this.label7.Text = "Ver. 24.08.0.01";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(14, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "MENU";
            // 
            // btnServer
            // 
            this.btnServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServer.Image = ((System.Drawing.Image)(resources.GetObject("btnServer.Image")));
            this.btnServer.Location = new System.Drawing.Point(522, 50);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(63, 63);
            this.btnServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnServer.TabIndex = 9;
            this.btnServer.TabStop = false;
            // 
            // btnMessage
            // 
            this.btnMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnMessage.Image")));
            this.btnMessage.Location = new System.Drawing.Point(257, 50);
            this.btnMessage.Margin = new System.Windows.Forms.Padding(7);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Padding = new System.Windows.Forms.Padding(4);
            this.btnMessage.Size = new System.Drawing.Size(65, 64);
            this.btnMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMessage.TabIndex = 11;
            this.btnMessage.TabStop = false;
            // 
            // btnRealtime
            // 
            this.btnRealtime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealtime.Image = global::Carriage_SMS_Project.Properties.Resources.Communication_;
            this.btnRealtime.Location = new System.Drawing.Point(18, 8);
            this.btnRealtime.Name = "btnRealtime";
            this.btnRealtime.Size = new System.Drawing.Size(55, 54);
            this.btnRealtime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRealtime.TabIndex = 5;
            this.btnRealtime.TabStop = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(648, 48);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(4);
            this.btnSetting.Size = new System.Drawing.Size(63, 66);
            this.btnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetting.TabIndex = 3;
            this.btnSetting.TabStop = false;
            // 
            // btnOpc
            // 
            this.btnOpc.BackColor = System.Drawing.Color.White;
            this.btnOpc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpc.Image = ((System.Drawing.Image)(resources.GetObject("btnOpc.Image")));
            this.btnOpc.Location = new System.Drawing.Point(389, 50);
            this.btnOpc.Name = "btnOpc";
            this.btnOpc.Size = new System.Drawing.Size(64, 64);
            this.btnOpc.TabIndex = 2;
            this.btnOpc.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(121, 50);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(4);
            this.btnHome.Size = new System.Drawing.Size(64, 64);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(999, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(12, 194);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1057, 4);
            this.panel6.TabIndex = 17;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(13, 700);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 4);
            this.panel2.TabIndex = 18;
            // 
            // pMain
            // 
            this.pMain.Location = new System.Drawing.Point(12, 213);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1057, 481);
            this.pMain.TabIndex = 18;
            // 
            // Timer2
            // 
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1081, 745);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Header);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRealtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox btnSetting;
        private System.Windows.Forms.PictureBox btnOpc;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnServer;
        private System.Windows.Forms.PictureBox btnMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel panel2;
        public Styler.RoundButton1 _btnHome;
        public Styler.RoundButton1 _btnSetting;
        public Styler.RoundButton1 _btnServer;
        public Styler.RoundButton1 _btnOpc;
        public Styler.RoundButton1 _btnMessage;
        private System.Windows.Forms.Panel pMain;
        private Styler.RoundLabel lblTime;
        private Styler.RoundLabel lblYear;
        private System.Windows.Forms.PictureBox btnRealtime;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.PictureBox btnMinimize;
    }
}