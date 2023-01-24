namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Room
{
    private int _points { get; set; }
    public int Beds { get; set; }
    public List<CleaningTask> cleaningTasks;
    public bool Issmoking { get; set; }
    public int Roomnumber{ get; set; }

    public Room(int roomnumber, int beds, bool issmoking, int points)
    {
        Roomnumber = roomnumber;
        Beds = beds;
        Issmoking = issmoking;
        Points = points;
    }

    public int Points
    {
        get => _points;
        set
        {
            if (value >= 0 && value <= 10) _points = value;
        }
    }
    

    public void AddCleaningTask(CleaningTask task)
    {
        cleaningTasks.Add(task);
    }
    public void RemoveCleaningTask(CleaningTask task)
    {
        cleaningTasks.Remove(task);
    }
    
}