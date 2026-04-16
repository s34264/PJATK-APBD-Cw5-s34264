namespace WebApplication1.Services;

public interface IRoomService
{
    public void AddRoom(Room room);
    public List<Room> getRooms();
    public Room getRoomById(int id);
    public List<Room> fromBuilding(int buildingCode);
}