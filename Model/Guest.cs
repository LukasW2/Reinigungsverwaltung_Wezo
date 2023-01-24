namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Guest
{
    public Guest(string firstname, string lastname, string address, DateTime birthday)
    {
        Firstname = firstname;
        Lastname = lastname;
        Address = address;
        Birthday = birthday;
    }

    public int GuestId { get; set; }
    
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    
    public string Address { get; set; }
    public virtual Reservation Reservation { get; set; }
    
    public DateTime Birthday { get; set; }


    public string? ToString()
    {
        return base.ToString();
    }
}