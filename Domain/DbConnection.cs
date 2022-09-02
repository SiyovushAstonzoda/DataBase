using System.Security.AccessControl;

namespace Domain;

public abstract class DbConnection
{
    public string? ConnectionString { get; private set; }

    public TimeSpan Timeout { get; private set; }

    public DbConnection(string? ConnectionString, TimeSpan timeout)
    {
        this.ConnectionString = ConnectionString;
        this.Timeout = timeout;
    }
    

    public abstract void Open();
    public abstract void Closed();
}
