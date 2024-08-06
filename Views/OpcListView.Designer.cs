namespace Carriage_SMS_Project.Views
{
    partial class OpcListView
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
            this.components = new System.ComponentModel.Container();
            this.lblStart = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DataLoggingLog = new System.Windows.Forms.ListBox();
            this.listOpcLog1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.tmLog = new System.Windows.Forms.Timer(this.components);
            this.tm1Sec = new System.Windows.Forms.Timer(this.components);
            this.tm10Sec = new System.Windows.Forms.Timer(this.components);
            this.tmDataLogging = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStart.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStart.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblStart.Location = new System.Drawing.Point(6, 21);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(374, 36);
            this.lblStart.TabIndex = 222;
            this.lblStart.Text = "OPC LINK 1(0.0.0.0)";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DataLoggingLog);
            this.groupBox1.Controls.Add(this.listOpcLog1);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 460);
            this.groupBox1.TabIndex = 223;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATUS";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Location = new System.Drawing.Point(386, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(318, 36);
            this.label8.TabIndex = 224;
            this.label8.Text = "DATA LOGGING";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataLoggingLog
            // 
            this.DataLoggingLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DataLoggingLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataLoggingLog.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DataLoggingLog.ForeColor = System.Drawing.Color.Transparent;
            this.DataLoggingLog.FormattingEnabled = true;
            this.DataLoggingLog.HorizontalScrollbar = true;
            this.DataLoggingLog.ItemHeight = 17;
            this.DataLoggingLog.Location = new System.Drawing.Point(386, 61);
            this.DataLoggingLog.Name = "DataLoggingLog";
            this.DataLoggingLog.Size = new System.Drawing.Size(318, 393);
            this.DataLoggingLog.TabIndex = 223;
            // 
            // listOpcLog1
            // 
            this.listOpcLog1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listOpcLog1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listOpcLog1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listOpcLog1.ForeColor = System.Drawing.Color.White;
            this.listOpcLog1.FormattingEnabled = true;
            this.listOpcLog1.HorizontalScrollbar = true;
            this.listOpcLog1.ItemHeight = 17;
            this.listOpcLog1.Location = new System.Drawing.Point(6, 60);
            this.listOpcLog1.Name = "listOpcLog1";
            this.listOpcLog1.Size = new System.Drawing.Size(374, 393);
            this.listOpcLog1.TabIndex = 223;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPC Server";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Host IP Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 25);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "OPC Server Name";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(110, 163);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 26);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 25);
            this.textBox3.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.btnWrite);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnDisConnect);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(719, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 450);
            this.groupBox2.TabIndex = 224;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPC Cilent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Write Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "ReadValue";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 359);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 26);
            this.textBox5.TabIndex = 18;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(165, 357);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(147, 26);
            this.btnWrite.TabIndex = 17;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 294);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 26);
            this.textBox4.TabIndex = 16;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(165, 294);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(147, 26);
            this.btnRead.TabIndex = 15;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "OPC Item";
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisConnect.Location = new System.Drawing.Point(214, 163);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(96, 26);
            this.btnDisConnect.TabIndex = 13;
            this.btnDisConnect.Text = "DisConnect";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            // 
            // OpcListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OpcListView";
            this.Size = new System.Drawing.Size(1063, 477);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox DataLoggingLog;
        private System.Windows.Forms.Timer tmLog;
        private System.Windows.Forms.Timer tm1Sec;
        private System.Windows.Forms.Timer tm10Sec;
        private System.Windows.Forms.Timer tmDataLogging;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listOpcLog1;
    }
}
