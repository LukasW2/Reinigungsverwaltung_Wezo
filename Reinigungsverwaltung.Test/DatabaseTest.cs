using Reinigungsverwaltung.Application.Reinigungsverwaltung.Model.Reinigungsverwaltung.Infrastructure;

namespace Reinigungsverwaltung.Reinigungsverwaltung.Test;

using System.Diagnostics;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;


[Collection("Sequential")]
public class DatabaseTest : IDisposable
{
    private readonly SqliteConnection _connection;
    protected readonly ReinigungsverwaltungContext _db;

    public DatabaseTest()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();
        var opt = new DbContextOptionsBuilder()
            //.UseSqlite("Data Source=Reinigungsverwaltung.db") 
            .UseSqlite(_connection)  // Keep connection open (only needed with SQLite in memory db)
            .UseLazyLoadingProxies()
            .LogTo(message => Debug.WriteLine(message), Microsoft.Extensions.Logging.LogLevel.Information)
            .EnableSensitiveDataLogging()
            .Options;

        _db = new ReinigungsverwaltungContext(opt);
    }
    public void Dispose()
    {
        _db.Dispose();
        _connection.Dispose();
    }
}