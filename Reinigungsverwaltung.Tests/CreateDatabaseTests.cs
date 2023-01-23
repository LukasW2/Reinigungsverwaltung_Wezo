using Xunit;

namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model.Reinigungsverwaltung.Tests;

public class CreateDatabaseTests : DatabaseTest
{
    [Fact]
    public void CreateDatabaseTest()
    {
        _db.Database.EnsureCreated();
    }
}