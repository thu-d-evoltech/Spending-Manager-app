using System.Data.SQLite;

namespace Spend_Management
{
    public static class Database
    {
        private static string dbPath = "spend_data.db";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection($"Data Source={dbPath};Version=3;");
        }

        public static void Initialize()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

                using (var conn = GetConnection())
                {
                    conn.Open();
                    var cmd = conn.CreateCommand();

                    // Tạo bảng category
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Categories (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL
                        );
                    ";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
