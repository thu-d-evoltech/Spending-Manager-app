namespace Spend_Management
{
    partial class StatisticalPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            statiscalGridView1 = new DataGridView();
            detailGroupBox = new GroupBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)statiscalGridView1).BeginInit();
            detailGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(298, 6);
            label1.Name = "label1";
            label1.Size = new Size(231, 45);
            label1.TabIndex = 0;
            label1.Text = "統計";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statiscalGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("MS UI Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            statiscalGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            statiscalGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            statiscalGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            statiscalGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            statiscalGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            statiscalGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Yu Gothic UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            statiscalGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            statiscalGridView1.ImeMode = ImeMode.NoControl;
            statiscalGridView1.Location = new Point(3, 235);
            statiscalGridView1.Name = "statiscalGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            statiscalGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            statiscalGridView1.RowHeadersWidth = 51;
            statiscalGridView1.Size = new Size(787, 470);
            statiscalGridView1.TabIndex = 1;
            // 
            // detailGroupBox
            // 
            detailGroupBox.Controls.Add(textBox4);
            detailGroupBox.Controls.Add(label5);
            detailGroupBox.Controls.Add(textBox3);
            detailGroupBox.Controls.Add(label4);
            detailGroupBox.Controls.Add(textBox2);
            detailGroupBox.Controls.Add(label3);
            detailGroupBox.Controls.Add(textBox1);
            detailGroupBox.Controls.Add(label2);
            detailGroupBox.Location = new Point(3, 54);
            detailGroupBox.Name = "detailGroupBox";
            detailGroupBox.Size = new Size(787, 175);
            detailGroupBox.TabIndex = 2;
            detailGroupBox.TabStop = false;
            detailGroupBox.Text = "明細詳細";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox4.Location = new Point(504, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 34);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(446, 93);
            label5.Name = "label5";
            label5.Size = new Size(52, 28);
            label5.TabIndex = 6;
            label5.Text = "日付";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox3.Location = new Point(130, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 34);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(72, 93);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 4;
            label4.Text = "注記";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox2.Location = new Point(504, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 34);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(446, 38);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 2;
            label3.Text = "金額";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox1.Location = new Point(130, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 34);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(72, 38);
            label2.Name = "label2";
            label2.Size = new Size(52, 28);
            label2.TabIndex = 0;
            label2.Text = "項目";
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            Column1.DefaultCellStyle = dataGridViewCellStyle3;
            Column1.FillWeight = 40F;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            Column2.DefaultCellStyle = dataGridViewCellStyle4;
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
            // StatisticalPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(detailGroupBox);
            Controls.Add(statiscalGridView1);
            Controls.Add(label1);
            Name = "StatisticalPage";
            Size = new Size(793, 708);
            ((System.ComponentModel.ISupportInitialize)statiscalGridView1).EndInit();
            detailGroupBox.ResumeLayout(false);
            detailGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView statiscalGridView1;
        private GroupBox detailGroupBox;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
