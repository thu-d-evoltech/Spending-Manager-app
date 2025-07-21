using System.Data.SQLite;

namespace Spend_Management
{
    public class DatabaseHelper
    {
        public void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection("Data Source=expense_data.db"))
            {
                connection.Open();
                var command = connection.CreateCommand();

                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserId INTEGER PRIMARY KEY AUTOINCREMENT, 
                    username TEXT UNIQUE, 
                    password TEXT
                );
                
                CREATE TABLE IF NOT EXISTS Categories (
                    CategoryId INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    Name TEXT NOT NULL,
                    Type TEXT NOT NULL CHECK (Type IN ('income', 'expense')),
                    FOREIGN KEY (UserId) REFERENCES Users(UserId)
                );

                CREATE TABLE IF NOT EXISTS Accounts (
                    AccountId INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    Name TEXT NOT NULL,
                    Balance REAL DEFAULT 0,
                    FOREIGN KEY(UserId) REFERENCES Users(UserId)
                );

                CREATE TABLE IF NOT EXISTS Transactions (
                    TransactionId INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    CategoryId INTEGER NOT NULL,
                    AccountId INTEGER NOT NULL,
                    Amount REAL NOT NULL,
                    Note TEXT,
                    Date TEXT NOT NULL,
                    FOREIGN KEY(UserId) REFERENCES Users(UserId),
                    FOREIGN KEY(CategoryId) REFERENCES Categories(CategoryId)
                    FOREIGN KEY(AccountId) REFERENCES Accounts(AccountId)
                );

                CREATE TABLE IF NOT EXISTS Budgets (
                    BudgetId INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    CategoryId INTEGER NOT NULL,
                    Month TEXT NOT NULL,
                    Amount REAL NOT NULL,
                    FOREIGN KEY(UserId) REFERENCES Users(UserId),
                    FOREIGN KEY(CategoryId) REFERENCES Categories(CategoryId)
                );";

                command.ExecuteNonQuery();
            }
        }
    }
}
