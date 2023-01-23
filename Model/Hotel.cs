namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Hotel
{
    public Hotel(string n, string a)
    {
        Guid = new Guid();
        Name = n;
        Address = a;
    }

    public int Id { get; private set; }
    public Guid Guid { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Room> Rooms { get; set; }

    public void AddRoom(Room r)
    {
        Rooms.Add(r);
    }

    public void RemoveRoom(Room r)
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
}