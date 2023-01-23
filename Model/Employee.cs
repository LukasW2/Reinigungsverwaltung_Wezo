namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Employee
{
    protected List<CleaningTask> _activeTasks = new();

    protected List<Employee> _employees = new();

    public Employee(int employeeid, string name, string position)
    {
        EmployeeId = employeeid;
        Name = name;
        Position = position;
        _activeTasks = new List<CleaningTask>();
    }


#pragma warning disable CS8618
    protected Employee(string position)
    {
        Position = position;
    }
#pragma warning restore CS8618
    public int EmployeeId { get; }
    public string Name { get; }
    public string Position { get; }
    public virtual List<CleaningTask> ActiveTasks => _activeTasks;


    public List<CleaningTask> GetActiveTasks()
    {
        return _activeTasks;
    }

    public void AddEmployee(int employeeId, string name, string position)
    {
        var newEmployee = new Employee(employeeId, name, position);
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