namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Reservation
{
    public int reservationId { get; set; }
    public DateTime checkInDate { get; set; }
    public DateTime checkOutDate { get; set; }
    public virtual Guest guest { get; set; }
    public virtual Room room { get; set; }

    public Reservation(DateTime checkInDate, DateTime checkOutDate)
    {
        this.checkInDate = checkInDate;
        this.checkOutDate = checkOutDate;
       
    }

    
}