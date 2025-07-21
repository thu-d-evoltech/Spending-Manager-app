namespace Spend_Management
{
    public partial class SpendingPage : UserControl
    {
        private BudgetManager budgetManager;
        private int currentUserId;
        public event EventHandler DataSubmitted;

        public SpendingPage()
        {
            InitializeComponent();
            budgetManager = new BudgetManager("Data Source=spend_data.db");
            currentUserId = Session.CurrentUserId;
            LoadData();
        }

        public void LoadData()
        {
            // Lấy danh sách chi tiêu từ database
            var expenses = budgetManager.GetAllExpenses(currentUserId);

            // Xóa tất cả control cũ trong FlowLayoutPanel
            flpCategory.Controls.Clear();

            // Tạo RadioButton cho từng mục chi tiêu
            foreach (var expense in expenses)
            {
                var radio = new RadioButton();
                radio.Text = expense.Category;       // Hiển thị tên chi tiêu
                radio.Tag = expense;             // Lưu toàn bộ đối tượng nếu cần dùng sau
                radio.AutoSize = true;
                radio.Margin = new Padding(5);   // Tạo khoảng cách cho đẹp

                flpCategory.Controls.Add(radio);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string category = flpCategory.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;
            string amountText = txtAmount.Text.Trim();
            string type = rdoIncome.Checked ? "入金" : (rdoExpense.Checked ? "出金" : "");
            string note = txtNote.Text.Trim();

            // 2. Kiểm tra đầu vào
            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(amountText))
            {
                MessageBox.Show("すべての項目を入力してください。");
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount))
            {
                MessageBox.Show("金額は数字で入力してください。");
                return;
            }

            // 3. Lưu vào DB
            var expense = new ExpenseItem
            {
                UserId = currentUserId, 
                Category = category,
                Amount = amount,
            };

            budgetManager.AddExpense(expense);

            // Event khi nhấn OK
            DataSubmitted?.Invoke(this, EventArgs.Empty);

            // Xóa form
            txtAmount.Clear();
            txtNote.Clear();
            rdoIncome.Checked = false;
            rdoExpense.Checked = false;
            foreach (RadioButton r in flpCategory.Controls.OfType<RadioButton>())
                r.Checked = false;
        }
    }
}
