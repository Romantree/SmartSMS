namespace Carriage_SMS_Project.Views
{
    partial class MainContentView
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
            this.roundBorderPanel1 = new Carriage_SMS_Project.Styler.RoundBorderPanel();
            this.roundBorderPanel2 = new Carriage_SMS_Project.Styler.RoundBorderPanel();
            this.roundBorderPanel3 = new Carriage_SMS_Project.Styler.RoundBorderPanel();
            this.roundBorderPanel4 = new Carriage_SMS_Project.Styler.RoundBorderPanel();
            this.btnStart = new Carriage_SMS_Project.Styler.RoundButton();
            this.label7 = new System.Windows.Forms.Label();
            this.roundBorderPanel5 = new Carriage_SMS_Project.Styler.RoundBorderPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.roundBorderPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundBorderPanel1
            // 
            this.roundBorderPanel1.Location = new System.Drawing.Point(33, 77);
            this.roundBorderPanel1.Name = "roundBorderPanel1";
            this.roundBorderPanel1.Size = new System.Drawing.Size(200, 237);
            this.roundBorderPanel1.TabIndex = 41;
            // 
            // roundBorderPanel2
            // 
            this.roundBorderPanel2.Location = new System.Drawing.Point(257, 77);
            this.roundBorderPanel2.Name = "roundBorderPanel2";
            this.roundBorderPanel2.Size = new System.Drawing.Size(390, 95);
            this.roundBorderPanel2.TabIndex = 42;
            // 
            // roundBorderPanel3
            // 
            this.roundBorderPanel3.Location = new System.Drawing.Point(257, 216);
            this.roundBorderPanel3.Name = "roundBorderPanel3";
            this.roundBorderPanel3.Size = new System.Drawing.Size(390, 98);
            this.roundBorderPanel3.TabIndex = 43;
            // 
            // roundBorderPanel4
            // 
            this.roundBorderPanel4.Location = new System.Drawing.Point(33, 343);
            this.roundBorderPanel4.Name = "roundBorderPanel4";
            this.roundBorderPanel4.Size = new System.Drawing.Size(614, 98);
            this.roundBorderPanel4.TabIndex = 44;
            // 
            // btnStart
            // 
            this.btnStart.BorderColor = System.Drawing.Color.Orange;
            this.btnStart.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(33, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnStart.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnStart.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnStart.Size = new System.Drawing.Size(166, 46);
            this.btnStart.TabIndex = 45;
            this.btnStart.Text = "Main";
            this.btnStart.TextColor = System.Drawing.Color.White;
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("휴먼모음T", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(692, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 47;
            this.label7.Text = "SMS log";
            // 
            // roundBorderPanel5
            // 
            this.roundBorderPanel5.Controls.Add(this.textBox1);
            this.roundBorderPanel5.Location = new System.Drawing.Point(680, 42);
            this.roundBorderPanel5.Name = "roundBorderPanel5";
            this.roundBorderPanel5.Size = new System.Drawing.Size(371, 399);
            this.roundBorderPanel5.TabIndex = 46;
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
            // MainContentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.roundBorderPanel5);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.roundBorderPanel4);
            this.Controls.Add(this.roundBorderPanel3);
            this.Controls.Add(this.roundBorderPanel2);
            this.Controls.Add(this.roundBorderPanel1);
            this.Name = "MainContentView";
            this.Size = new System.Drawing.Size(1154, 462);
            this.roundBorderPanel5.ResumeLayout(false);
            this.roundBorderPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Styler.RoundBorderPanel roundBorderPanel1;
        private Styler.RoundBorderPanel roundBorderPanel2;
        private Styler.RoundBorderPanel roundBorderPanel3;
        private Styler.RoundBorderPanel roundBorderPanel4;
        private Styler.RoundButton btnStart;
        private System.Windows.Forms.Label label7;
        private Styler.RoundBorderPanel roundBorderPanel5;
        private System.Windows.Forms.TextBox textBox1;
    }
}
