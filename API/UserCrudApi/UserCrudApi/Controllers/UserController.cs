using AutoMapper;
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

    private IMapper _mapper;

    public UserController(UserCrudContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    [Route("{id")]
    public IActionResult GetById(int id)
    {
        var user = _context.Users.FirstOrDefault(u => u.Id == id);

        if (user == null) return NotFound(new
        {
            Moment = new DateTime().Year,
            message = $"Cannot find user with this id = {id}."
        });


        var userProfile = _mapper.Map<UserProfileDto>(user);
        return Ok(userProfile);

    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _context
            .Users
            .Where(user => user.IsActive)
            .Select(user => 
                    _mapper.Map<UserProfileDto>(user)
            )
            .ToList();

        /*   
            Select com conversão manual DTO:
        
            .Select(user => new UserProfileDto
            {
                Email = user.Email,
                Username= user.Username,
            })
         
        */

        if (users.Count== 0) return NotFound( new
        {   Moment = new DateTime().Year,
            message = "The user list is empty"
        });
        
        return Ok(users);
    }

    [HttpPost]
    public IActionResult RegisterUser([FromBody] UserRegisterDto userRegisterDto)
    {
        var user = _mapper.Map<User>(userRegisterDto);
        var userProfile = _mapper.Map<UserProfileDto>(user);

        /*   
            Register com conversão manual DTO:
        
            var user = new User
        {
            Username = userRegisterDto.Username,
            Password = userRegisterDto.Password,
            Email = userRegisterDto.Email,
            IsActive = true
        };
         
        */

        _context.Users.Add(user);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetById), new { Id = user.Id}, userProfile);
    }

}
