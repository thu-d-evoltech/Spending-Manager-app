using System.Data.SQLite;
using System.Windows.Forms;

namespace Spend_Management
{
    public partial class SpendingPage : UserControl
    {
        private TargetSetting targetSetting;
        private int currentUserId;
        public event EventHandler DataSubmitted;

        public SpendingPage()
        {
            InitializeComponent();
            targetSetting = new TargetSetting("Data Source=expense_data.db");
            currentUserId = Session.CurrentUserId;
            LoadCategories();
        }

        public void LoadCategories()
        {
            // Lấy danh sách chi tiêu từ database
            var budgets = targetSetting.GetAllBudgets(currentUserId);

            // Lấy danh sách category duy nhất
            var categories = budgets
                 .GroupBy(b => new { b.CategoryId, b.Name })
                 .Select(g => new { CategoryId = g.Key.CategoryId, Name = g.Key.Name })
                 .ToList();

            // Xóa tất cả control cũ trong ListBox
            flpCategory.Controls.Clear();

            // Tạo RadioButton cho từng mục chi tiêu
            foreach (var category in categories)
            {
                var radio = new RadioButton();
                radio.Text = category.Name;   // Hiển thị tên chi tiêu
                radio.Tag = category.CategoryId;
                radio.AutoSize = true;
                radio.Margin = new Padding(5);   // Tạo khoảng cách cho đẹp

                flpCategory.Controls.Add(radio);
            }
        }

        private void InsertTransaction(TransactionItem transaction)
        {
            using var connection = new SQLiteConnection("Data Source=expense_data.db");
            connection.Open();

            string insert = @"
                INSERT INTO Transactions 
                (UserId, CategoryId, Amount, Type, Note, Date)
                VALUES (@userId, @categoryId, @amount, @type, @note, @date);
            ";

            using var cmd = new SQLiteCommand(insert, connection);
            cmd.Parameters.AddWithValue("@userId", transaction.UserId);
            cmd.Parameters.AddWithValue("@categoryId", transaction.CategoryId);
            cmd.Parameters.AddWithValue("@amount", transaction.Amount);
            cmd.Parameters.AddWithValue("@type", transaction.Type); 
            cmd.Parameters.AddWithValue("@note", transaction.Note ?? "");
            cmd.Parameters.AddWithValue("@date", transaction.Date.ToString("yyyy-MM-dd"));

            cmd.ExecuteNonQuery();
        }


        private void BtnOK_Click(object sender, EventArgs e)
        {
            var checkedRadio = flpCategory.Controls
                       .OfType<RadioButton>()
                       .FirstOrDefault(r => r.Checked);

            int selectedCategoryId = (int)checkedRadio.Tag;

            string type = radioButtonIncome.Checked ? "入金" : "出金";

            if (!double.TryParse(txtAmount.Text, out double amount))
            {
                MessageBox.Show("金額が正しくありません。");
                return;
            }

            var transaction = new TransactionItem
            {
                UserId = currentUserId,                     // Giả sử bạn lưu userId hiện tại
                CategoryId = selectedCategoryId,
                Amount = amount,
                Type = type,
                Note = txtNote.Text,
                Date = dateTimePicker.Value
            };

            InsertTransaction(transaction);
            MessageBox.Show("登録が完了しました！");

            //Clear dữ liệu đã nhập
            txtAmount.Clear();
            txtNote.Clear();
            dateTimePicker.Value = DateTime.Now;
            radioButtonIncome.Checked = false;
            radioButtonExpense.Checked = false;
            foreach (Control control in flpCategory.Controls)
            {
                if (control is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }
        }
    }

    public class TransactionItem
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; } 
        public string Note { get; set; }
        public DateTime Date { get; set; }
    }
}
