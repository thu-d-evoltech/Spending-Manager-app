

namespace Spend_Management
{
    public partial class TargetPage : UserControl
    {
        private BudgetManager budgetManager;
        private int currentUserId;
        // Khai báo event
        public event EventHandler DataSubmitted;

        public TargetPage()
        {
            InitializeComponent();
            budgetManager = new BudgetManager("Data Source=spend_data.db");
            budgetManager.InitializeDatabase();
            currentUserId = Session.CurrentUserId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TargetPage_Load(object sender, EventArgs e)
        {
            LoadBudgetData();
            LoadExpenses();
        }

        private void LoadBudgetData()
        {
            var (income, saving) = budgetManager.ReadBudgetSettings(currentUserId);
            txtTotal.Text = income.ToString();
            txtSavingGoal.Text = saving.ToString();
            lblMaxSpending.Text = $"{(income - saving):C}";
        }

        private void BudgetValue_Changed()
        {
            if (decimal.TryParse(txtTotal.Text, out decimal income) &&
                decimal.TryParse(txtSavingGoal.Text, out decimal saving))
            {
                lblMaxSpending.Text = $"{(income - saving):C}";
                budgetManager.SaveBudgetSettings(currentUserId, income, saving);
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            BudgetValue_Changed();
        }

        private void txtSavingGoal_TextChanged(object sender, EventArgs e)
        {
            BudgetValue_Changed();
        }

        private void LoadExpenses()
        {
            listViewExpense.Items.Clear();
            var expenses = budgetManager.GetAllExpenses(currentUserId);
            foreach (var expense in expenses)
            {
                var item = new ListViewItem(expense.Category);
                item.SubItems.Add(expense.Amount.ToString("N0"));
                item.Tag = expense;
                listViewExpense.Items.Add(item);
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtExpenseAmount.Text, out decimal amount) || string.IsNullOrWhiteSpace(txtExpenseCategory.Text))
            {
                MessageBox.Show("経費名と有効な金額を入力してください。");
                return;
            }

            var expense = new ExpenseItem
            {
                Category = txtExpenseCategory.Text,
                Amount = amount,
                UserId = currentUserId,
            };

            budgetManager.AddExpense(expense);
            LoadExpenses();

            txtExpenseCategory.Clear();
            txtExpenseAmount.Clear();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (listViewExpense.SelectedItems.Count == 0) return;

            var selectedItem = listViewExpense.SelectedItems[0];
            var oldName = selectedItem.Name;
            var expense = (ExpenseItem)selectedItem.Tag;

            if (!decimal.TryParse(txtExpenseAmount.Text, out decimal newAmount))
            {
                MessageBox.Show("金額は入力していません。");
                return;
            }

            txtExpenseCategory.Text = oldName;
            expense.Amount = newAmount;

            budgetManager.UpdateExpense(expense);
            LoadExpenses();

            txtExpenseCategory.Clear();
            txtExpenseAmount.Clear();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (listViewExpense.SelectedItems.Count == 0) return;

            var selectedItem = listViewExpense.SelectedItems[0];
            var expense = (ExpenseItem)selectedItem.Tag;

            var result = MessageBox.Show("この項目を削除してもよろしいですか?", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                budgetManager.DeleteExpense(expense);
                LoadExpenses();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("入力データが保存しました。");

            DataSubmitted?.Invoke(this, EventArgs.Empty);
        }
    }
}
