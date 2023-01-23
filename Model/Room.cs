namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Room
{
    private int _points { get; set; }
    public int Beds { get; set; }
    public List<CleaningTask> cleaningTasks;
    public bool IsSmoking { get; set; }
    public int RoomNumber{ get; set; }

    public Room(int roomnumber, int beds, bool smoking, int points)
    {
        RoomNumber = roomnumber;
        Beds = beds;
        IsSmoking = smoking;
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
}