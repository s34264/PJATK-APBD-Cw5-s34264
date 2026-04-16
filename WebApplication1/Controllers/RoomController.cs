using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repositories;
using WebApplication1.Services;
namespace WebApplication1;

[ApiController]
[Route("api/[controller]")]
public class RoomController : ControllerBase
{
    //private static RoomRepository _roomRepository = new RoomRepository();
    private readonly IRoomService _roomService;
    

    public RoomController(IRoomService roomService)
    {
        _roomService =  roomService;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<RoomDTO>> GetRooms(int? minCapacity, bool? hasProjector, bool? onlyActive)
    {
        List<Room> rooms = _roomService.getRooms();
        if (minCapacity != null)
        {
            rooms = rooms.Where(room => room.capacity >= minCapacity).ToList();
        }

        if (hasProjector == true)
        {
            rooms = rooms.Where(room => room.hasProjector == true).ToList();
        }

        if (onlyActive == true)
        {
            rooms = rooms.Where(room => room.isActive == true).ToList();
        }
        
        List<RoomDTO> roomDTOs = new();
        foreach (var room in rooms)
        {
            roomDTOs.Add(new RoomDTO(room));
        }

        return Ok(roomDTOs);
    }
    
    [HttpGet("{roomId}")]
    public ActionResult<IEnumerable<RoomDTO>> GetRoom(int roomId)
    {
        Room room = _roomService.getRoomById(roomId);
        if (room == null) return NotFound();
        RoomDTO roomDTO = new(room);
        
        return Ok(roomDTO);
    }
    
    [HttpGet ("building/{buildingCode}")]
    public ActionResult<IEnumerable<RoomDTO>> GetFromBuilding(int buildingCode)
    { 
        List<Room> rooms = _roomService.fromBuilding(buildingCode);
        if(rooms.Count == 0) return NotFound();

        List<RoomDTO> roomDTOs = new List<RoomDTO>();
        foreach (var room in rooms)  roomDTOs.Add(new RoomDTO(room));
        
        return Ok(roomDTOs);
    }

    [HttpPost]
    public ActionResult createRoom(RoomDTO roomDTO)
    {
        try
        {
            _roomService.AddRoom(RoomDTO.toRoom(roomDTO));
            return CreatedAtAction(roomDTO.name, roomDTO);
        }
        catch (Exception ex)
        {
            return BadRequest("Niepoprawne dane");
        }
        
    }
}