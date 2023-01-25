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
            room.AddCleaningTask(ct);
        
            var employee = new Employee("Todl", "Maier", "Director");
            _db.Employee.Add(employee);
            _db.SaveChanges();
        }
            
           
        
    }
    
    
    // das noch
    
    [Fact]
    public void AddCleaningTaskSuccessTt()
    {
        Assert.True(_db.CleaningTask.ToList().Count == 1);
    }
    
    
    [Fact]
    public void RemoveCleaningTaskSuccessTt()
    {
        var  ct = _db.CleaningTask.First();
        var room1 = _db.Room.First();
        room1.RemoveCleaningTask(ct);
        _db.SaveChanges();

        _db.ChangeTracker.Clear();

        room1 = _db.Room.First();
        Assert.Equal(0, room1.CleaningTaskQuantity());
    }
    
    

    
}