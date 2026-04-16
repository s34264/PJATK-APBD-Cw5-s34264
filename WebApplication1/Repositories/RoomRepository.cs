namespace WebApplication1.Repositories;

public class RoomRepository
{
    private List<Room> rooms = new();

    public RoomRepository()
    {
        add(new Room("A1", 1, 1, 10, false, true));
        add(new Room( "A2", 1, 1, 10, true, true));
    }

    public void add(Room room)
    {
        rooms.Add(room);
    }
    
    public Room findById(int id)
    {
        foreach (var room in rooms)
        {
            if (room.id == id) return room;
        }
        return null;
    }

    public List<Room> getRooms()
    {
        return rooms;
    }
}