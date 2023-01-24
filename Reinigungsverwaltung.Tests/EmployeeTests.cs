using Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Reinigungsverwaltung.Tests;

[Collection("Sequential")]
public class EmployeeTests : DatabaseTest
{
    
    
    public EmployeeTests()
    {
        _db.Database.EnsureCreated();
        var employee = new Employee("Max", "Müller", "Manager");
            _db.Employee.Add(employee);
            var cleaning = new CleaningTask("Boden muss gereinigt werden", "Bearbeitung", 4 );
            
        
        _db.SaveChanges();
    }
    
    
    
    [Fact]
    public void AddEmployeeSuccessTt()
    {
        Assert.True(_db.Employee.ToList().Count == 1);
    }
    
    [Fact]
    public void RemoveEmployeeSuccessTt()
    {
        var cleaningtask = _db.CleaningTask.First();
        var employee = _db.Employee.First();
       
        cleaningtask.RemoveEmployee(employee);
        _db.SaveChanges();

        _db.ChangeTracker.Clear();

        employee = _db.Employee.First();
        Assert.True(employee.ActiveTasks.Count == 0);
    }

    
    [Fact]
    public void EmployeeQuantitySuccessTt()
    {
        Assert.True(_db.CleaningTask.First().EmployeeQuantity() == 1);
    }
    
}