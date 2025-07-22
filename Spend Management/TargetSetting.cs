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
            connectionString = $"Data Source=expense_data.db;Version=3;";
        }
        public void SaveTargetSettings(int userId, decimal income, decimal saving)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string upsert = @"
            INSERT INTO FinancialGoals (UserId, Income, SavingTarget)
            VALUES (@userId, @income, @saving)
            ON CONFLICT(UserId) DO UPDATE SET Income = @income, SavingTarget = @saving;";

            using var cmd = new SQLiteCommand(upsert, connection);

            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@income", income);
            cmd.Parameters.AddWithValue("@saving", saving);

            cmd.ExecuteNonQuery();
        }

        public (decimal income, decimal saving) ReadTargetSettings(int userId)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string select = @"SELECT Income, SavingTarget
                                FROM FinancialGoals
                                WHERE UserId = @userId;";

            using var cmd = new SQLiteCommand(select, connection);
            cmd.Parameters.AddWithValue("@userId", userId);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return (
                    (decimal)(double)reader["Income"], 
                    (decimal)(double)reader["SavingTarget"]
                );
            }
            return (0, 0);
        }

        public void AddBudgets(BudgetItem budgetItem)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string insertCategory = "INSERT INTO Categories (UserId, Name) VALUES (@userId, @name);";
            using var cmd1 = new SQLiteCommand(insertCategory, connection);
            cmd1.Parameters.AddWithValue("@userId", budgetItem.UserId);
            cmd1.Parameters.AddWithValue("@name", budgetItem.Name);
            cmd1.ExecuteNonQuery();

            // 2. Lấy CategoryId vừa thêm
            string getCategoryId = "SELECT last_insert_rowid();";
            using var cmdGetId = new SQLiteCommand(getCategoryId, connection);
            long categoryId = (long)cmdGetId.ExecuteScalar();

            string insertBudget = @"
                INSERT INTO Budgets (UserId, CategoryId, Amount) 
                VALUES (@userId, @categoryId, @amount);
            ";
            using var cmd2 = new SQLiteCommand(insertBudget, connection);
            cmd2.Parameters.AddWithValue("@userId", budgetItem.UserId);
            cmd2.Parameters.AddWithValue("@categoryId", categoryId); // phải có CategoryId
            cmd2.Parameters.AddWithValue("@amount", budgetItem.Amount);
            cmd2.ExecuteNonQuery();
        }

        public void UpdateExpense(BudgetItem budgetItem)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string update = @"
                UPDATE Budgets
                SET CategoryId = @categoryId, Amount = @amount
                WHERE BudgetId = @budgetId AND UserId = @userId;
            ";
            using var cmd = new SQLiteCommand(update, connection);
            cmd.Parameters.AddWithValue("@categoryId", budgetItem.CategoryId);
            cmd.Parameters.AddWithValue("@amount", budgetItem.Amount);
            cmd.Parameters.AddWithValue("@budgetId", budgetItem.BudgetId);
            cmd.Parameters.AddWithValue("@userId", budgetItem.UserId);
            cmd.ExecuteNonQuery();
        }

        public void DeleteExpense(BudgetItem budgetItem)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string delete = "DELETE FROM Budgets WHERE BudgetId = @budgetId AND UserId = @userId;";
            using var cmd = new SQLiteCommand(delete, connection);
            cmd.Parameters.AddWithValue("@budgetId", budgetItem.BudgetId);
            cmd.Parameters.AddWithValue("@userId", budgetItem.UserId);
            cmd.ExecuteNonQuery();
        }

        public List<BudgetItem> GetAllBudgets(int userId)
        {
            var list = new List<BudgetItem>();

            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string select = @"
                SELECT b.BudgetId, b.CategoryId, c.Name AS CategoryName, b.Amount
                FROM Budgets b
                INNER JOIN Categories c ON b.CategoryId = c.CategoryId
                WHERE b.UserId = @userId;
            ";
            using var cmd = new SQLiteCommand(select, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new BudgetItem
                {
                    BudgetId = Convert.ToInt32(reader["BudgetId"]),
                    CategoryId = Convert.ToInt32(reader["CategoryId"]),
                    Name = reader["CategoryName"].ToString(),
                    Amount = Convert.ToDecimal(reader["Amount"]),
                    UserId = userId
                });;
            }

            return list;
        }
    }

    public class BudgetItem
    {
        public int BudgetId { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }  // thêm trường này
        public string Name { get; set; } // tên category, để hiển thị
        public decimal Amount { get; set; }
    }
}