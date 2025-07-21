namespace Spend_Management
{
    partial class SpendingPage
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
            label1 = new Label();
            panel3 = new Panel();
            rdoExpense = new RadioButton();
            rdoIncome = new RadioButton();
            txtNote = new TextBox();
            label4 = new Label();
            BtnOK = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            txtAmount = new TextBox();
            label5 = new Label();
            flpCategory = new FlowLayoutPanel();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 207);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 39;
            label1.Text = "カテゴリー";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(rdoExpense);
            panel3.Controls.Add(rdoIncome);
            panel3.Location = new Point(75, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 74);
            panel3.TabIndex = 38;
            // 
            // rdoExpense
            // 
            rdoExpense.AutoSize = true;
            rdoExpense.Font = new Font("Yu Gothic UI", 12F);
            rdoExpense.Location = new Point(18, 36);
            rdoExpense.Name = "rdoExpense";
            rdoExpense.Size = new Size(60, 25);
            rdoExpense.TabIndex = 1;
            rdoExpense.TabStop = true;
            rdoExpense.Text = "出金";
            rdoExpense.UseVisualStyleBackColor = true;
            // 
            // rdoIncome
            // 
            rdoIncome.AutoSize = true;
            rdoIncome.Font = new Font("Yu Gothic UI", 12F);
            rdoIncome.Location = new Point(18, 11);
            rdoIncome.Name = "rdoIncome";
            rdoIncome.Size = new Size(60, 25);
            rdoIncome.TabIndex = 0;
            rdoIncome.TabStop = true;
            rdoIncome.Text = "入金";
            rdoIncome.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            txtNote.BorderStyle = BorderStyle.FixedSingle;
            txtNote.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtNote.Location = new Point(405, 309);
            txtNote.Margin = new Padding(3, 2, 3, 2);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(210, 29);
            txtNote.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(343, 308);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 35;
            label4.Text = "注記";
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(522, 390);
            BtnOK.Margin = new Padding(3, 2, 3, 2);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(93, 34);
            BtnOK.TabIndex = 34;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(343, 230);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 33;
            label3.Text = "時点";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dateTimePicker1.Location = new Point(405, 225);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 29);
            dateTimePicker1.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(343, 147);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 31;
            label2.Text = "金額";
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtAmount.Location = new Point(405, 142);
            txtAmount.Margin = new Padding(3, 2, 3, 2);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(210, 29);
            txtAmount.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 27);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 40;
            // 
            // flpCategory
            // 
            flpCategory.AutoScroll = true;
            flpCategory.BorderStyle = BorderStyle.FixedSingle;
            flpCategory.FlowDirection = FlowDirection.TopDown;
            flpCategory.Font = new Font("Yu Gothic UI", 12F);
            flpCategory.Location = new Point(75, 230);
            flpCategory.Name = "flpCategory";
            flpCategory.Size = new Size(185, 229);
            flpCategory.TabIndex = 41;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // SpendingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flpCategory);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(txtNote);
            Controls.Add(label4);
            Controls.Add(BtnOK);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(txtAmount);
            Name = "SpendingPage";
            Size = new Size(694, 531);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private RadioButton rdoExpense;
        private RadioButton rdoIncome;
        private TextBox txtNote;
        private Label label4;
        private Button BtnOK;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox txtAmount;
        private Label label5;
        private FlowLayoutPanel flpCategory;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
