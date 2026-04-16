namespace WebApplication1;

public class Reservation
{
    private static int nextId = 1;
    public int id { get; set; }
    public int roomId { get; set; }
    public string organizerName { get; set; }
    public string topic { get; set; }
    public DateTime date { get; set; }
    public DateTime startTime { get; set; }
    public DateTime endTime { get; set; }
    public string status { get; set; }

    public Reservation(int roomId, string organizerName, string topic, DateTime date, DateTime startTime, DateTime endTime, string status)
    {
        this.id = nextId++;
        this.roomId = roomId;
        this.organizerName = organizerName;
        this.topic = topic;
        this.date = date;
        this.startTime = startTime;
        this.endTime = endTime;
        this.status = status;
    }
}