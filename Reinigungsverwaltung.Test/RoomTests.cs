using Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Reinigungsverwaltung.Test;

public class RoomTests : DatabaseTest
{
    public RoomTests()
    {
        
        {
            _db.Database.EnsureCreated();
        
            var room = new Room(8, 4, false, 9);
            _db.Room.Add(room);
            var ct = new CleaningTask("Bette reinigen", "Bearbeitung", 7);
            _db.CleaningTask.Add(ct);
        
            var employee = new Employee("Todl", "Maier", "Director");
            _db.Employee.Add(employee);
            _db.SaveChanges();
        }
            
           
        
    }
    
    
    // das noch
    
    [Fact]
    public void AddCleaningTaskSuccessTt()
    {
        Assert.True(_db.Room.ToList().Count == 1);
        
    }
    
    
    [Fact]
    public void RemoveCleaningTaskSuccessTt()
    {
        var  ct = _db.CleaningTask.First();
        var room = _db.Room.First();
        room.RemoveCleaningTask(ct);
        _db.SaveChanges();

        _db.ChangeTracker.Clear();

        room = _db.Room.First();
        Assert.Equal(0, room.CleaningTaskQuantity());
    }
    
    [Fact]
    public void CleaningTaskQuantitySuccessTt()
    {
        Assert.True(_db.Room.ToList().Count == 1);
        
    }

    
}