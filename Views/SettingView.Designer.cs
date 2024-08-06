namespace Carriage_SMS_Project.Views
{
    partial class SettingView
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
            this.txtLogger = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWrite = new Carriage_SMS_Project.Styler.RoundButton1();
            this.grBox2 = new System.Windows.Forms.GroupBox();
            this.listLoggerBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRcv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.labelConnectionStuff = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxServerListeningPort = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSendToClients = new Carriage_SMS_Project.Styler.RoundButton1();
            this.buttonSendDataToServer = new Carriage_SMS_Project.Styler.RoundButton1();
            this.buttonDisconnect = new Carriage_SMS_Project.Styler.RoundButton1();
            this.buttonConnectToServer = new Carriage_SMS_Project.Styler.RoundButton1();
            this.grBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogger
            // 
            this.txtLogger.Location = new System.Drawing.Point(46, 19);
            this.txtLogger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLogger.Name = "txtLogger";
            this.txtLogger.Size = new System.Drawing.Size(348, 23);
            this.txtLogger.TabIndex = 3;
            this.txtLogger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogger_KeyDown);
            this.txtLogger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogger_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Log";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.Black;
            this.btnWrite.BackgroundColor = System.Drawing.Color.Black;
            this.btnWrite.BorderColor = System.Drawing.Color.White;
            this.btnWrite.BorderRadius = 20;
            this.btnWrite.BorderSize = 0;
            this.btnWrite.FlatAppearance.BorderSize = 0;
            this.btnWrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite.Font = new System.Drawing.Font("Impact", 9.75F);
            this.btnWrite.ForeColor = System.Drawing.Color.White;
            this.btnWrite.Location = new System.Drawing.Point(399, 13);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(61, 32);
            this.btnWrite.TabIndex = 235;
            this.btnWrite.Text = "Write";
            this.btnWrite.TextColor = System.Drawing.Color.White;
            this.btnWrite.UseVisualStyleBackColor = false;
            // 
            // grBox2
            // 
            this.grBox2.Controls.Add(this.listLoggerBox);
            this.grBox2.Controls.Add(this.txtLogger);
            this.grBox2.Controls.Add(this.btnWrite);
            this.grBox2.Controls.Add(this.label5);
            this.grBox2.Controls.Add(this.label6);
            this.grBox2.Font = new System.Drawing.Font("Impact", 9.75F);
            this.grBox2.Location = new System.Drawing.Point(559, 9);
            this.grBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grBox2.Name = "grBox2";
            this.grBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grBox2.Size = new System.Drawing.Size(465, 166);
            this.grBox2.TabIndex = 237;
            this.grBox2.TabStop = false;
            this.grBox2.Text = "Memo";
            // 
            // listLoggerBox
            // 
            this.listLoggerBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.listLoggerBox.FormattingEnabled = true;
            this.listLoggerBox.ItemHeight = 12;
            this.listLoggerBox.Location = new System.Drawing.Point(46, 56);
            this.listLoggerBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listLoggerBox.Name = "listLoggerBox";
            this.listLoggerBox.Size = new System.Drawing.Size(415, 100);
            this.listLoggerBox.TabIndex = 237;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(704, 281);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 12);
            this.label8.TabIndex = 261;
            this.label8.Text = "File Drop";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(704, 298);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 52);
            this.panel1.TabIndex = 260;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(217, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 12);
            this.label7.TabIndex = 259;
            this.label7.Text = "Incoming Text";
            // 
            // textBoxRcv
            // 
            this.textBoxRcv.Location = new System.Drawing.Point(214, 358);
            this.textBoxRcv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRcv.Multiline = true;
            this.textBoxRcv.Name = "textBoxRcv";
            this.textBoxRcv.ReadOnly = true;
            this.textBoxRcv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRcv.Size = new System.Drawing.Size(818, 133);
            this.textBoxRcv.TabIndex = 257;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(34, 304);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(175, 187);
            this.groupBox1.TabIndex = 256;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other Clients";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(4, 19);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(167, 165);
            this.listBox1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(937, 232);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 12);
            this.label9.TabIndex = 255;
            this.label9.Text = "Another number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(934, 178);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 12);
            this.label10.TabIndex = 254;
            this.label10.Text = "Number to send:";
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxNum2.Location = new System.Drawing.Point(938, 252);
            this.textBoxNum2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNum2.MaxLength = 10;
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(88, 21);
            this.textBoxNum2.TabIndex = 253;
            this.textBoxNum2.Text = "54321";
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxNum1.Location = new System.Drawing.Point(938, 199);
            this.textBoxNum1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNum1.MaxLength = 10;
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(88, 21);
            this.textBoxNum1.TabIndex = 252;
            this.textBoxNum1.Text = "123456";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(704, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 12);
            this.label11.TabIndex = 251;
            this.label11.Text = "Text to send:";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(28, 199);
            this.textBoxText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxText.Size = new System.Drawing.Size(895, 72);
            this.textBoxText.TabIndex = 250;
            // 
            // labelConnectionStuff
            // 
            this.labelConnectionStuff.AutoSize = true;
            this.labelConnectionStuff.Location = new System.Drawing.Point(30, 239);
            this.labelConnectionStuff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnectionStuff.Name = "labelConnectionStuff";
            this.labelConnectionStuff.Size = new System.Drawing.Size(17, 12);
            this.labelConnectionStuff.TabIndex = 248;
            this.labelConnectionStuff.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 131);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 22);
            this.pictureBox1.TabIndex = 246;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(25, 79);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 12);
            this.label12.TabIndex = 245;
            this.label12.Text = "Server\'s Listening Port:";
            // 
            // textBoxServerListeningPort
            // 
            this.textBoxServerListeningPort.Location = new System.Drawing.Point(194, 73);
            this.textBoxServerListeningPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxServerListeningPort.Name = "textBoxServerListeningPort";
            this.textBoxServerListeningPort.Size = new System.Drawing.Size(30, 21);
            this.textBoxServerListeningPort.TabIndex = 244;
            this.textBoxServerListeningPort.Text = "9999";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(273, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 12);
            this.label13.TabIndex = 243;
            this.label13.Text = "Client Name";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxClientName.Location = new System.Drawing.Point(276, 36);
            this.textBoxClientName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(122, 21);
            this.textBoxClientName.TabIndex = 242;
            this.textBoxClientName.Text = "SooHo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(29, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(232, 12);
            this.label14.TabIndex = 241;
            this.label14.Text = "Address to the Server(name or IP)";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxServer.Location = new System.Drawing.Point(28, 36);
            this.textBoxServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(201, 21);
            this.textBoxServer.TabIndex = 239;
            this.textBoxServer.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 12);
            this.label1.TabIndex = 240;
            this.label1.Text = "Click \'Connect to Server\' ";
            // 
            // buttonSendToClients
            // 
            this.buttonSendToClients.BackColor = System.Drawing.Color.Black;
            this.buttonSendToClients.BackgroundColor = System.Drawing.Color.Black;
            this.buttonSendToClients.BorderColor = System.Drawing.Color.White;
            this.buttonSendToClients.BorderRadius = 20;
            this.buttonSendToClients.BorderSize = 0;
            this.buttonSendToClients.FlatAppearance.BorderSize = 0;
            this.buttonSendToClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSendToClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonSendToClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendToClients.Font = new System.Drawing.Font("Impact", 9.75F);
            this.buttonSendToClients.ForeColor = System.Drawing.Color.White;
            this.buttonSendToClients.Location = new System.Drawing.Point(220, 298);
            this.buttonSendToClients.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSendToClients.Name = "buttonSendToClients";
            this.buttonSendToClients.Size = new System.Drawing.Size(190, 29);
            this.buttonSendToClients.TabIndex = 262;
            this.buttonSendToClients.Text = "Send Text to Selected Clients";
            this.buttonSendToClients.TextColor = System.Drawing.Color.White;
            this.buttonSendToClients.UseVisualStyleBackColor = false;
            // 
            // buttonSendDataToServer
            // 
            this.buttonSendDataToServer.BackColor = System.Drawing.Color.Black;
            this.buttonSendDataToServer.BackgroundColor = System.Drawing.Color.Black;
            this.buttonSendDataToServer.BorderColor = System.Drawing.Color.White;
            this.buttonSendDataToServer.BorderRadius = 20;
            this.buttonSendDataToServer.BorderSize = 0;
            this.buttonSendDataToServer.FlatAppearance.BorderSize = 0;
            this.buttonSendDataToServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSendDataToServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonSendDataToServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendDataToServer.Font = new System.Drawing.Font("Impact", 9.75F);
            this.buttonSendDataToServer.ForeColor = System.Drawing.Color.White;
            this.buttonSendDataToServer.Location = new System.Drawing.Point(51, 163);
            this.buttonSendDataToServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSendDataToServer.Name = "buttonSendDataToServer";
            this.buttonSendDataToServer.Size = new System.Drawing.Size(158, 29);
            this.buttonSendDataToServer.TabIndex = 263;
            this.buttonSendDataToServer.Text = "Send Data To Server";
            this.buttonSendDataToServer.TextColor = System.Drawing.Color.White;
            this.buttonSendDataToServer.UseVisualStyleBackColor = false;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.Black;
            this.buttonDisconnect.BackgroundColor = System.Drawing.Color.Black;
            this.buttonDisconnect.BorderColor = System.Drawing.Color.White;
            this.buttonDisconnect.BorderRadius = 20;
            this.buttonDisconnect.BorderSize = 0;
            this.buttonDisconnect.FlatAppearance.BorderSize = 0;
            this.buttonDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnect.Font = new System.Drawing.Font("Impact", 9.75F);
            this.buttonDisconnect.ForeColor = System.Drawing.Color.White;
            this.buttonDisconnect.Location = new System.Drawing.Point(241, 163);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(168, 29);
            this.buttonDisconnect.TabIndex = 264;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.TextColor = System.Drawing.Color.White;
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            // 
            // buttonConnectToServer
            // 
            this.buttonConnectToServer.BackColor = System.Drawing.Color.Black;
            this.buttonConnectToServer.BackgroundColor = System.Drawing.Color.Black;
            this.buttonConnectToServer.BorderColor = System.Drawing.Color.White;
            this.buttonConnectToServer.BorderRadius = 17;
            this.buttonConnectToServer.BorderSize = 0;
            this.buttonConnectToServer.FlatAppearance.BorderSize = 0;
            this.buttonConnectToServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonConnectToServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonConnectToServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectToServer.Font = new System.Drawing.Font("Impact", 9.75F);
            this.buttonConnectToServer.ForeColor = System.Drawing.Color.White;
            this.buttonConnectToServer.Location = new System.Drawing.Point(241, 73);
            this.buttonConnectToServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConnectToServer.Name = "buttonConnectToServer";
            this.buttonConnectToServer.Size = new System.Drawing.Size(146, 28);
            this.buttonConnectToServer.TabIndex = 265;
            this.buttonConnectToServer.Text = "Connect To Server";
            this.buttonConnectToServer.TextColor = System.Drawing.Color.White;
            this.buttonConnectToServer.UseVisualStyleBackColor = false;
            // 
            // SettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.buttonConnectToServer);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonSendDataToServer);
            this.Controls.Add(this.buttonSendToClients);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRcv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelConnectionStuff);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxServerListeningPort);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.grBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SettingView";
            this.Size = new System.Drawing.Size(1082, 504);
            this.Load += new System.EventHandler(this.SettingView_Load);
            this.grBox2.ResumeLayout(false);
            this.grBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLogger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public Styler.RoundButton1 btnWrite;
        private System.Windows.Forms.GroupBox grBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRcv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label labelConnectionStuff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxServerListeningPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.ListBox listLoggerBox;
        private System.Windows.Forms.Label label1;
        public Styler.RoundButton1 buttonSendToClients;
        public Styler.RoundButton1 buttonSendDataToServer;
        public Styler.RoundButton1 buttonDisconnect;
        public Styler.RoundButton1 buttonConnectToServer;
    }
}
