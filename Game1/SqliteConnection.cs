
internal class SqliteConnection : IDisposable
{
    public SqliteConnection(string connectionString)
    {
        ConnectionString = connectionString;
    }

    public string ConnectionString { get; }

    internal object CreateCommand()
    {
        throw new NotImplementedException();
    }

    internal void Open()
    {
        throw new NotImplementedException();
    }
}