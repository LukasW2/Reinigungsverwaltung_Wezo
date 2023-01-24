namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class DailyCleaningTask
{
    public Zeitstempel Zeitstempel { get; set; }
    public int Priority { get; set; }
    
    public DailyCleaningTask(int priority)
    {
        Priority = priority;
        
    }
    
}