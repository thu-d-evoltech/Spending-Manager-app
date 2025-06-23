namespace Spend_Management
{
    partial class HomePage
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
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            txtSpendTotal = new TextBox();
            label2 = new Label();
            pln = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            txtBalance = new TextBox();
            label3 = new Label();
            label10 = new Label();
            panelCategoryList = new FlowLayoutPanel();
            listViewSpending = new ListView();
            columnName = new ColumnHeader();
            columnAmount = new ColumnHeader();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pln.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelCategoryList.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtSpendTotal);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(26, 259);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 89);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bank_cash_coin_dollar_money_icon;
            pictureBox2.Location = new Point(178, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 46);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label5.Location = new Point(158, 56);
            label5.Name = "label5";
            label5.Size = new Size(26, 21);
            label5.TabIndex = 3;
            label5.Text = "円";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSpendTotal
            // 
            txtSpendTotal.BackColor = SystemColors.ButtonHighlight;
            txtSpendTotal.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtSpendTotal.Location = new Point(8, 52);
            txtSpendTotal.Margin = new Padding(3, 2, 3, 2);
            txtSpendTotal.Name = "txtSpendTotal";
            txtSpendTotal.ReadOnly = true;
            txtSpendTotal.Size = new Size(152, 27);
            txtSpendTotal.TabIndex = 2;
            txtSpendTotal.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.Location = new Point(8, 5);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 0;
            label2.Text = "総支出";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pln
            // 
            pln.Anchor = AnchorStyles.Top;
            pln.BackColor = SystemColors.ButtonHighlight;
            pln.BorderStyle = BorderStyle.Fixed3D;
            pln.Controls.Add(pictureBox1);
            pln.Controls.Add(label4);
            pln.Controls.Add(txtBalance);
            pln.Controls.Add(label3);
            pln.Location = new Point(26, 130);
            pln.Margin = new Padding(3, 2, 3, 2);
            pln.Name = "pln";
            pln.Size = new Size(239, 89);
            pln.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cash_coin_dollar_money_icon1;
            pictureBox1.Location = new Point(178, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 46);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label4.Location = new Point(158, 54);
            label4.Name = "label4";
            label4.Size = new Size(26, 21);
            label4.TabIndex = 2;
            label4.Text = "円";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBalance
            // 
            txtBalance.BackColor = SystemColors.ButtonHighlight;
            txtBalance.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtBalance.Location = new Point(8, 51);
            txtBalance.Margin = new Padding(3, 2, 3, 2);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(152, 27);
            txtBalance.TabIndex = 1;
            txtBalance.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.Location = new Point(8, 5);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 0;
            label3.Text = "口座残高";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = Color.Yellow;
            label10.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label10.Location = new Point(66, 15);
            label10.Margin = new Padding(66, 15, 66, 8);
            label10.Name = "label10";
            label10.Size = new Size(197, 29);
            label10.TabIndex = 3;
            label10.Text = "カテゴリー";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCategoryList
            // 
            panelCategoryList.Anchor = AnchorStyles.Top;
            panelCategoryList.AutoScroll = true;
            panelCategoryList.BackColor = Color.CornflowerBlue;
            panelCategoryList.Controls.Add(label10);
            panelCategoryList.Controls.Add(listViewSpending);
            panelCategoryList.FlowDirection = FlowDirection.TopDown;
            panelCategoryList.Location = new Point(328, 67);
            panelCategoryList.Margin = new Padding(3, 2, 3, 2);
            panelCategoryList.Name = "panelCategoryList";
            panelCategoryList.Size = new Size(329, 337);
            panelCategoryList.TabIndex = 4;
            panelCategoryList.WrapContents = false;
            // 
            // listViewSpending
            // 
            listViewSpending.Anchor = AnchorStyles.None;
            listViewSpending.Columns.AddRange(new ColumnHeader[] { columnName, columnAmount });
            listViewSpending.Location = new Point(32, 55);
            listViewSpending.Name = "listViewSpending";
            listViewSpending.Size = new Size(265, 257);
            listViewSpending.TabIndex = 4;
            listViewSpending.UseCompatibleStateImageBehavior = false;
            listViewSpending.View = View.Details;
            // 
            // columnName
            // 
            columnName.Width = 100;
            // 
            // columnAmount
            // 
            columnAmount.TextAlign = HorizontalAlignment.Center;
            columnAmount.Width = 161;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelCategoryList);
            Controls.Add(pln);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomePage";
            Size = new Size(694, 531);
            Load += HomePage_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pln.ResumeLayout(false);
            pln.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelCategoryList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Panel pln;
        private Label label3;
        private TextBox txtBalance;
        private TextBox txtSpendTotal;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label10;
        private FlowLayoutPanel panelCategoryList;
        private ListView listViewSpending;
        private ColumnHeader columnName;
        private ColumnHeader columnAmount;
    }
}
