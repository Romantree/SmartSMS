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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.TagListGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roundBorderPanel1 = new Carriage_SMS_Project.Styler.RoundBorderPanel();
            ((System.ComponentModel.ISupportInitialize)(this.TagListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.roundBorderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // TagListGridView
            // 
            this.TagListGridView.BackgroundColor = System.Drawing.Color.White;
            this.TagListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TagListGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.TagListGridView.Location = new System.Drawing.Point(12, 13);
            this.TagListGridView.Name = "TagListGridView";
            this.TagListGridView.RowTemplate.Height = 23;
            this.TagListGridView.Size = new System.Drawing.Size(641, 394);
            this.TagListGridView.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(14, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(425, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // roundBorderPanel1
            // 
            this.roundBorderPanel1.Controls.Add(this.dataGridView1);
            this.roundBorderPanel1.Location = new System.Drawing.Point(13, 0);
            this.roundBorderPanel1.Name = "roundBorderPanel1";
            this.roundBorderPanel1.Size = new System.Drawing.Size(453, 436);
            this.roundBorderPanel1.TabIndex = 1;
            // 
            // TagListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.roundBorderPanel1);
            this.Name = "TagListView";
            this.Size = new System.Drawing.Size(480, 462);
            this.Load += new System.EventHandler(this.TagListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TagListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.roundBorderPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView TagListGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Styler.RoundBorderPanel roundBorderPanel1;
    }
}
