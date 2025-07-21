namespace Spend_Management
{
    partial class LoginControl
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
            panel1 = new Panel();
            label3 = new Label();
            btnRegister = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(81, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 283);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.BackColor = Color.LemonChiffon;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("メイリオ", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(345, 34);
            label3.TabIndex = 9;
            label3.Text = "ログイン";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.ForeColor = Color.Blue;
            btnRegister.Location = new Point(218, 232);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(115, 30);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "ユーザー登録はこちら";
            btnRegister.TextAlign = ContentAlignment.MiddleCenter;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(48, 113);
            label2.Name = "label2";
            label2.Size = new Size(47, 13);
            label2.TabIndex = 7;
            label2.Text = "パスワード";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(48, 51);
            label1.Name = "label1";
            label1.Size = new Size(50, 13);
            label1.TabIndex = 6;
            label1.Text = "ログインID";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtPassword.Location = new Point(48, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(245, 25);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtUsername.Location = new Point(48, 69);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(245, 25);
            txtUsername.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(0, 192, 192);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnLogin.Font = new Font("メイリオ", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 128);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(93, 171);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 43);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "ログイン";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "LoginControl";
            Size = new Size(534, 522);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label btnRegister;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
    }
}
