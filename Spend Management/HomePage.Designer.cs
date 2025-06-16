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
            textBox2 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            panelButton = new Panel();
            btnListEdit = new Button();
            btnEditSave = new Button();
            btnAddItem = new Button();
            panel7 = new Panel();
            btnDelete5 = new Button();
            label14 = new Label();
            textBox7 = new TextBox();
            panel6 = new Panel();
            btnDelete4 = new Button();
            label12 = new Label();
            textBox6 = new TextBox();
            panel5 = new Panel();
            btnDelete3 = new Button();
            label7 = new Label();
            textBox5 = new TextBox();
            panel4 = new Panel();
            btnDelete2 = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            panel3 = new Panel();
            btnDelete1 = new Button();
            label8 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            flowLayoutPanel_List = new FlowLayoutPanel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelButton.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel_List.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(30, 345);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 117);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bank_cash_coin_dollar_money_icon;
            pictureBox2.Location = new Point(203, 12);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 61);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label5.Location = new Point(171, 75);
            label5.Name = "label5";
            label5.Size = new Size(32, 28);
            label5.TabIndex = 3;
            label5.Text = "円";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox2.Location = new Point(9, 69);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(155, 31);
            textBox2.TabIndex = 2;
            textBox2.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.Location = new Point(9, 7);
            label2.Name = "label2";
            label2.Size = new Size(52, 28);
            label2.TabIndex = 0;
            label2.Text = "支出";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(30, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 117);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cash_coin_dollar_money_icon1;
            pictureBox1.Location = new Point(203, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 61);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label4.Location = new Point(171, 72);
            label4.Name = "label4";
            label4.Size = new Size(32, 28);
            label4.TabIndex = 2;
            label4.Text = "円";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox1.Location = new Point(9, 68);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(155, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.Location = new Point(9, 7);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 0;
            label3.Text = "残高";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelButton
            // 
            panelButton.BackColor = Color.CornflowerBlue;
            panelButton.Controls.Add(btnListEdit);
            panelButton.Controls.Add(btnEditSave);
            panelButton.Controls.Add(btnAddItem);
            panelButton.Location = new Point(35, 388);
            panelButton.Margin = new Padding(35, 13, 35, 5);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(305, 40);
            panelButton.TabIndex = 8;
            // 
            // btnListEdit
            // 
            btnListEdit.Location = new Point(233, 0);
            btnListEdit.Margin = new Padding(50, 3, 50, 3);
            btnListEdit.Name = "btnListEdit";
            btnListEdit.Size = new Size(59, 40);
            btnListEdit.TabIndex = 2;
            btnListEdit.Text = "修正";
            btnListEdit.UseVisualStyleBackColor = true;
            btnListEdit.Click += btnListEdit_Click;
            // 
            // btnEditSave
            // 
            btnEditSave.Location = new Point(123, 0);
            btnEditSave.Margin = new Padding(50, 3, 50, 3);
            btnEditSave.Name = "btnEditSave";
            btnEditSave.Size = new Size(59, 40);
            btnEditSave.TabIndex = 1;
            btnEditSave.Text = "保存";
            btnEditSave.UseVisualStyleBackColor = true;
            btnEditSave.Visible = false;
            btnEditSave.Click += btnEditSave_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(15, 0);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(59, 40);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "追加";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Visible = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.PaleTurquoise;
            panel7.Controls.Add(btnDelete5);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(textBox7);
            panel7.Location = new Point(35, 319);
            panel7.Margin = new Padding(35, 5, 35, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(305, 51);
            panel7.TabIndex = 7;
            // 
            // btnDelete5
            // 
            btnDelete5.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete5.Location = new Point(269, 11);
            btnDelete5.Name = "btnDelete5";
            btnDelete5.Size = new Size(33, 35);
            btnDelete5.TabIndex = 7;
            btnDelete5.Text = "X";
            btnDelete5.UseVisualStyleBackColor = false;
            btnDelete5.Visible = false;
            btnDelete5.Click += DeletePanel_Click;
            // 
            // label14
            // 
            label14.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label14.Location = new Point(3, 13);
            label14.Name = "label14";
            label14.Size = new Size(72, 28);
            label14.TabIndex = 4;
            label14.Text = "その他";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ButtonHighlight;
            textBox7.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox7.Location = new Point(78, 11);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(185, 31);
            textBox7.TabIndex = 2;
            textBox7.Text = "0円";
            textBox7.TextAlign = HorizontalAlignment.Right;
            // 
            // panel6
            // 
            panel6.BackColor = Color.PaleTurquoise;
            panel6.Controls.Add(btnDelete4);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(textBox6);
            panel6.Location = new Point(35, 258);
            panel6.Margin = new Padding(35, 5, 35, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(305, 51);
            panel6.TabIndex = 6;
            // 
            // btnDelete4
            // 
            btnDelete4.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete4.Location = new Point(269, 11);
            btnDelete4.Name = "btnDelete4";
            btnDelete4.Size = new Size(33, 35);
            btnDelete4.TabIndex = 7;
            btnDelete4.Text = "X";
            btnDelete4.UseVisualStyleBackColor = false;
            btnDelete4.Visible = false;
            btnDelete4.Click += DeletePanel_Click;
            // 
            // label12
            // 
            label12.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label12.Location = new Point(3, 13);
            label12.Name = "label12";
            label12.Size = new Size(72, 28);
            label12.TabIndex = 4;
            label12.Text = "生活費";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ButtonHighlight;
            textBox6.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox6.Location = new Point(81, 11);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(182, 31);
            textBox6.TabIndex = 2;
            textBox6.Text = "0円";
            textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // panel5
            // 
            panel5.BackColor = Color.PaleTurquoise;
            panel5.Controls.Add(btnDelete3);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(textBox5);
            panel5.Location = new Point(35, 197);
            panel5.Margin = new Padding(35, 5, 35, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(305, 51);
            panel5.TabIndex = 5;
            // 
            // btnDelete3
            // 
            btnDelete3.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete3.Location = new Point(269, 11);
            btnDelete3.Name = "btnDelete3";
            btnDelete3.Size = new Size(33, 35);
            btnDelete3.TabIndex = 7;
            btnDelete3.Text = "X";
            btnDelete3.UseVisualStyleBackColor = false;
            btnDelete3.Visible = false;
            btnDelete3.Click += DeletePanel_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label7.Location = new Point(3, 13);
            label7.Name = "label7";
            label7.Size = new Size(72, 28);
            label7.TabIndex = 4;
            label7.Text = "交通費";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ButtonHighlight;
            textBox5.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox5.Location = new Point(78, 11);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(185, 31);
            textBox5.TabIndex = 2;
            textBox5.Text = "0円";
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PaleTurquoise;
            panel4.Controls.Add(btnDelete2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(textBox3);
            panel4.Location = new Point(35, 136);
            panel4.Margin = new Padding(35, 5, 35, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 51);
            panel4.TabIndex = 5;
            // 
            // btnDelete2
            // 
            btnDelete2.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete2.Location = new Point(269, 11);
            btnDelete2.Name = "btnDelete2";
            btnDelete2.Size = new Size(33, 35);
            btnDelete2.TabIndex = 6;
            btnDelete2.Text = "X";
            btnDelete2.UseVisualStyleBackColor = false;
            btnDelete2.Visible = false;
            btnDelete2.Click += DeletePanel_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 4;
            label1.Text = "家賃";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox3.Location = new Point(78, 17);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(185, 31);
            textBox3.TabIndex = 2;
            textBox3.Text = "0円";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleTurquoise;
            panel3.Controls.Add(btnDelete1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox4);
            panel3.Location = new Point(35, 75);
            panel3.Margin = new Padding(35, 5, 35, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 51);
            panel3.TabIndex = 4;
            // 
            // btnDelete1
            // 
            btnDelete1.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete1.Location = new Point(269, 11);
            btnDelete1.Name = "btnDelete1";
            btnDelete1.Size = new Size(33, 35);
            btnDelete1.TabIndex = 5;
            btnDelete1.Text = "X";
            btnDelete1.UseVisualStyleBackColor = false;
            btnDelete1.Visible = false;
            btnDelete1.Click += DeletePanel_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label8.Location = new Point(3, 13);
            label8.Name = "label8";
            label8.Size = new Size(72, 28);
            label8.TabIndex = 4;
            label8.Text = "食費";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonHighlight;
            textBox4.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox4.Location = new Point(78, 11);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(185, 31);
            textBox4.TabIndex = 2;
            textBox4.Text = "0円";
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.BackColor = Color.Yellow;
            label10.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label10.Location = new Point(75, 20);
            label10.Margin = new Padding(75, 20, 75, 11);
            label10.Name = "label10";
            label10.Size = new Size(225, 39);
            label10.TabIndex = 3;
            label10.Text = "カテゴリー";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_List
            // 
            flowLayoutPanel_List.Anchor = AnchorStyles.Top;
            flowLayoutPanel_List.AutoScroll = true;
            flowLayoutPanel_List.BackColor = Color.CornflowerBlue;
            flowLayoutPanel_List.Controls.Add(label10);
            flowLayoutPanel_List.Controls.Add(panel3);
            flowLayoutPanel_List.Controls.Add(panel4);
            flowLayoutPanel_List.Controls.Add(panel5);
            flowLayoutPanel_List.Controls.Add(panel6);
            flowLayoutPanel_List.Controls.Add(panel7);
            flowLayoutPanel_List.Controls.Add(panelButton);
            flowLayoutPanel_List.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_List.Location = new Point(375, 89);
            flowLayoutPanel_List.Name = "flowLayoutPanel_List";
            flowLayoutPanel_List.Size = new Size(376, 449);
            flowLayoutPanel_List.TabIndex = 4;
            flowLayoutPanel_List.WrapContents = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(flowLayoutPanel_List);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "HomePage";
            Size = new Size(793, 708);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelButton.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel_List.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panelButton;
        private Button btnListEdit;
        private Button btnEditSave;
        private Button btnAddItem;
        private Panel panel7;
        private Button btnDelete5;
        private Label label14;
        private TextBox textBox7;
        private Panel panel6;
        private Button btnDelete4;
        private Label label12;
        private TextBox textBox6;
        private Panel panel5;
        private Button btnDelete3;
        private Label label7;
        private TextBox textBox5;
        private Panel panel4;
        private Button btnDelete2;
        private Label label1;
        private TextBox textBox3;
        private Panel panel3;
        private Button btnDelete1;
        private Label label8;
        private TextBox textBox4;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel_List;
    }
}
