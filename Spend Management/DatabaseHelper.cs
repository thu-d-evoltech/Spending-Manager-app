using System.Data.SQLite;

namespace Spend_Management
{
    public static class DatabaseHelper
    {
        private static string dbPath = "expense_data.db";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection($"Data Source={dbPath};Version=3;");
        }
        public static void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();

                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserId INTEGER PRIMARY KEY, 
                    username TEXT UNIQUE, 
                    password TEXT
                );
                
                CREATE TABLE IF NOT EXISTS Categories (
                    CategoryId INTEGER PRIMARY KEY,
                    UserId INTEGER NOT NULL,
                    Name TEXT NOT NULL,
                    FOREIGN KEY (UserId) REFERENCES Users(UserId)
                );

                CREATE TABLE IF NOT EXISTS Transactions (
                    TransactionId INTEGER PRIMARY KEY,
                    UserId INTEGER NOT NULL,
                    CategoryId INTEGER,
                    Amount REAL NOT NULL,
                    Type TEXT CHECK (Type IN ('入金', '出金')),
                    Note TEXT,
                    Date TEXT NOT NULL,
                    FOREIGN KEY(UserId) REFERENCES Users(UserId),
                    FOREIGN KEY(CategoryId) REFERENCES Categories(CategoryId)
                );

                CREATE TABLE IF NOT EXISTS FinancialGoals (
                    GoalId INTEGER PRIMARY KEY,
                    UserId INTEGER NOT NULL,
                    Income REAL NOT NULL,
                    SavingTarget REAL NOT NULL,
                    FOREIGN KEY (UserId) REFERENCES Users(UserId),
                    UNIQUE (UserId)
                );

                CREATE TABLE IF NOT EXISTS Budgets (
                    BudgetId INTEGER PRIMARY KEY,
                    UserId INTEGER NOT NULL,
                    CategoryId INTEGER NOT NULL,
                    Amount REAL NOT NULL,
                    FOREIGN KEY(UserId) REFERENCES Users(UserId),
                    FOREIGN KEY(CategoryId) REFERENCES Categories(CategoryId)
                );";

                command.ExecuteNonQuery();
            }
        }
        /*public static void PrintAllTables()
        {
            using (var connection = new SQLiteConnection("Data Source=expense_data.db"))
            {
                connection.Open();

                using var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT name FROM sqlite_master WHERE type='table';";

                using var reader = cmd.ExecuteReader();
                MessageBox.Show("📋 Tables in this DB:");
                while (reader.Read())
                {
                    MessageBox.Show("   - " + reader.GetString(0));
                }
            }
        }*/

    }
}
