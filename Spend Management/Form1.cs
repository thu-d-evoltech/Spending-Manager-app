namespace Spend_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
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

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            LoadPage(new StatisticalPage());
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            LoadPage(new TargetPage());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadPage(new ReportPage());
        }
    }
}
