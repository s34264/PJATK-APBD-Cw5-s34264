using WebApplication1.Repositories;

namespace WebApplication1.Services;

public class ReservationService : IReservationService
{
    private static ReservationRepository _reservationRepository = new ReservationRepository();
    
    public void AddReservation(Reservation reservation)
    {
        _reservationRepository.add(reservation);
    }

    public List<Reservation> getReservations()
    {
        return _reservationRepository.getReservations();
    }

    public Reservation getReservationById(int id)
    {
        return _reservationRepository.findById(id);
    }
}