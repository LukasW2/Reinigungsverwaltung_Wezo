using Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;
using Reinigungsverwaltung.Model;
using Reinigungsverwaltung.Reinigungsverwaltung.Test;

namespace Reinigungsverwaltung.Reinigungsverwaltung.Tests;

public class ReinigungsverwaltungContextTests : DatabaseTest
{
    [Fact]
    public void CreateDatabaseTest()
    {
        _db.Database.EnsureCreated();
    }

    public void SeedDatabase()
    {
        _db.Database.EnsureDeleted();
        _db.Database.EnsureCreated();


        var Employee1 = new Employee("Max", "Müller", "Manager");
        var Employee2 = new Employee("Todl", "Maier", "Director");
        var Employee3 = new Employee("Gunther", "Fischer", "Team Leader");
        
        _db.Employee.Add(Employee1);
        _db.Employee.Add(Employee2);
        _db.Employee.Add(Employee3);

        
        var Guest1 = new Guest("Andrew", "Paler", "Berggasse 12",new DateTime(1989 - 03 - 12));
        var Guest2 = new Guest("Tom", "Duwal","Parkstrasse 6", new DateTime(1997-11-01));

        _db.Guest.Add(Guest1);
        _db.Guest.Add(Guest2);


        var Hotel1 = new Hotel("Pariser", "Pulkergasse 18" );
        var Hotel2 = new Hotel("Terener", "Poltergasse 2");
        var Hotel3 = new Hotel("Kulka", "Sloncegasse 7");

        _db.Hotel.Add(Hotel1);
        _db.Hotel.Add(Hotel2);
        _db.Hotel.Add(Hotel3);

        var Reserv1 = new Reservation(DateTime.Today, new DateTime(2023 - 02 - 01));
        var Reserv2 = new Reservation(DateTime.Today, new DateTime(2023 - 02 - 16));

        _db.Reservation.Add(Reserv1);
        _db.Reservation.Add(Reserv2);

        var Products1 = new Products("Bodenreiniger", "Entfernt Flecken", new DateTime(2023 - 09 - 10));
        var Products2 = new Products("Fensterreiniger", "Macht das Fenster sauber", new DateTime(2023 - 11 - 31));
        var Products3 = new Products("Luftreiniger", "Erfrischt die Luft", new DateTime(2023 - 04 - 23));

        _db.Products.Add(Products1);
        _db.Products.Add(Products2);
        _db.Products.Add(Products3);

        var Room1 = new Room(12, 2, true, 8);
        var Room2 = new Room(8, 4, false, 9);
        
        _db.Room.Add(Room1);
        _db.Room.Add(Room2);

        var Cleaningtask1 = new CleaningTask("Bette reinigen", "Bearbeitung", 7);
        var Cleaningtask2 = new CleaningTask("Boden waschen", "Bearbeitung", 5
            );
        
        _db.CleaningTask.Add(Cleaningtask1);
        _db.CleaningTask.Add(Cleaningtask2);

        var WeeklyCleaningTask1 = new WeeklyCleaningTask("Monday", 12, 2023);
        var WeeklyCleaningTask2 = new WeeklyCleaningTask("Thursday", 26, 2023);
        _db.WeeklyCleaningTask.Add(WeeklyCleaningTask1);
        _db.WeeklyCleaningTask.Add(WeeklyCleaningTask2);
        
        var DailyCleaningTask1 = new DailyCleaningTask(1);
        var DailyCleaningTask2 = new DailyCleaningTask(3);
        _db.DailyCleaningTask.Add(DailyCleaningTask1);
        _db.DailyCleaningTask.Add(DailyCleaningTask2);
        
        
        _db.SaveChanges();
        
        
        _db.ChangeTracker.Clear();
        Assert.True(_db.Employee.ToList().Count > 0);
        Assert.True(_db.Guest.ToList().Count > 0);
        Assert.True(_db.Hotel.ToList().Count > 0);
        Assert.True(_db.Reservation.ToList().Count > 0);
        Assert.True(_db.Products.ToList().Count > 0);
        Assert.True(_db.Room.ToList().Count > 0);
        Assert.True(_db.CleaningTask.ToList().Count > 0);
        Assert.True(_db.WeeklyCleaningTask.ToList().Count > 0);
        Assert.True(_db.DailyCleaningTask.ToList().Count > 0);
    }
    
    
}