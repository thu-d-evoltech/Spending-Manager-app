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
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            flowExpenseName = new FlowLayoutPanel();
            panel3.SuspendLayout();
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
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(radioButton1);
            panel3.Location = new Point(75, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 74);
            panel3.TabIndex = 38;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Yu Gothic UI", 12F);
            radioButton2.Location = new Point(18, 36);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "出金";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Yu Gothic UI", 12F);
            radioButton1.Location = new Point(18, 11);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "入金";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox3.Location = new Point(405, 309);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 29);
            textBox3.TabIndex = 36;
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
            // button1
            // 
            button1.Location = new Point(522, 390);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(93, 34);
            button1.TabIndex = 34;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox2.Location = new Point(405, 142);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 29);
            textBox2.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 27);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 40;
            // 
            // flowExpenseName
            // 
            flowExpenseName.AutoScroll = true;
            flowExpenseName.BorderStyle = BorderStyle.FixedSingle;
            flowExpenseName.FlowDirection = FlowDirection.TopDown;
            flowExpenseName.Location = new Point(75, 230);
            flowExpenseName.Name = "flowExpenseName";
            flowExpenseName.Size = new Size(185, 229);
            flowExpenseName.TabIndex = 41;
            // 
            // SpendingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowExpenseName);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Name = "SpendingPage";
            Size = new Size(694, 531);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox2;
        private Label label5;
        private FlowLayoutPanel flowExpenseName;
    }
}
