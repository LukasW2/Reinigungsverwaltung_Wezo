namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class WeeklyCleaningTask
{
    public Zeitstempel Zeitstempel { get; set; }
    public int Week { get; set; }
    public int Year { get; set; }
}