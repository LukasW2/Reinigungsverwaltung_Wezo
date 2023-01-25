using Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;
using Reinigungsverwaltung.Model;
using Reinigungsverwaltung.Reinigungsverwaltung.Test;

namespace Reinigungsverwaltung.Reinigungsverwaltung.Tests;

public class HotelTests : DatabaseTest
{
    public HotelTests()
    {
        _db.Database.EnsureCreated();
        
        var room = new Room(8, 4, false, 9);
        var room2 = new Room(2, 2, false, 3);
        _db.Room.Add(room);
        _db.Room.Add(room2);
        var hotel = new Hotel("Kulka", "Sloncegasse 7" );
        _db.Hotel.Add(hotel);
        _db.SaveChanges();
    }
    
    [Fact]
    public void AddRoomSuccessTt()
    {
        Assert.True(_db.Hotel.ToList().Count == 1);
    }

    
    // das noch
    [Fact]
    public void RemoveRoomSuccessTt()
    {
        var hotel  = _db.Hotel.First();
        var room = _db.Room.First();
        hotel.RemoveRoom(room);
        _db.SaveChanges();
        
        _db.ChangeTracker.Clear();
                        
        hotel = _db.Hotel.First();
        Assert.Equal(0, hotel.RoomQuantity());
        
    }
    
    
    [Fact]
    public void RoomQuantitySuccessTt()
    {
        Assert.True(_db.Hotel.ToList().Count == 1);
    }
    
    [Fact]
    public void CalcAvgPointsSuccessTt()
    // Arrange
    {
        var hotel  = _db.Hotel.First();
        var room = _db.Room.First();
        var room2 = _db.Room.First();
        _db.SaveChanges();

    // Act
    var actualAvgPoints = (room.Points + room2.Points ) / 2;
    

    // Assert
    Assert.Equal(9, actualAvgPoints);
}
    
    
    
}