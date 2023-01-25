using Microsoft.EntityFrameworkCore;
using Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;


public class DailyCleaningTask : CleaningTask
{
    public virtual Zeitstempel Zeitstempel { get; set; }
    public int Priority { get; set; }
    
    public int Id { get; private set; }
    public bool reviewHandIn { get; set; }
    
    public DailyCleaningTask(int priority)
    {
        Priority = priority;

    }
    
    
}