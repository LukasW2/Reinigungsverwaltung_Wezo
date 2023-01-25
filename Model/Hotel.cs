using Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Model;

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
    public virtual List<Room> Rooms { get; set; }
    

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
    
    public int CalculateAveragePoints()
    {
        return Rooms.Sum(r => r.Points) / Rooms.Count;
    }
    
    
}