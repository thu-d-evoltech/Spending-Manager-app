namespace Spend_Management
{
    partial class ReportPage
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewReport = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Note = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Columns.AddRange(new DataGridViewColumn[] { Date, CategoryName, Amount, Type, Note });
            dataGridViewReport.EnableHeadersVisualStyles = false;
            dataGridViewReport.GridColor = Color.White;
            dataGridViewReport.Location = new Point(0, 69);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Yu Gothic UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewReport.Size = new Size(694, 462);
            dataGridViewReport.TabIndex = 3;
            // 
            // Date
            // 
            Date.Frozen = true;
            Date.HeaderText = "年月日";
            Date.Name = "Date";
            Date.Width = 130;
            // 
            // CategoryName
            // 
            CategoryName.Frozen = true;
            CategoryName.HeaderText = "カテゴリ";
            CategoryName.Name = "CategoryName";
            CategoryName.Width = 130;
            // 
            // Amount
            // 
            Amount.Frozen = true;
            Amount.HeaderText = "金額";
            Amount.Name = "Amount";
            Amount.Width = 130;
            // 
            // Type
            // 
            Type.Frozen = true;
            Type.HeaderText = "入/出";
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // Note
            // 
            Note.Frozen = true;
            Note.HeaderText = "メモ";
            Note.Name = "Note";
            Note.Width = 135;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(262, 18);
            label1.Name = "label1";
            label1.Size = new Size(154, 31);
            label1.TabIndex = 4;
            label1.Text = "明細詳細";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(dataGridViewReport);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReportPage";
            Size = new Size(694, 531);
            Load += ReportPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewReport;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Note;
        private Label label1;
    }
}
