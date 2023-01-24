using Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Reinigungsverwaltung.Tests;

public class GuestTests : DatabaseTest
{
    
    public GuestTests()
    {
        _db.Database.EnsureCreated();
        var Guest = new Guest("Max", "Müller", "Linzerstrasse 12", new DateTime(2000-07-11) );
        _db.Guest.Add(Guest);
        _db.SaveChanges();
    }

    [Fact]
    public override string? ToString()
    {
        Assert.True(_db.Guest.First().ToString() == "Max"+ "Müller" + "Linzerstrasse 12" + DateTime.Now);
        return ToString();
    }
}
