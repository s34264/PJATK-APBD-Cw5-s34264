using Microsoft.AspNetCore.Mvc;
namespace WebApplication1;

[ApiController]
[Route("api/[controller]")]
public class RoomsController : ControllerBase
{
    private static List<Room> rooms = new();
    
    
    [HttpGet]
    public ActionResult<IEnumerable<RoomDTO>> GetAll()
    {
        var books = new List<RoomDTO>
        {
            new BookDto { Id = 1, Title = "Clean Code", Author = "Robert C. Martin" },
            new BookDto { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt" }
        };

        return Ok(books);
    }
}