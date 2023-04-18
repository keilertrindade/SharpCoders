using Microsoft.AspNetCore.Mvc;
using UserCrudApi.Domain;
using UserCrudApi.Domain.Dto;
using UserCrudApi.Domain.Model;

namespace UserCrudApi.Controllers;

[ApiController]
[Route("/users")]
public class UserController : ControllerBase
{
    private UserCrudContext _context;

    public UserController(UserCrudContext context)
    {
        _context = context;
    }


    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _context
            .Users
            .Where(user => user.IsActive)
            .Select(user => new UserProfileDto
            {
                Email = user.Email,
                Username= user.Username,
            })
            .ToList();
        
        if(users.Count== 0) return NotFound( new
        {   Moment = new DateTime().Year,
            message = "The user list is empty"
        });
        
        return Ok(users);
    }

    [HttpPost]
    public IActionResult RegisterUser([FromBody] UserRegisterDto userRegisterDto)
    {
        var userToRegister = new User
        {
            Username = userRegisterDto.Username,
            Password = userRegisterDto.Password,
            Email = userRegisterDto.Email,
            IsActive = true
        };

        _context.Users.Add(userToRegister);
        _context.SaveChanges();

        return Ok(userToRegister);
    }

}
