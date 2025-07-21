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
            button3 = new Button();
            dataGridViewExpense = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpense).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            button3.Location = new Point(528, 472);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(150, 34);
            button3.TabIndex = 2;
            button3.Text = "Excelエクスポート";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridViewExpense
            // 
            dataGridViewExpense.BackgroundColor = SystemColors.Control;
            dataGridViewExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpense.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewExpense.Location = new Point(2, 54);
            dataGridViewExpense.Name = "dataGridViewExpense";
            dataGridViewExpense.Size = new Size(689, 399);
            dataGridViewExpense.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "年月日";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.HeaderText = "経費名";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 130;
            // 
            // Column3
            // 
            Column3.HeaderText = "入出金";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "入/出";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.HeaderText = "注記";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 135;
            // 
            // ReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridViewExpense);
            Controls.Add(button3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReportPage";
            Size = new Size(694, 531);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpense).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private DataGridView dataGridViewExpense;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
