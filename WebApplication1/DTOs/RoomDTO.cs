using System.ComponentModel.DataAnnotations;

namespace WebApplication1;

public class RoomDTO
{
    public int id { get; set; }
    [Required]
    public string name { get; set; }
    [Required]
    public int buildingCode { get; set; }
    [Required]
    [Range(1, 3)]
    public int floor { get; set; }
    public int capacity { get; set; }
    public bool hasProjector { get; set; }
    public bool isActive { get; set; }


    public RoomDTO(Room room)
    {
        id = room.id;
        name = room.name;
        buildingCode = room.buildingCode;
        floor = room.floor;
        capacity = room.capacity;
        hasProjector = room.hasProjector;
        isActive = room.isActive;
    }

    public static Room toRoom(RoomDTO roomDTO)
    {
        return new Room(roomDTO.name, roomDTO.buildingCode, roomDTO.floor, roomDTO.capacity, roomDTO.hasProjector, roomDTO.isActive);
    }
}