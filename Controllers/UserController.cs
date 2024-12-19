using keep_track_be.Models;
using keep_track_be.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace keep_track_be.Controllers;

[ApiController]
[Route("[controller]/user")]
public class UserController(ILogger<UserController> logger, UserService userService)
{

    [HttpGet("{id:long}")]
    public async Task<ActionResult<User>> GetUserByIdAsync(long id)
    {
        // TODO: Need to implement this
        // var user = await userService.GetUserByIdAsync(id);
        //
        // if (user == null)
        // {
        //     return NotFound(new { Message = $"User with ID {id} was not found." });
        // }
        //
        // logger.LogInformation("Get user by id: {id}", id);
        // return Ok(user);
        return null;
    }
}