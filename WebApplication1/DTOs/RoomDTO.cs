using System.ComponentModel.DataAnnotations;

namespace WebApplication1;

public class RoomDTO
{
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
        name = room.name;
        buildingCode = room.buildingCode;
        floor = room.floor;
        capacity = room.capacity;
        hasProjector = room.hasProjector;
        isActive = room.isActive;
    }

    public RoomDTO(string name, int buildingCode, int floor, int capacity, bool hasProjector, bool isActive)
    {
        this.name = name;
        this.buildingCode = buildingCode;
        this.floor = floor;
        this.capacity = capacity;
        this.hasProjector = hasProjector;
        this.isActive = isActive;
    }

    public static Room toRoom(RoomDTO roomDTO)
    {
        return new Room(roomDTO.name, roomDTO.buildingCode, roomDTO.floor, roomDTO.capacity, roomDTO.hasProjector, roomDTO.isActive);
    }


    public RoomDTO()
    {
        
    }
}