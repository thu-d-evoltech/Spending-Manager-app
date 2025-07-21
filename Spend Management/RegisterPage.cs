using System.Data.SQLite;

namespace Spend_Management
{
    public partial class RegisterPage : UserControl
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (user == "" || pass == "" || txtPasswordConfirm.Text.Trim() == "")
            {
                MessageBox.Show("すべての情報を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kết nối và sử dụng Database
            using (var connection = new SQLiteConnection("Data Source=spend_data.db;Version=3;"))
            {
                connection.Open();

                string checkUser = "SELECT COUNT(*) FROM users WHERE username = @user;";
                SQLiteCommand checkCmd = new SQLiteCommand(checkUser, connection);
                checkCmd.Parameters.AddWithValue("@user", user);
                long exists = (long)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("このユーザーIDは既に存在しています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtPassword.Text != txtPasswordConfirm.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp.", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string insert = "INSERT INTO users (username, password) VALUES (@user, @pass);";
                    SQLiteCommand insertCmd = new SQLiteCommand(insert, connection);
                    insertCmd.Parameters.AddWithValue("@user", user);
                    insertCmd.Parameters.AddWithValue("@pass", pass);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("登録に成功しました。", "成功");

                    // Chuyển hướng về lại giao diện đăng nhập
                    LoginForm loginForm = (LoginForm)this.FindForm();
                    loginForm.LoadPage(new LoginControl());
                }
            }
        }

        private void BtnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = (LoginForm)this.FindForm();
            loginForm.LoadPage(new LoginControl());
        }
    }
}
