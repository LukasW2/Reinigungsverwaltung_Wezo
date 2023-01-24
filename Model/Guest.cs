namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Guest
{
    public Guest(int guestId, string name, string address, DateTime birthday, Reservation reservation)
    {
        GuestId = guestId;
        Name = name;
        Address = address;
        Reservation = reservation;
        Birthday = birthday;
    }

    public int GuestId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public Reservation Reservation { get; set; }
    
    public DateTime Birthday { get; set; }


    public string? ToString()
    {
        return base.ToString();
    }
}