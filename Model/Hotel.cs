namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Hotel
{
    public Hotel(string name, string address)
    {
        Guid = new Guid();
        Name = name;
        Address = address;
    }

    public int Id { get; private set; }
    public Guid Guid { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public static List<Room> Rooms { get; set; }
    public List<Reservation> _reserv = new();

    public void AddRoom(Room r)
    {
        Rooms.Add(r);
    }

    public static void RemoveRoom(Room r)
    {
        Rooms.Remove(r);
    }

    public int RoomQuantity()
    {
        return Rooms.Count;
    }
    
    public int calculateAveragePoints()
    {
        return Rooms.Sum(r => r.Points) / Rooms.Count;
    }
    
    public void AddReservation(DateTime checkInDate, DateTime checkOutDate)
    {
        var newReserv = new Reservation(checkInDate, checkOutDate);
        _reserv.Add(newReserv);
    }

    public void RemoveReservation(Reservation reser)
    {
        _reserv.Remove(reser);
    }
}