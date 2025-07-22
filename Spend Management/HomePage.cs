namespace Spend_Management
{
    public partial class HomePage : UserControl
    {
        private TargetSetting targetSetting;
        private int currentUserId;
        

        public HomePage()
        {
            InitializeComponent();
            targetSetting = new TargetSetting("Data Source=expense_data.db");
            currentUserId = Session.CurrentUserId;
        }

        public void LoadSummaryData()
        {
            // 1. Đọc dữ liệu từ BudgetSettings
            var (income, saving) = targetSetting.ReadTargetSettings(currentUserId);
            decimal maxSpending = income - saving;

            // 2. Lấy danh sách chi tiêu
            
            var expenses = targetSetting.GetAllBudgets(currentUserId);

            // 3. Tính tổng chi tiêu
            decimal totalSpending = expenses.Sum(e => e.Amount);
            txtSpendTotal.Text = totalSpending.ToString("N0");
            decimal balance = maxSpending - totalSpending;
            txtBalance.Text = balance.ToString("N0");

            // 4. Hiển thị danh sách vào listViewSpending
            listViewSpending.Items.Clear();
            foreach (var expense in expenses)
            {
                var item = new ListViewItem(expense.Name);
                item.SubItems.Add(expense.Amount.ToString("N0"));
                item.Tag = expense;
                listViewSpending.Items.Add(item);
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadSummaryData();
        }
    }
}