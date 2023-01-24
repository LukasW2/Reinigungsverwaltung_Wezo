namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Employee
{
    protected List<CleaningTask> _activeTasks = new();

    public Employee(string firstname, string lastname, string position)
    {
        Firstname = firstname;
        Lastname = lastname;
        Position = position;
        
    }


#pragma warning disable CS8618
    protected Employee()
    {
        
    }
#pragma warning restore CS8618
    public int EmployeeId { get; private set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Position { get; }
    public DateTime Birthday { get; set; }
    public virtual List<CleaningTask> ActiveTasks => _activeTasks;


    public List<CleaningTask> GetActiveTasks()
    {
        return _activeTasks;
    }

    public int CleaningTasksQuantity()
    {
        return _activeTasks.Count;
    }
    
    
}