using Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

namespace Reinigungsverwaltung.Model;

public class Guest
{
    public Guest(string firstname, string lastname, string address, DateTime birthday)
    {
        Firstname = firstname;
        Lastname = lastname;
        Address = address;
        Birthday = birthday;
        
    }
    
#pragma warning disable CS8618
    protected Guest()
    {
        
    }
#pragma warning restore CS8618

    public int Id { get; private set; }
    
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    
    public string Address { get; set; }
    
    
    public DateTime Birthday { get; set; }


    public string NameandInfos()
    {
        return Firstname + " " + Lastname + " " + Address ;
    }
}