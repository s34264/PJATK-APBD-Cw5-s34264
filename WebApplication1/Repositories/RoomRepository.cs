namespace WebApplication1.Repositories;

public class RoomRepository
{
    private List<Room> rooms = new();

    public RoomRepository()
    {
        add(new Room("A1", 1, 1, 10, false, false));
        add(new Room( "A2", 1, 1, 20, false, true));
        add(new Room( "B1", 2, 1, 30, true, true));
        add(new Room( "B2", 2, 1, 40, true, true));
        add(new Room( "C1", 3, 1, 50, true, true));
        add(new Room( "C2", 3, 1, 60, true, true));
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

    public void delete(int id)
    {
        rooms.Remove(findById(id));
    }
    
    
}