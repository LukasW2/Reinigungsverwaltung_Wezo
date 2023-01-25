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
        _db.Room.Add(room);
        
        var hotel = new Hotel("Kulka", "Sloncegasse 7");
        _db.Hotel.Add(hotel);
        _db.SaveChanges();
    }
    
    [Fact]
    public void AddRoomSuccessTt()
    {
        Assert.True(_db.Room.ToList().Count == 1);
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
        Assert.True(_db.Hotel.First().RoomQuantity() == 1);
    }
    
    [Fact]
    public void CalcAvgPointsSuccessTt()
    {
        
    }
    
    
    
}