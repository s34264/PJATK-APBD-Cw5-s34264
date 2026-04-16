using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repositories;
namespace WebApplication1;

[ApiController]
[Route("api/[controller]")]
public class RoomsController : ControllerBase
{
    private static RoomRepository _roomRepository = new RoomRepository();
    
    
    [HttpGet]
    public ActionResult<IEnumerable<RoomDTO>> GetAll()
    {
        List<RoomDTO> roomDTOs = new();
        foreach (var room in _roomRepository.getRooms())
        {
            roomDTOs.Add(new RoomDTO(room));
        }

        return Ok(roomDTOs);
    }
}