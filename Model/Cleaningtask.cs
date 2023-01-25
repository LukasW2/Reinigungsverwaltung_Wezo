using Microsoft.EntityFrameworkCore;
using Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Model;


public class CleaningTask
{
    public List<Employee> _employees = new List<Employee>();
    protected List<Products> _products = new List<Products>();
    
    public virtual IReadOnlyCollection<Products> Products => _products; 

    public int Id { get; set; }  
    public int taskId { get; set; }
    public string description { get; set; }
    public string status { get; set; }
    public int points { get; set; }

    public CleaningTask(string description, string status, int points)
    {
        this.description = description;
        this.status = status;
        this.points = points;
    }
#pragma warning disable CS8618
    protected CleaningTask()
    {
        
    }
#pragma warning disable CS8618

    public void AddProducts(Products products)
    {
        
        _products.Add(products);
    }
    public void RemoveProduct(Products p) 
    {
        _products.Remove(p);
    }
    public int ProductQuantity()
    {
        return _products.Count;
    }
    
    
    public void AddEmployee(Employee employee)
    {
        
        _employees.Add(employee);
    }

    public void RemoveEmployee(Employee emp)
    {
        _employees.Remove(emp);
    }

    public int EmployeeQuantity()
    {
        return _employees.Count;
    }
    
}