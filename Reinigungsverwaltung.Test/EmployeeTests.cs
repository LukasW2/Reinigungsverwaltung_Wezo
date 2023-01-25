using Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Reinigungsverwaltung.Test;

public class EmployeeTests : DatabaseTest

{
    public EmployeeTests()
    {
        _db.Database.EnsureCreated();
        
        var Employee = new Employee("Todl", "Maier", "Director");
        _db.Employee.Add(Employee);
        _db.SaveChanges();
    }
    
    [Fact]
    public void NameAndInfosSuccessTest()
    {
        Assert.Equal("Todl Maier Director",_db.Employee.First().NameandInfos());
    }
    
    
}