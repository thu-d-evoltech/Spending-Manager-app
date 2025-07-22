namespace Spend_Management
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            LoadPage(new LoginControl());
        }

        public void LoadPage(UserControl uc)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }
    }
}
