namespace WebApplication1.Repositories;

public class ReservationRepository
{
    private static List<Reservation> reservations = new List<Reservation>();

    public ReservationRepository()
    {
        reservations.Add(new Reservation(1, "Adam Kowalski", "Lekcja APBD", 
            new DateTime(2026, 2, 10), 
            new DateTime(2026, 2,10), 
            new DateTime(2026, 2, 10),
            "confirmed"));
        
        reservations.Add(new Reservation(1, "Marcin Kowalski", "Lekcja SKJ", 
            new DateTime(2026, 2, 10), 
            new DateTime(2026, 2,10), 
            new DateTime(2026, 2, 10),
            "confirmed"));
        
        reservations.Add(new Reservation(1, "Tomek Kowalski", "Lekcja ASD", 
            new DateTime(2026, 2, 10), 
            new DateTime(2026, 2,10), 
            new DateTime(2026, 2, 10),
            "confirmed"));
    }

    public void add(Reservation reservation)
    {
       reservations.Add(reservation);
    }

    public List<Reservation> getReservations()
    {
        return reservations;
    }

    public Reservation findById(int id)
    {
        return reservations.FirstOrDefault(reservation => reservation.id == id);
    }
}