using keep_track_be.Models;
using keep_track_be.Services;
using Microsoft.AspNetCore.Mvc;

namespace keep_track_be.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(ILogger<UserController> logger, UserService userService) : ControllerBase
{

    [HttpGet("{id:long}")]
    public async Task<ActionResult<User>> GetUserByIdAsync(long id)
    {
        logger.LogInformation("Fetching user by ID: {id}", id);

        var user = await userService.GetUserByIdAsync(id);

        if (user == null)
        {
            logger.LogWarning("User with ID: {id} not found.", id);
            return NotFound(new { Message = $"User with ID {id} not found." });
        }

        return Ok(user);
    }
}