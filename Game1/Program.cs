using Microsoft.Data.Sqlite;

internal class Program
{
    static void Main()
    {
        string connectionString = "Data Source=gamr.db";

        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Create table
            var createTableCmd = connection.CreateCommand();
            createTableCmd.CommandText =
            @"
                CREATE TABLE IF NOT EXISTS Players (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Score INTEGER NOT NULL
                );
            ";
            object value = createTableCmd.ExecuteNonQuery();

            // Insert data
            var insertCmd = connection.CreateCommand();
            insertCmd.CommandText =
            @"
                INSERT INTO Players (Name, Score)
                VALUES ('Alice', 100), ('Bob', 150);
            ";
            insertCmd.ExecuteNonQuery();

            // Read data
            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT Id, Name, Score FROM Players;";
            using (var reader = selectCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"Id: {reader.GetInt32(0)}, Name: {reader.GetString(1)}, Score: {reader.GetInt32(2)}");
                }
            }
        }
    }
}