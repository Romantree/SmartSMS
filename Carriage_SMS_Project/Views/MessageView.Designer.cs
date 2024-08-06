namespace Carriage_SMS_Project.Views
{
    partial class MessageView
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
            this.numericDelay = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.HPNOBox = new System.Windows.Forms.TextBox();
            this.sabunBox = new System.Windows.Forms.TextBox();
            this.personBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSendNumBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddNewPerson = new Carriage_SMS_Project.Styler.RoundButton();
            this.btnDefault = new Carriage_SMS_Project.Styler.RoundButton();
            this.btnPathOpen = new Carriage_SMS_Project.Styler.RoundButton();
            this.btnSet = new Carriage_SMS_Project.Styler.RoundButton();
            this.btnRecvList = new Carriage_SMS_Project.Styler.RoundButton();
            this.btnSetting = new Carriage_SMS_Project.Styler.RoundButton();
            this.btnStart = new Carriage_SMS_Project.Styler.RoundButton();
            this.roundBorderPanel1 = new Carriage_SMS_Project.Styler.RoundBorderPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelay)).BeginInit();
            this.roundBorderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericDelay
            // 
            this.numericDelay.Location = new System.Drawing.Point(714, 104);
            this.numericDelay.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericDelay.Name = "numericDelay";
            this.numericDelay.Size = new System.Drawing.Size(197, 21);
            this.numericDelay.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(606, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Send HPNO";
            // 
            // HPNOBox
            // 
            this.HPNOBox.Location = new System.Drawing.Point(715, 275);
            this.HPNOBox.Multiline = true;
            this.HPNOBox.Name = "HPNOBox";
            this.HPNOBox.Size = new System.Drawing.Size(196, 22);
            this.HPNOBox.TabIndex = 26;
            // 
            // sabunBox
            // 
            this.sabunBox.Location = new System.Drawing.Point(715, 226);
            this.sabunBox.Multiline = true;
            this.sabunBox.Name = "sabunBox";
            this.sabunBox.Size = new System.Drawing.Size(196, 22);
            this.sabunBox.TabIndex = 25;
            // 
            // personBox
            // 
            this.personBox.Location = new System.Drawing.Point(714, 165);
            this.personBox.Multiline = true;
            this.personBox.Name = "personBox";
            this.personBox.Size = new System.Drawing.Size(196, 22);
            this.personBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(641, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Path";
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(715, 323);
            this.PathBox.Margin = new System.Windows.Forms.Padding(2);
            this.PathBox.Multiline = true;
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(323, 30);
            this.PathBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(606, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Send Sabun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(605, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Send person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(605, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Delay [s]";
            // 
            // txtSendNumBox
            // 
            this.txtSendNumBox.Location = new System.Drawing.Point(408, 108);
            this.txtSendNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtSendNumBox.Name = "txtSendNumBox";
            this.txtSendNumBox.Size = new System.Drawing.Size(169, 21);
            this.txtSendNumBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("휴먼모음T", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(408, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Elap.Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("휴먼모음T", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "SMS log";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BorderColor = System.Drawing.Color.Orange;
            this.btnAddNewPerson.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnAddNewPerson.FlatAppearance.BorderSize = 0;
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPerson.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddNewPerson.Location = new System.Drawing.Point(931, 410);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnAddNewPerson.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnAddNewPerson.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnAddNewPerson.Size = new System.Drawing.Size(107, 44);
            this.btnAddNewPerson.TabIndex = 45;
            this.btnAddNewPerson.Text = "NEW";
            this.btnAddNewPerson.TextColor = System.Drawing.Color.White;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            // 
            // btnDefault
            // 
            this.btnDefault.BorderColor = System.Drawing.Color.Orange;
            this.btnDefault.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDefault.FlatAppearance.BorderSize = 0;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDefault.Location = new System.Drawing.Point(932, 245);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnDefault.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnDefault.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDefault.Size = new System.Drawing.Size(107, 46);
            this.btnDefault.TabIndex = 44;
            this.btnDefault.Text = "DEFAULT";
            this.btnDefault.TextColor = System.Drawing.Color.White;
            this.btnDefault.UseVisualStyleBackColor = true;
            // 
            // btnPathOpen
            // 
            this.btnPathOpen.BorderColor = System.Drawing.Color.Orange;
            this.btnPathOpen.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnPathOpen.FlatAppearance.BorderSize = 0;
            this.btnPathOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPathOpen.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPathOpen.Location = new System.Drawing.Point(931, 175);
            this.btnPathOpen.Name = "btnPathOpen";
            this.btnPathOpen.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnPathOpen.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnPathOpen.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnPathOpen.Size = new System.Drawing.Size(107, 46);
            this.btnPathOpen.TabIndex = 43;
            this.btnPathOpen.Text = "PATH OPEN";
            this.btnPathOpen.TextColor = System.Drawing.Color.White;
            this.btnPathOpen.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.BorderColor = System.Drawing.Color.Orange;
            this.btnSet.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSet.Location = new System.Drawing.Point(932, 104);
            this.btnSet.Name = "btnSet";
            this.btnSet.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSet.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnSet.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnSet.Size = new System.Drawing.Size(107, 46);
            this.btnSet.TabIndex = 42;
            this.btnSet.Text = "SET";
            this.btnSet.TextColor = System.Drawing.Color.White;
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // btnRecvList
            // 
            this.btnRecvList.BorderColor = System.Drawing.Color.Orange;
            this.btnRecvList.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnRecvList.FlatAppearance.BorderSize = 0;
            this.btnRecvList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecvList.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRecvList.Location = new System.Drawing.Point(411, 351);
            this.btnRecvList.Name = "btnRecvList";
            this.btnRecvList.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnRecvList.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnRecvList.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnRecvList.Size = new System.Drawing.Size(166, 53);
            this.btnRecvList.TabIndex = 41;
            this.btnRecvList.Text = "RECV LIST";
            this.btnRecvList.TextColor = System.Drawing.Color.White;
            this.btnRecvList.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.BorderColor = System.Drawing.Color.Orange;
            this.btnSetting.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetting.Location = new System.Drawing.Point(411, 261);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSetting.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnSetting.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnSetting.Size = new System.Drawing.Size(166, 53);
            this.btnSetting.TabIndex = 40;
            this.btnSetting.Text = "SETTING";
            this.btnSetting.TextColor = System.Drawing.Color.White;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BorderColor = System.Drawing.Color.Orange;
            this.btnStart.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(411, 172);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnStart.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnStart.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnStart.Size = new System.Drawing.Size(166, 53);
            this.btnStart.TabIndex = 39;
            this.btnStart.Text = "START";
            this.btnStart.TextColor = System.Drawing.Color.White;
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // roundBorderPanel1
            // 
            this.roundBorderPanel1.Controls.Add(this.textBox1);
            this.roundBorderPanel1.Location = new System.Drawing.Point(17, 31);
            this.roundBorderPanel1.Name = "roundBorderPanel1";
            this.roundBorderPanel1.Size = new System.Drawing.Size(371, 399);
            this.roundBorderPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(15, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 371);
            this.textBox1.TabIndex = 0;
            // 
            // MessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnPathOpen);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnRecvList);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericDelay);
            this.Controls.Add(this.txtSendNumBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HPNOBox);
            this.Controls.Add(this.sabunBox);
            this.Controls.Add(this.personBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundBorderPanel1);
            this.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MessageView";
            this.Size = new System.Drawing.Size(1096, 475);
            this.Load += new System.EventHandler(this.MessageView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDelay)).EndInit();
            this.roundBorderPanel1.ResumeLayout(false);
            this.roundBorderPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Styler.RoundBorderPanel roundBorderPanel1;
        private System.Windows.Forms.NumericUpDown numericDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HPNOBox;
        private System.Windows.Forms.TextBox sabunBox;
        private System.Windows.Forms.TextBox personBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSendNumBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Styler.RoundButton btnStart;
        private Styler.RoundButton btnSetting;
        private Styler.RoundButton btnRecvList;
        private Styler.RoundButton btnSet;
        private Styler.RoundButton btnPathOpen;
        private Styler.RoundButton btnDefault;
        private Styler.RoundButton btnAddNewPerson;
        private System.Windows.Forms.TextBox textBox1;
    }
}
