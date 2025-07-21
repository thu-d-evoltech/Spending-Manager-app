namespace Spend_Management
{
    public partial class MainForm : Form
    {
        private TargetPage targetPage;
        private HomePage homePage;
        private SpendingPage spendingPage;
        private ReportPage reportPage;

        /// <summary>
        /// Khởi tạo Constructor của MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            targetPage = new TargetPage();
            homePage = new HomePage();
            spendingPage = new SpendingPage();
            reportPage = new ReportPage();

            targetPage.DataSubmitted += TargetPage_DataSubmitted;
            spendingPage.DataSubmitted += SpendingPage_DataSubmitted;
            this.Shown += MainForm_Shown;
        }

        /// <summary>
        /// Load lại data trên MainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            homePage.LoadSummaryData();
            spendingPage.LoadData();
        }

        /// <summary>
        /// Xử lý sự kiện khi dữ liệu từ TargetPage được gửi lên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TargetPage_DataSubmitted(object sender, EventArgs e)
        {
            // Ví dụ: gọi HomePage load lại dữ liệu
            homePage.LoadSummaryData();
            spendingPage.LoadData();
        }
        private void SpendingPage_DataSubmitted(object sender, EventArgs e)
        { 
        }

            bool isCollapsing = false;

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            isCollapsing = panelMenu.Width > 55;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsing)
            {
                panelMenu.Width -= 10;
                if (panelMenu.Width <= 55)
                {
                    timer1.Stop();
                }
            }
            else
            {
                panelMenu.Width += 10;
                if (panelMenu.Width >= 200)
                {
                    timer1.Stop();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPage(new HomePage());
        }

        private void LoadPage(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadPage(new HomePage());
        }

        private void btnSpend_Click(object sender, EventArgs e)
        {
            LoadPage(new SpendingPage());
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            LoadPage(new TargetPage());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadPage(reportPage);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("ログアウトしてもよろしいですか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Reset thông tin đăng nhập (ví dụ)
                Session.CurrentUserId = -1;

                // Hiện form đăng nhập
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                // Ẩn form chính
                this.Close();
            }
        }
    }
}
