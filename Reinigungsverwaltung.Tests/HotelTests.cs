
using Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Reinigungsverwaltung.Tests;

public class HotelTests : DatabaseTest
{
    public HotelTests()
    {
        _db.Database.EnsureCreated();
        var Hotel1 = new Hotel("Pariser", "Pulkergasse 18");
       
        _db.Hotel.Add(Hotel1);
        _db.SaveChanges();
    }
    
    
    [Fact]
    public void AddHotelSuccessTt()
    {
        Assert.True(_db.Hotel.ToList().Count == 1);
    }
    
    public void AddRoomSuccessTt()
    {
        Assert.True(_db.Room.ToList().Count == 1);
    }
    
    public void RemoveRoomSuccessTt()
    {
        var room  = _db.Room.First();
        
       
        Hotel.RemoveRoom(room);
        _db.SaveChanges();

        _db.ChangeTracker.Clear();

        room = _db.Room.First();
        Assert.True(Hotel.Rooms.Count == 0);
    }
    
    
}