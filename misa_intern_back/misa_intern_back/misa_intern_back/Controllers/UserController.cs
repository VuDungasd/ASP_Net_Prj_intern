using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using misa_intern_back.Data;
using misa_intern_back.Models;

namespace misa_intern_back.Controllers;

[Route("/api/v1/CustomerGroups")]
[ApiController]

public class UserController : ControllerBase
{
    private readonly AppDbContext _appDbContext;
    
    public UserController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    // get all user
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _appDbContext.Users.ToList();
        return Ok(users);
    }
    
    // get all record number in dbs
    [HttpGet("count")]
    public async Task<ActionResult<int>> GetUserCount()
    {
        var userCount = await _appDbContext.Users.CountAsync();
        return Ok(userCount);
    }

    // get user by userID
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

    // post api to create user 
    [HttpPost]
    public async Task<ActionResult<User>> PostUser(User user)
    {
        _appDbContext.Users.Add(user);
        await _appDbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
    }
    
    // update user by userID
    [HttpPut("{id}")]
    public async Task<IActionResult> PutUser(int id, User user)
    {

        var existingUser = await _appDbContext.Users.FindAsync(id);
        if (existingUser == null)
        {
            return NotFound();
        }

        existingUser.code = user.code;
        existingUser.userName = user.userName;
        existingUser.birthday = user.birthday;
        existingUser.gender = user.gender;
        existingUser.position = user.position;
        existingUser.personalNumber = user.personalNumber;
        existingUser.create_date = user.create_date;
        existingUser.department = user.department;
        existingUser.issued_By = user.issued_By;
        existingUser.address = user.address;
        existingUser.mobilePhone = user.mobilePhone;
        existingUser.landline = user.landline;
        existingUser.email = user.email;
        existingUser.bacnkCode = user.bacnkCode;
        existingUser.bankName = user.bankName;
        existingUser.bankBranch = user.bankBranch;

        try
        {
            await _appDbContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!UserExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var user = await _appDbContext.Users.FindAsync(id);
        if (user == null)
        {
            return NotFound();
        }

        _appDbContext.Users.Remove(user);
        await _appDbContext.SaveChangesAsync();

        return NoContent();
    }

    private bool UserExists(int id)
    {
        return _appDbContext.Users.Any(e => e.Id == id);
    }
}