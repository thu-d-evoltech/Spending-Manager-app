namespace Spend_Management
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(210, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(534, 522);
            mainPanel.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 522);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 245);
            label2.Name = "label2";
            label2.Size = new Size(194, 32);
            label2.TabIndex = 2;
            label2.Text = "Money Manager";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bank_cash_coin_dollar_money_icon;
            pictureBox1.Location = new Point(71, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 48);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 201);
            label1.Name = "label1";
            label1.Size = new Size(146, 37);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 522);
            Controls.Add(panel2);
            Controls.Add(mainPanel);
            Name = "LoginForm";
            Text = "LoginForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblPassword;
        private Panel mainPanel;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}