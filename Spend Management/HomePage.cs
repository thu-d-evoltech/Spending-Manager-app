namespace Spend_Management
{
    public partial class HomePage : UserControl
    {
        private BudgetManager budgetManager;
        private int currentUserId;

        public HomePage()
        {
            InitializeComponent();
            budgetManager = new BudgetManager("Data Source=spend_data.db");
            currentUserId = Session.CurrentUserId;
        }

        public void LoadSummaryData()
        {
            // 1. Đọc dữ liệu từ BudgetSettings
            var (income, saving) = budgetManager.ReadBudgetSettings(currentUserId);
            decimal maxSpending = income - saving;

            // 2. Lấy danh sách chi tiêu
            var expenses = budgetManager.GetAllExpenses(currentUserId);

            // 3. Tính tổng chi tiêu
            decimal totalSpending = expenses.Sum(e => e.Amount);
            txtSpendTotal.Text = totalSpending.ToString("N0");
            decimal balance = maxSpending - totalSpending;
            txtBalance.Text = balance.ToString("N0");

            // 4. Hiển thị danh sách vào listViewSpending
            listViewSpending.Items.Clear();
            foreach (var expense in expenses)
            {
                var item = new ListViewItem(expense.Category);
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