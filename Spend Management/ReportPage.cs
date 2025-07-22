using System.Data.SQLite;

namespace Spend_Management
{
    public partial class ReportPage : UserControl
    {
        private int currentUserId;

        public ReportPage()
        {
            InitializeComponent();
            currentUserId = Session.CurrentUserId;
            dataGridViewReport.AutoGenerateColumns = true;
        }
        public class TransactionItem
        {
            public string Date { get; set; }
            public string CategoryName { get; set; }
            public double Amount { get; set; }
            public string Type { get; set; }
            public string Note { get; set; }
        }

        public List<TransactionItem> GetTransactions(int userId)
        {
            var list = new List<TransactionItem>();

            using var connection = new SQLiteConnection("Data Source=expense_data.db");
            connection.Open();

            string query = @"
                SELECT t.Date, c.Name AS CategoryName, t.Amount, t.Type, t.Note
                FROM Transactions t
                JOIN Categories c ON t.CategoryId = c.CategoryId
                WHERE t.UserId = @userId
                ORDER BY t.Date DESC";

            using var command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@userId", userId);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var item = new TransactionItem
                {
                    Date = reader.GetString(0),
                    CategoryName = reader.GetString(1),
                    Amount = reader.GetDouble(2),
                    Type = reader.GetString(3),
                    Note = reader.IsDBNull(4) ? "" : reader.GetString(4)
                };

                list.Add(item);
            }

            return list;
        }

        public void LoadTransactions(int userId)
        {
            
            var transactions = GetTransactions(userId); // Lấy dữ liệu từ DB

            dataGridViewReport.Rows.Clear(); // Xóa dòng cũ (nếu có)

            foreach (var transaction in transactions)
            {
                dataGridViewReport.Rows.Add(
                    transaction.Date,
                    transaction.CategoryName,
                    transaction.Amount,
                    transaction.Type,
                    transaction.Note
                );
            }
        }

        private void ReportPage_Load(object sender, EventArgs e)
        {
            LoadTransactions(currentUserId);
        }
    }
}
