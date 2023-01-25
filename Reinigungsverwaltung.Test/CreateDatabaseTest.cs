
namespace Reinigungsverwaltung.Reinigungsverwaltung.Test;

[Collection("Sequential")]
public class CreateDatabaseTest : DatabaseTest
{
    
    
    [Fact]
    public void CreateDatabaseSuccessTest()
    {
        _db.Database.EnsureCreated();
    }
}