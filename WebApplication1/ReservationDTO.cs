namespace WebApplication1;

public class ReservationDTO
{
    public int id { get; set; }
    public int roomId { get; set; }
    public string organizerName { get; set; }
    public string topic { get; set; }
    public DateTime date { get; set; }
    public DateTime startTime { get; set; }
    public DateTime endTime { get; set; }
    public string status { get; set; }
}