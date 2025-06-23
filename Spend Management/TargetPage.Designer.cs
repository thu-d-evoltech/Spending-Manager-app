namespace Spend_Management
{
    partial class TargetPage
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
            lblTotal = new Label();
            lblSavingGoal = new Label();
            txtTotal = new TextBox();
            txtSavingGoal = new TextBox();
            listViewExpense = new ListView();
            columnName = new ColumnHeader();
            columnAmount = new ColumnHeader();
            btnAddItem = new Button();
            btnEditItem = new Button();
            btnDeleteItem = new Button();
            label3 = new Label();
            lblMaxSpending = new Label();
            panel1 = new Panel();
            txtExpenseAmount = new TextBox();
            txtExpenseName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSubmit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Cursor = Cursors.No;
            lblTotal.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold);
            lblTotal.Location = new Point(50, 57);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "収入";
            // 
            // lblSavingGoal
            // 
            lblSavingGoal.AutoSize = true;
            lblSavingGoal.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold);
            lblSavingGoal.Location = new Point(389, 53);
            lblSavingGoal.Name = "lblSavingGoal";
            lblSavingGoal.Size = new Size(39, 20);
            lblSavingGoal.TabIndex = 1;
            lblSavingGoal.Text = "節金";
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            txtTotal.Location = new Point(50, 80);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(204, 29);
            txtTotal.TabIndex = 3;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // txtSavingGoal
            // 
            txtSavingGoal.BorderStyle = BorderStyle.FixedSingle;
            txtSavingGoal.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            txtSavingGoal.Location = new Point(434, 50);
            txtSavingGoal.Name = "txtSavingGoal";
            txtSavingGoal.Size = new Size(204, 29);
            txtSavingGoal.TabIndex = 4;
            txtSavingGoal.TextChanged += txtSavingGoal_TextChanged;
            // 
            // listViewExpense
            // 
            listViewExpense.BorderStyle = BorderStyle.FixedSingle;
            listViewExpense.Columns.AddRange(new ColumnHeader[] { columnName, columnAmount });
            listViewExpense.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            listViewExpense.Location = new Point(50, 160);
            listViewExpense.Name = "listViewExpense";
            listViewExpense.Size = new Size(312, 285);
            listViewExpense.TabIndex = 5;
            listViewExpense.UseCompatibleStateImageBehavior = false;
            listViewExpense.View = View.Details;
            // 
            // columnName
            // 
            columnName.Text = "ColExpenseName";
            columnName.Width = 140;
            // 
            // columnAmount
            // 
            columnAmount.Text = "ColAmount";
            columnAmount.TextAlign = HorizontalAlignment.Center;
            columnAmount.Width = 172;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(15, 121);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(56, 35);
            btnAddItem.TabIndex = 6;
            btnAddItem.Text = "追加";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.Location = new Point(98, 121);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(56, 35);
            btnEditItem.TabIndex = 9;
            btnEditItem.Text = "修正";
            btnEditItem.UseVisualStyleBackColor = true;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(179, 121);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(56, 35);
            btnDeleteItem.TabIndex = 10;
            btnDeleteItem.Text = "削除";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(389, 106);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 11;
            label3.Text = "支出";
            // 
            // lblMaxSpending
            // 
            lblMaxSpending.BorderStyle = BorderStyle.FixedSingle;
            lblMaxSpending.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            lblMaxSpending.Location = new Point(434, 98);
            lblMaxSpending.Name = "lblMaxSpending";
            lblMaxSpending.Size = new Size(204, 28);
            lblMaxSpending.TabIndex = 12;
            lblMaxSpending.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtExpenseAmount);
            panel1.Controls.Add(txtExpenseName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDeleteItem);
            panel1.Controls.Add(btnEditItem);
            panel1.Controls.Add(btnAddItem);
            panel1.Location = new Point(389, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 171);
            panel1.TabIndex = 13;
            // 
            // txtExpenseAmount
            // 
            txtExpenseAmount.Location = new Point(80, 67);
            txtExpenseAmount.Name = "txtExpenseAmount";
            txtExpenseAmount.Size = new Size(155, 23);
            txtExpenseAmount.TabIndex = 14;
            // 
            // txtExpenseName
            // 
            txtExpenseName.Location = new Point(80, 25);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(155, 23);
            txtExpenseName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(15, 70);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 12;
            label2.Text = "金額";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 11;
            label1.Text = "経費名";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(192, 255, 255);
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Location = new Point(544, 413);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 32);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "確認";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // TargetPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSubmit);
            Controls.Add(panel1);
            Controls.Add(lblMaxSpending);
            Controls.Add(label3);
            Controls.Add(listViewExpense);
            Controls.Add(txtSavingGoal);
            Controls.Add(txtTotal);
            Controls.Add(lblSavingGoal);
            Controls.Add(lblTotal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TargetPage";
            Size = new Size(694, 531);
            Load += TargetPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label lblSavingGoal;
        private TextBox txtTotal;
        private TextBox txtSavingGoal;
        private ListView listViewExpense;
        private Button btnAddItem;
        private Button btnEditItem;
        private Button btnDeleteItem;
        private Label label3;
        private Label lblMaxSpending;
        private Panel panel1;
        private TextBox txtExpenseAmount;
        private TextBox txtExpenseName;
        private Label label2;
        private Label label1;
        private ColumnHeader columnName;
        private ColumnHeader columnAmount;
        private Button btnSubmit;
    }
}
