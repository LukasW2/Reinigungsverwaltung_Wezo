using Microsoft.EntityFrameworkCore;
using Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model.Reinigungsverwaltung.Infrastructure;

public class ReinigungsverwaltungContext: DbContext
{
    public ReinigungsverwaltungContext(DbContextOptions opt) : base(opt) { }
    
    //       Name der Klasse    Name in der DB
    // public DbSet<CustomService> CustomServices => Set<CustomService>();
    public DbSet<CleaningTask> CleaningTask => Set<CleaningTask>();
    public DbSet<Employee> Employee => Set<Employee>();
    public DbSet<Guest> Guest => Set<Guest>();
    public DbSet<Hotel> Hotel => Set<Hotel>();
    public DbSet<Products> Products => Set<Products>();
    public DbSet<Room> Room => Set<Room>();
    public DbSet<Reservation> Reservation => Set<Reservation>();
    public DbSet<Zeitstempel> Zeitstempel => Set<Zeitstempel>();
    public DbSet<WeeklyCleaningTask>  WeeklyCleaningTask => Set< WeeklyCleaningTask>();
    public DbSet<DailyCleaningTask>  DailyCleaningTask => Set< DailyCleaningTask>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<DailyCleaningTask>().OwnsOne(d => d.Zeitstempel);
       modelBuilder.Entity<WeeklyCleaningTask>().OwnsOne(w => w.Zeitstempel);
       
       modelBuilder.Entity<Hotel>().HasAlternateKey(m => m.Guid);
       modelBuilder.Entity<Hotel>().Property(m => m.Guid).ValueGeneratedOnAdd();

    }
}