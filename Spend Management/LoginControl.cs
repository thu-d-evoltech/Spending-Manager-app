using System.Data.SQLite;

namespace Spend_Management
{
    public partial class LoginControl : UserControl
    {
        private SQLiteConnection connection;
        private LoginForm loginForm;

        public LoginControl()
        {
            InitializeComponent();
            InitDatabase();
        }

        private void InitDatabase()
        {
            connection = new SQLiteConnection("Data Source=expense_data.db;Version=3;");
            connection.Open();

            string checkUser = "SELECT COUNT(*) FROM users WHERE username = 'admin';";
            SQLiteCommand checkCmd = new SQLiteCommand(checkUser, connection);
            long count = (long)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                string insertUser = "INSERT INTO users (username, password) VALUES ('admin', '123456');";
                SQLiteCommand insertCmd = new SQLiteCommand(insertUser, connection);
                insertCmd.ExecuteNonQuery();
            }
        }

        /*private void XoaDuLieuTest()
        {
            using (var conn = new SQLiteConnection("Data Source=chi_tieu.db;Version=3;"))
            {
                conn.Open();
                string query = "DELETE FROM users WHERE username != 'admin';";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show($"{rows} tài khoản đã bị xóa (ngoại trừ admin).");
            }
        }*///Xóa tầi khoản test

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            string query = "SELECT UserId FROM users WHERE username = @user AND password = @pass;";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                int userId = Convert.ToInt32(result);

                // Gán userId vào Session
                Session.CurrentUserId = userId;

                MainForm main = new MainForm();
                loginForm = (LoginForm)this.FindForm();
                main.Show();
                loginForm.Hide();
            }
            else
            {
                MessageBox.Show("ログインID又はパスワードが間違いました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            loginForm = (LoginForm)this.FindForm();
            loginForm.LoadPage(new RegisterPage());
        }
    }
}
