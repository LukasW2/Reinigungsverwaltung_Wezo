namespace Reinigungsverwaltung.Model;

public class WeeklyCleaningTask
{
    public int Id { get; private set; }
    public virtual Zeitstempel Zeitstempel { get; set; }
    public string PreferredDay { get; set; }
    public int Week { get; set; }
    public int Year { get; set; }
    public bool reviewHandIn { get; set; }

    public WeeklyCleaningTask(string preferredDay, int week, int year)
    {
        PreferredDay = preferredDay;
        Week = week;
        Year = year;
    }
}