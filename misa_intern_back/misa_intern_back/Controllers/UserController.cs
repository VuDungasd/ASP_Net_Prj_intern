using Microsoft.AspNetCore.Mvc;
using misa_intern_back.Data;
using misa_intern_back.Models;

namespace misa_intern_back.Controllers;

[Route("api/user")]
[ApiController]

public class UserController : ControllerBase
{
    private readonly AppDbContext _appDbContext;
    
    public UserController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _appDbContext.Users.ToList();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var user = _appDbContext.Users.Find(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] User user)
    {
        _appDbContext.Users.Add(user);
        _appDbContext.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
    }
    
}