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
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(149, 276);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 117);
            panel2.TabIndex = 2;
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
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(149, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 117);
            panel3.TabIndex = 2;
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
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(593, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 417);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Location = new Point(19, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(290, 58);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(98, 7);
            label1.Name = "label1";
            label1.Size = new Size(145, 38);
            label1.TabIndex = 0;
            label1.Text = "支出一覧";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "HomePage";
            Size = new Size(1016, 602);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Panel panel4;
    }
}
