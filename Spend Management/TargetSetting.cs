using System.Data.SQLite;

namespace Spend_Management
{
    /// <summary>
    /// 
    /// </summary>
    public class TargetSetting
    {
        private string connectionString;
        /// <summary>
        /// 
        /// </summary>
        public TargetSetting(string dbPath)
        {
            connectionString = $"Data Source={dbPath};Version=3;";
        }
        public void SaveTargetSettings(int userId, decimal income, decimal saving, decimal spending)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string currentMonth = DateTime.Now.ToString("yyyy-MM");

            string upsert = @"
            INSERT INTO FinancialGoals (UserId, Month, Income, SavingTarget, SpendingAvailable)
            VALUES (@userId, @month, @income, @saving, @spending)
            ON CONFLICT(UserId, Month) DO UPDATE SET Income = @income, Saving = @saving, SpendingAvailable = @spending;";

            using var cmd = new SQLiteCommand(upsert, connection);

            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@month", currentMonth);
            cmd.Parameters.AddWithValue("@income", income);
            cmd.Parameters.AddWithValue("@saving", saving);
            cmd.Parameters.AddWithValue("@spending", spending);

            cmd.ExecuteNonQuery();
        }

        public (decimal income, decimal saving) ReadTargetSettings(int userId)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string select = "SELECT Income, Saving FROM BudgetSettings WHERE UserId = @userId;";
            using var cmd = new SQLiteCommand(select, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return ((decimal)(double)reader[0], (decimal)(double)reader[1]);
            }
            return (0, 0);
        }

        public void AddExpense(ExpenseItem expenseItem)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string insert = "INSERT INTO Expenses (UserId, Category, Amount) VALUES (@userId, @category, @amount);";
            using var cmd = new SQLiteCommand(insert, connection);
            cmd.Parameters.AddWithValue("@userId", expenseItem.UserId);
            cmd.Parameters.AddWithValue("@name", expenseItem.Category);
            cmd.Parameters.AddWithValue("@amount", expenseItem.Amount);
            cmd.ExecuteNonQuery();
        }

        public void UpdateExpense(ExpenseItem expenseItem)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string update = "UPDATE Expenses SET Category = @category, Amount = @amount WHERE Id = @id AND UserId = @userId;";
            using var cmd = new SQLiteCommand(update, connection);
            cmd.Parameters.AddWithValue("@name", expenseItem.Category);
            cmd.Parameters.AddWithValue("@amount", expenseItem.Amount);
            cmd.Parameters.AddWithValue("@id", expenseItem.Id);
            cmd.Parameters.AddWithValue("@userId", expenseItem.UserId);
            cmd.ExecuteNonQuery();
        }

        public void DeleteExpense(ExpenseItem expenseItem)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string delete = "DELETE FROM Expenses WHERE Id = @id AND UserId = @userId;";
            using var cmd = new SQLiteCommand(delete, connection);
            cmd.Parameters.AddWithValue("@id", expenseItem.Id);
            cmd.Parameters.AddWithValue("@userId", expenseItem.UserId);
            cmd.ExecuteNonQuery();
        }

        public List<ExpenseItem> GetAllExpenses(int userId)
        {
            var list = new List<ExpenseItem>();

            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string select = "SELECT Id, Category, Amount FROM Expenses WHERE UserId = @userId;";
            using var cmd = new SQLiteCommand(select, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new ExpenseItem
                {
                    Id = Convert.ToInt32(reader[0]),
                    Category = reader[1].ToString(),
                    Amount = (decimal)(double)reader[2],
                    UserId = userId
                });;
            }

            return list;
        }
    }

    public class ExpenseItem
    {
        public int BudgetId { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Month { get; set; }
        public decimal Amount { get; set; }
    }
}