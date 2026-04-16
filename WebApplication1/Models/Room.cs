namespace WebApplication1;

public class Room
{
    private static int nextId = 1;
    public int id { get; set; }
    public string name { get; set; }
    public int buildingCode { get; set; }
    public int floor { get; set; }
    public int capacity { get; set; }
    public bool hasProjector { get; set; }
    public bool isActive { get; set; }

    public Room(string name, int buildingCode, int floor, int capacity, bool hasProjector, bool isActive)
    {
        this.id = nextId++;
        this.name = name;
        this.buildingCode = buildingCode;
        this.floor = floor;
        this.capacity = capacity;
        this.hasProjector = hasProjector;
        this.isActive = isActive;
    }
}