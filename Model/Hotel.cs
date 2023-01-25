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

#pragma warning disable CS8618
    protected Hotel()
    {
        
    }
#pragma warning restore CS8618
    
    public int Id { get; private set; }
    public Guid Guid { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public virtual List<Room> _rooms { get; set; }
    

    public void AddRoom(Room r)
    {
        _rooms.Add(r);
    }

    public void RemoveRoom(Room r)
    {
        _rooms.Remove(r);
    }

    public int RoomQuantity()
    {
        return _rooms.Count;
    }
    
    public int CalculateAveragePoints()
    {
        return _rooms.Sum(r => r.Points) / _rooms.Count;
    }
    
    
}