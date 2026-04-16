using WebApplication1.Repositories;

namespace WebApplication1.Services;

public class RoomService : IRoomService
{
    private static RoomRepository _roomRepository = new RoomRepository();

    public void AddRoom(Room room)
    {
        _roomRepository.add(room);
    }

    public List<Room> getRooms()
    {
        return _roomRepository.getRooms();
    }

    public Room getRoomById(int id)
    {
        return _roomRepository.findById(id);
    }
    
    public List<Room> fromBuilding(int buildingCode)
    {
        return _roomRepository.getRooms().Where(room => room.buildingCode == buildingCode).ToList();
    }
}