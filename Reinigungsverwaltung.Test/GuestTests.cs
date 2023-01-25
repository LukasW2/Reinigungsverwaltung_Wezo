using Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Reinigungsverwaltung.Test;

public class GuestTests : DatabaseTest
{
    
    public GuestTests()
    {
        _db.Database.EnsureCreated();
        var guest = new Guest("Max", "Müller", "Linzerstrasse 12", new DateTime(2000-07-11) );
        if (guest == null) throw new ArgumentNullException(nameof(guest));
        _db.Guest.Add(guest);
        _db.SaveChanges();
    }

    [Fact]
    public void NameAndInfosSuccessTest()
    {
        Assert.Equal("Max Müller Linzerstrasse 12",_db.Guest.First().NameandInfos());
    }
}