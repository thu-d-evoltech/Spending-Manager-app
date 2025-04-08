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
            isCollapsing = panelMenu.Width > 49;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsing)
            {
                panelMenu.Width -= 10;
                if (panelMenu.Width <= 49)
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
    }
}
