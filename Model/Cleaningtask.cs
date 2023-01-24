namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class CleaningTask
{
    protected static List<Employee> _employees = new();
    public List<Products> _products = new List<Products>();
    public Zeitstempel Zeitstempel { get; set; }

    public CleaningTask(string description, string status, int points)
    {
        this.description = description;
        this.status = status;
        this.points = points;
    }

    public int taskId { get; private set; }
    public string description { get; set; }
    public string status { get; set; }
    public int points { get; set; }

    public void RemoveProduct(Products p) 
    {
        _products.Remove(p);
    }
    public int ProductQuantity()
    {
        return _products.Count;
    }
    
    public void AddEmployee(string firstname, string lastname, string position)
    {
        var newEmployee = new Employee(firstname, lastname, position);
        _employees.Add(newEmployee);
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