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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            button4 = new Button();
            gridViewStatiscal = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridViewStatiscal).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Aquamarine;
            button4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            button4.Location = new Point(509, 469);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(182, 46);
            button4.TabIndex = 6;
            button4.Text = "Excelエクスポート";
            button4.UseVisualStyleBackColor = false;
            // 
            // gridViewStatiscal
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("MS UI Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            gridViewStatiscal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            gridViewStatiscal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewStatiscal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridViewStatiscal.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            gridViewStatiscal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            gridViewStatiscal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewStatiscal.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Yu Gothic UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            gridViewStatiscal.DefaultCellStyle = dataGridViewCellStyle11;
            gridViewStatiscal.GridColor = SystemColors.Menu;
            gridViewStatiscal.ImeMode = ImeMode.NoControl;
            gridViewStatiscal.Location = new Point(3, 74);
            gridViewStatiscal.Margin = new Padding(3, 2, 3, 2);
            gridViewStatiscal.Name = "gridViewStatiscal";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            gridViewStatiscal.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            gridViewStatiscal.RowHeadersWidth = 51;
            gridViewStatiscal.Size = new Size(688, 370);
            gridViewStatiscal.TabIndex = 5;
            // 
            // Column1
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            Column1.DefaultCellStyle = dataGridViewCellStyle9;
            Column1.FillWeight = 40F;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            Column2.DefaultCellStyle = dataGridViewCellStyle10;
            Column2.FillWeight = 76.97018F;
            Column2.HeaderText = "区分";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 76.97018F;
            Column3.HeaderText = "金額";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 76.97018F;
            Column4.HeaderText = "内容";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.FillWeight = 76.97018F;
            Column5.HeaderText = "注記";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.FillWeight = 76.97018F;
            Column6.HeaderText = "日付";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(240, 16);
            label1.Name = "label1";
            label1.Size = new Size(202, 34);
            label1.TabIndex = 4;
            label1.Text = "明細詳細";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button4);
            Controls.Add(gridViewStatiscal);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReportPage";
            Size = new Size(694, 531);
            ((System.ComponentModel.ISupportInitialize)gridViewStatiscal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private DataGridView gridViewStatiscal;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label1;
    }
}
