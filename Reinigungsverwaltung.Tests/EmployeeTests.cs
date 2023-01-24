using Xunit;

namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model.Reinigungsverwaltung.Tests;

[Collection("Sequential")]
public class EmployeeTests : DatabaseTest
{
    
    
    public EmployeeTests()
    {
        _db.Database.EnsureCreated();
        var employee = new Employee(1, "Max Müller", "Manager");
            _db.Employee.Add(employee);
            var cleaning = new CleaningTask( 1, "Boden muss gereinigt werden", "Bearbeitung", 4 ,
                new Products(1, "Bodenreiniger" , "Entfernt Flecken auf dem Boden",new DateTime(2023-02-10) ));
            
        
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
        var employee = _db.Employee.First();
        var cleaningtask = _db.CleaningTask.First();
        employee.RemoveEmployee(employee);
        _db.SaveChanges();

        _db.ChangeTracker.Clear();

        employee = _db.Employee.First();
        Assert.True(employee.ActiveTasks.Count == 0);
    }

    
    [Fact]
    public void EmployeeQuantitySuccessTt()
    {
        Assert.True(_db.Employee.First().EmployeeQuantity() == 1);
    }
    
}