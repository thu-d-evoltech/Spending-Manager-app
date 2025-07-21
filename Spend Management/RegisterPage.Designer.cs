namespace Spend_Management
{
    partial class RegisterPage
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtPasswordConfirm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSubmit = new Button();
            BtnBackToLogin = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtUsername.Location = new Point(104, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(242, 25);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtPassword.Location = new Point(104, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(242, 25);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPasswordConfirm.BackColor = Color.White;
            txtPasswordConfirm.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordConfirm.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtPasswordConfirm.Location = new Point(104, 153);
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.Size = new Size(242, 25);
            txtPasswordConfirm.TabIndex = 7;
            txtPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(35, 69);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 8;
            label1.Text = "ログインID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(35, 116);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "パスワード";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(13, 163);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 10;
            label3.Text = "パスワード確認";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 192, 192);
            btnSubmit.Font = new Font("メイリオ", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(140, 194);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(163, 44);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "登録";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // BtnBackToLogin
            // 
            BtnBackToLogin.AutoSize = true;
            BtnBackToLogin.Font = new Font("Yu Gothic UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 128);
            BtnBackToLogin.ForeColor = Color.Blue;
            BtnBackToLogin.Location = new Point(25, 246);
            BtnBackToLogin.Name = "BtnBackToLogin";
            BtnBackToLogin.Size = new Size(63, 15);
            BtnBackToLogin.TabIndex = 13;
            BtnBackToLogin.Text = "ログイン戻る";
            BtnBackToLogin.Click += BtnBackToLogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(BtnBackToLogin);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPasswordConfirm);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(62, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 289);
            panel1.TabIndex = 14;
            // 
            // label5
            // 
            label5.BackColor = Color.LemonChiffon;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("メイリオ", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(403, 42);
            label5.TabIndex = 14;
            label5.Text = "登録";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "RegisterPage";
            Size = new Size(534, 522);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtPasswordConfirm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSubmit;
        private Label BtnBackToLogin;
        private Panel panel1;
        private Label label5;
    }
}
