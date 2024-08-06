namespace Carriage_SMS_Project.Views
{
    partial class TagListView
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
            this.firstRowNamesCheckBox = new System.Windows.Forms.CheckBox();
            this.sheetCombo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPathOpen = new Carriage_SMS_Project.Styler.RoundButton();
            this.roundButton1 = new Carriage_SMS_Project.Styler.RoundButton();
            this.roundButton2 = new Carriage_SMS_Project.Styler.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstRowNamesCheckBox
            // 
            this.firstRowNamesCheckBox.AutoSize = true;
            this.firstRowNamesCheckBox.Checked = true;
            this.firstRowNamesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firstRowNamesCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstRowNamesCheckBox.Location = new System.Drawing.Point(31, 53);
            this.firstRowNamesCheckBox.Name = "firstRowNamesCheckBox";
            this.firstRowNamesCheckBox.Size = new System.Drawing.Size(273, 23);
            this.firstRowNamesCheckBox.TabIndex = 27;
            this.firstRowNamesCheckBox.Text = "first row contains column names";
            this.firstRowNamesCheckBox.UseVisualStyleBackColor = true;
            // 
            // sheetCombo
            // 
            this.sheetCombo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sheetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sheetCombo.FormattingEnabled = true;
            this.sheetCombo.Location = new System.Drawing.Point(321, 56);
            this.sheetCombo.Name = "sheetCombo";
            this.sheetCombo.Size = new System.Drawing.Size(19, 20);
            this.sheetCombo.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(626, 21);
            this.textBox1.TabIndex = 24;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPathOpen
            // 
            this.btnPathOpen.BorderColor = System.Drawing.Color.Orange;
            this.btnPathOpen.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnPathOpen.FlatAppearance.BorderSize = 0;
            this.btnPathOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPathOpen.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPathOpen.Location = new System.Drawing.Point(544, 47);
            this.btnPathOpen.Name = "btnPathOpen";
            this.btnPathOpen.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnPathOpen.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnPathOpen.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnPathOpen.Size = new System.Drawing.Size(79, 36);
            this.btnPathOpen.TabIndex = 230;
            this.btnPathOpen.Text = "파일 선택";
            this.btnPathOpen.TextColor = System.Drawing.SystemColors.Window;
            this.btnPathOpen.UseVisualStyleBackColor = true;
            // 
            // roundButton1
            // 
            this.roundButton1.BorderColor = System.Drawing.Color.Orange;
            this.roundButton1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.roundButton1.Location = new System.Drawing.Point(629, 47);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundButton1.Size = new System.Drawing.Size(79, 36);
            this.roundButton1.TabIndex = 231;
            this.roundButton1.Text = "불러오기";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // roundButton2
            // 
            this.roundButton2.BorderColor = System.Drawing.Color.Orange;
            this.roundButton2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.roundButton2.Location = new System.Drawing.Point(361, 48);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundButton2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundButton2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundButton2.Size = new System.Drawing.Size(79, 36);
            this.roundButton2.TabIndex = 232;
            this.roundButton2.Text = "Sheet 선택";
            this.roundButton2.TextColor = System.Drawing.SystemColors.Window;
            this.roundButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 233;
            this.label1.Text = "Path";
            // 
            // TagListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.btnPathOpen);
            this.Controls.Add(this.firstRowNamesCheckBox);
            this.Controls.Add(this.sheetCombo);
            this.Controls.Add(this.textBox1);
            this.Name = "TagListView";
            this.Size = new System.Drawing.Size(933, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox firstRowNamesCheckBox;
        private System.Windows.Forms.ComboBox sheetCombo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Styler.RoundButton btnPathOpen;
        private Styler.RoundButton roundButton1;
        private Styler.RoundButton roundButton2;
        private System.Windows.Forms.Label label1;
    }
}
