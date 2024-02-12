using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Entities;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]    // This is the route for the controller /api/users
public class userController : ControllerBase
{
    private readonly DataContext _context;

    public userController(DataContext context)
    {
        _context = context;
    }
   
    [HttpGet] // /api/users
    public  async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await  _context.Users.ToListAsync();

        return users;
    }

    [HttpGet("{id}")] // /api/users/2
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        return await _context.Users.FindAsync(id);
    }


}
