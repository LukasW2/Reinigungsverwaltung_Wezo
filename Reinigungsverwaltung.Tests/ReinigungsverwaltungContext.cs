using Xunit;
using Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model.Reinigungsverwaltung.Tests;

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


        var Employee1 = new Employee(1, "Max Müller", "Manager");
        var Employee2 = new Employee(2, "Todl Maier", "Director");
        var Employee3 = new Employee(3, "Gunther Fischer", "Team Leader");
        
        _db.Employee.Add(Employee1);
        _db.Employee.Add(Employee2);
        _db.Employee.Add(Employee3);

        
        var Guest1 = new Guest(1, "Andrew Paler", "Berggasse 12", new DateTime(1989 - 03 - 12),
            new Reservation(1, new Room(12, 2, true, 8), DateTime.Today, new DateTime(2023 - 02 - 01)));
        var Guest2 = new Guest(2, "Tom Duwal", "Parkstrasse 6", new DateTime(1997-11-01),
            new Reservation(2, new Room(8, 4, false, 9), DateTime.Today, new DateTime(2023-02-16)));

        _db.Guest.Add(Guest1);
        _db.Guest.Add(Guest2);


        var Hotel1 = new Hotel("Pariser", "Pulkergasse 18");
        var Hotel2 = new Hotel("Terener", "Poltergasse 2");
        var Hotel3 = new Hotel("Kulka", "Sloncegasse 7");

        _db.Hotel.Add(Hotel1);
        _db.Hotel.Add(Hotel2);
        _db.Hotel.Add(Hotel3);


        var Products1 = new Products(1, "Bodenreiniger", "Entfernt Flecken", new DateTime(2023 - 09 - 10));
        var Products2 = new Products(2, "Fensterreiniger", "Macht das Fenster sauber", new DateTime(2023 - 11 - 31));
        var Products3 = new Products(3, "Luftreiniger", "Erfrischt die Luft", new DateTime(2023 - 04 - 23));

        _db.Products.Add(Products1);
        _db.Products.Add(Products2);
        _db.Products.Add(Products3);


        var Cleaningtask1 = new CleaningTask(1, "Bette reinigen", "Bearbeitung", 7,
                            new Products(4, "Allzweckreiniger", "Entfernt Fett und Schmutz", new DateTime(2023 - 11 - 29)));
        var Cleaningtask2 = new CleaningTask(2, "Boden waschen", "Bearbeitung", 5,
            new Products(4, "Allzweckreiniger Bodenreiniger", "Ist für den Boden geignet", new DateTime(2024 - 04 - 17)));
        
        _db.CleaningTask.Add(Cleaningtask1);
        _db.CleaningTask.Add(Cleaningtask2);

        
        
        _db.SaveChanges();
        
        
        _db.ChangeTracker.Clear();
        Assert.True(_db.Employee.ToList().Count > 0);
        Assert.True(_db.Guest.ToList().Count > 0);
        Assert.True(_db.Hotel.ToList().Count > 0);
        Assert.True(_db.Products.ToList().Count > 0);
        Assert.True(_db.CleaningTask.ToList().Count > 0);
        
    }
    
    
}