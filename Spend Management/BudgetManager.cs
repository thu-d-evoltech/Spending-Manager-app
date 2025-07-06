using System.Data.SQLite;

namespace Spend_Management
{
    /// <summary>
    /// 
    /// </summary>
    public class BudgetManager
    {
        private string connectionString;
        /// <summary>
        /// 
        /// </summary>
        public BudgetManager(string dbPath)
        {
            connectionString = dbPath;
        }

        public void InitializeDatabase()
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string createExpensesTable = @"
                CREATE TABLE IF NOT EXISTS Expenses (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    Date TEXT,
                    Name TEXT NOT NULL,
                    Amount REAL NOT NULL,
                    Type TEXT,
                    Note TEXT,
                    FOREIGN KEY (UserId) REFERENCES users(id)
                );";

            string createBudgetSettingsTable = @"
                CREATE TABLE IF NOT EXISTS BudgetSettings (
                    UserId INTEGER PRIMARY KEY,
                    Income REAL NOT NULL,
                    Saving REAL NOT NULL,
                    FOREIGN KEY (UserId) REFERENCES users(id)
                );";

            using var cmd1 = new SQLiteCommand(createExpensesTable, connection);
            using var cmd2 = new SQLiteCommand(createBudgetSettingsTable, connection);

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            // Thêm bản ghi mặc định nếu chưa có
            string insertDefault = @"
            INSERT OR IGNORE INTO BudgetSettings (UserId, Income, Saving) VALUES (1, 0, 0);";
            using var cmd3 = new SQLiteCommand(insertDefault, connection);
            cmd3.ExecuteNonQuery();
        }

        public void SaveBudgetSettings(int userId, decimal income, decimal saving)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string upsert = @"
            INSERT INTO BudgetSettings (UserId, Income, Saving)
            VALUES (@userId, @income, @saving)
            ON CONFLICT(UserId) DO UPDATE SET Income = @income, Saving = @saving;";

            using var cmd = new SQLiteCommand(upsert, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@income", income);
            cmd.Parameters.AddWithValue("@saving", saving);
            cmd.ExecuteNonQuery();
        }

        public (decimal income, decimal saving) ReadBudgetSettings(int userId)
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

            string insert = "INSERT INTO Expenses (UserId, Name, Amount) VALUES (@userId, @name, @amount);";
            using var cmd = new SQLiteCommand(insert, connection);
            cmd.Parameters.AddWithValue("@userId", expenseItem.UserId);
            cmd.Parameters.AddWithValue("@name", expenseItem.Name);
            cmd.Parameters.AddWithValue("@amount", expenseItem.Amount);
            cmd.ExecuteNonQuery();
        }

        public void UpdateExpense(ExpenseItem expenseItem)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string update = "UPDATE Expenses SET Name = @name, Amount = @amount WHERE Id = @id AND UserId = @userId;";
            using var cmd = new SQLiteCommand(update, connection);
            cmd.Parameters.AddWithValue("@name", expenseItem.Name);
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

            string select = "SELECT Id, Name, Amount FROM Expenses WHERE UserId = @userId;";
            using var cmd = new SQLiteCommand(select, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new ExpenseItem
                {
                    Id = Convert.ToInt32(reader[0]),
                    Name = reader[1].ToString(),
                    Amount = (decimal)(double)reader[2],
                    UserId = userId
                });;
            }

            return list;
        }
    }

    public class ExpenseItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}



