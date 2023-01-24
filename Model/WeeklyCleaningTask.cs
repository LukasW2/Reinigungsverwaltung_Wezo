namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class WeeklyCleaningTask
{
    public Zeitstempel Zeitstempel { get; set; }
    public string PreferredDay { get; set; }
    public int Week { get; set; }
    public int Year { get; set; }

    public WeeklyCleaningTask(string preferredDay, int week, int year)
    {
        PreferredDay = preferredDay;
        Week = week;
        Year = year;
    }
}