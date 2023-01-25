using Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;
using Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Reinigungsverwaltung.Test;

public class CleaningtaskTests : DatabaseTest
{
    public CleaningtaskTests()
    {
        _db.Database.EnsureCreated();
        
         var ct = new CleaningTask("Bette reinigen", "Bearbeitung", 7);
         _db.CleaningTask.Add(ct);
         var products = new Products("Bodenreiniger", "Entfernt Flecken", new DateTime(2023 - 09 - 10));
        ct.AddProducts(products);
        
        var employee = new Employee("Todl", "Maier", "Director");
        _db.Employee.Add(employee);
        _db.SaveChanges();
    }


    [Fact]

    public void AddProductsSuccessTt()
    {
        Assert.True(_db.Products.ToList().Count == 1);
    }
    
    
   
  
    [Fact]
    public void AddEmployeeSuccessTt()
    {
    
       Assert.True(_db.Employee.ToList().Count == 1);
        
    }
    
    
    
    [Fact]
     public void RemoveEmployeeSuccessTest()
            {
                var ct  = _db.CleaningTask.First();
                var employee = _db.Employee.First();
                ct.RemoveEmployee(employee);
                _db.SaveChanges();
    
                _db.ChangeTracker.Clear();
    
                ct = _db.CleaningTask.First();
                Assert.Equal(0, ct.EmployeeQuantity());
            }
    
  
    
    [Fact]
         public void RemoveProductSuccessTest()
                {
                    var ct  = _db.CleaningTask.First();
                     var product = _db.Products.First();
                     ct.RemoveProduct(product);
                    _db.SaveChanges();
                        
                     _db.ChangeTracker.Clear();
                        
                     ct = _db.CleaningTask.First();
                    Assert.Equal(0, ct.ProductQuantity());
                }
                
             
                
     [Fact]
             public void ProductQuantitySuccessTt()
             {
                 Assert.True(_db.CleaningTask.First().ProductQuantity() == 1);
             }
             
             
             // das noch
      [Fact]
           public void EmployeeQuantitySuccessTt()
           {
                  Assert.Equal(1, _db.CleaningTask.First().EmployeeQuantity());
           }

}
