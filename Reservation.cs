namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Reservation
{
    public List<Reservation> _reserv = new();
    public int reservationId { get; set; }
    public DateTime checkInDate { get; set; }
    public DateTime checkOutDate { get; set; }
    public Guest guest { get; set; }
    public Room room { get; set; }

    public Reservation(int reservationId, Room room, DateTime checkInDate, DateTime checkOutDate, Guest guest)
    {
        this.reservationId = reservationId;
        this.room = room;
        this.checkInDate = checkInDate;
        this.checkOutDate = checkOutDate;
        this.guest = guest;
    }

    public void AddReservation(Reservation reservation)
    {
        var newReserv = new Reservation(reservationId, room, checkInDate, checkOutDate, guest);
        _reserv.Add(newReserv);
    }

    public void RemoveReservation(Reservation reservation)
    {
        _reserv.Remove(this);
    }
}