namespace Reinigungsverwaltung.Model;

public class Room
{
    public int Id { get; private set; }
    private int _points { get; set; }
    public int Beds { get; set; }
    public virtual List<CleaningTask> _cleaningTasks { get; set; }
    public bool Issmoking { get; set; }
    public int Roomnumber{ get; set; }
    public List<Reservation> _reserv;

    public Room(int roomnumber, int beds, bool issmoking, int points)
    {
        Roomnumber = roomnumber;
        Beds = beds;
        Issmoking = issmoking;
        Points = points;
    }
#pragma warning disable CS8618
    protected Room()
    {
        
    }
#pragma warning disable CS8618
    
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
        _cleaningTasks.Add(task);
    }
    public void RemoveCleaningTask(CleaningTask task)
    {
        _cleaningTasks.Remove(task);
    }

    public int CleaningTaskQuantity()
    {
        return _cleaningTasks.Count; 
    }
    
    
    public void AddReservation(Reservation reserv)
    {
        
        _reserv.Add(reserv);
    }

    public void RemoveReservation(Reservation reserv)
    {
        _reserv.Remove(reserv);
    }
    
    
    
}