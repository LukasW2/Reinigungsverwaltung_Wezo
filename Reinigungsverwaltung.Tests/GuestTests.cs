using Xunit;

namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model.Reinigungsverwaltung.Tests;

public class GuestTests : DatabaseTest
{
    
    public GuestTests()
    {
        _db.Database.EnsureCreated();
        var Guest = new Guest( 1,"Max Müller", "Linzerstrasse 12",  DateTime.Now ,  );
        _db.Guest.Add(Guest);
        _db.SaveChanges();
    }

    [Fact]
    public void ToString()
    {
        Assert.True(_db.Guest.First().ToString() == "Max Müller " + "Linzerstrasse 12" +DateTime.Now);
    }
}
