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
            this.components = new System.ComponentModel.Container();
            this.numericDelay = new System.Windows.Forms.NumericUpDown();
            this.personBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSendNumBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tmStart = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnTagList = new Carriage_SMS_Project.Styler.RoundButton1();
            this.btnUpdate = new Carriage_SMS_Project.Styler.RoundButton1();
            this.roundButton1 = new Carriage_SMS_Project.Styler.RoundButton();
            this.btnSet = new Carriage_SMS_Project.Styler.RoundButton();
            this.btnSetting = new Carriage_SMS_Project.Styler.RoundButton();
            this.btnStart = new Carriage_SMS_Project.Styler.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numericDelay
            // 
            this.numericDelay.Location = new System.Drawing.Point(888, 212);
            this.numericDelay.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericDelay.Name = "numericDelay";
            this.numericDelay.Size = new System.Drawing.Size(158, 21);
            this.numericDelay.TabIndex = 28;
            // 
            // personBox
            // 
            this.personBox.Location = new System.Drawing.Point(886, 53);
            this.personBox.Multiline = true;
            this.personBox.Name = "personBox";
            this.personBox.Size = new System.Drawing.Size(157, 22);
            this.personBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(885, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Send person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(888, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Delay [s]";
            // 
            // txtSendNumBox
            // 
            this.txtSendNumBox.Location = new System.Drawing.Point(888, 122);
            this.txtSendNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtSendNumBox.Name = "txtSendNumBox";
            this.txtSendNumBox.Size = new System.Drawing.Size(158, 21);
            this.txtSendNumBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(888, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Elap.Time";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(22, 17);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(846, 401);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnTagList
            // 
            this.btnTagList.BackColor = System.Drawing.Color.Black;
            this.btnTagList.BackgroundColor = System.Drawing.Color.Black;
            this.btnTagList.BorderColor = System.Drawing.Color.White;
            this.btnTagList.BorderRadius = 20;
            this.btnTagList.BorderSize = 0;
            this.btnTagList.FlatAppearance.BorderSize = 0;
            this.btnTagList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnTagList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnTagList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTagList.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTagList.ForeColor = System.Drawing.Color.White;
            this.btnTagList.Location = new System.Drawing.Point(447, 424);
            this.btnTagList.Name = "btnTagList";
            this.btnTagList.Size = new System.Drawing.Size(157, 33);
            this.btnTagList.TabIndex = 242;
            this.btnTagList.Text = "T A G L I S T";
            this.btnTagList.TextColor = System.Drawing.Color.White;
            this.btnTagList.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.Black;
            this.btnUpdate.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(250, 424);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 33);
            this.btnUpdate.TabIndex = 241;
            this.btnUpdate.Text = "U P D A T E";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // roundButton1
            // 
            this.roundButton1.BorderColor = System.Drawing.Color.Orange;
            this.roundButton1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.roundButton1.Location = new System.Drawing.Point(976, 335);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundButton1.Size = new System.Drawing.Size(72, 37);
            this.roundButton1.TabIndex = 49;
            this.roundButton1.Text = "SEND";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.BorderColor = System.Drawing.Color.Orange;
            this.btnSet.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSet.Location = new System.Drawing.Point(888, 272);
            this.btnSet.Name = "btnSet";
            this.btnSet.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSet.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnSet.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnSet.Size = new System.Drawing.Size(72, 37);
            this.btnSet.TabIndex = 42;
            this.btnSet.Text = "SET";
            this.btnSet.TextColor = System.Drawing.Color.White;
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.BorderColor = System.Drawing.Color.Orange;
            this.btnSetting.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetting.Location = new System.Drawing.Point(976, 272);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSetting.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnSetting.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnSetting.Size = new System.Drawing.Size(72, 37);
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
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(888, 335);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnHoverBorderColor = System.Drawing.Color.Orchid;
            this.btnStart.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnStart.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStart.Size = new System.Drawing.Size(79, 37);
            this.btnStart.TabIndex = 39;
            this.btnStart.Text = "START";
            this.btnStart.TextColor = System.Drawing.Color.White;
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // MessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.btnTagList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numericDelay);
            this.Controls.Add(this.txtSendNumBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.personBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MessageView";
            this.Size = new System.Drawing.Size(1066, 475);
            this.Load += new System.EventHandler(this.MessageView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericDelay;
        private System.Windows.Forms.TextBox personBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSendNumBox;
        private System.Windows.Forms.Label label6;
        private Styler.RoundButton btnStart;
        private Styler.RoundButton btnSet;
        private System.Windows.Forms.Timer tmStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Styler.RoundButton btnSetting;
        private Styler.RoundButton roundButton1;
        private System.Windows.Forms.DataGridView dataGridView;
        public Styler.RoundButton1 btnUpdate;
        public Styler.RoundButton1 btnTagList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
