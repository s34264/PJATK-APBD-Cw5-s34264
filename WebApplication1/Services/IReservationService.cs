namespace WebApplication1.Services;

public interface IReservationService
{
    public void AddReservation(Reservation room);
    public List<Reservation> getReservations();
    public Reservation getReservationById(int id);
   
}