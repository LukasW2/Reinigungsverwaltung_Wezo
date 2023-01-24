using Xunit;

namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model.Reinigungsverwaltung.Tests;

public class GuestTests : DatabaseTest
{
    
    public GuestTests()
    {
        _db.Database.EnsureCreated();
        var Guest = new Guest( 1,"Max Müller", "Linzerstrasse 12", new DateTime(2000-07-11) , 
            new Reservation( 1, new Room(1, 3, true, 7), DateTime.Today, 
                new DateTime(2023-02-01)  )  );
        _db.Guest.Add(Guest);
        _db.SaveChanges();
    }

    [Fact]
    public override string? ToString()
    {
        Assert.True(_db.Guest.First().ToString() == "Max Müller " + "Linzerstrasse 12" + DateTime.Now);
        return ToString();
    }
}
