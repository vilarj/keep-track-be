using keep_track_be.Context;
using keep_track_be.Models;

namespace keep_track_be.Services;

public class UserService(ILogger<UserService> logger, KeepTrackContext context)
{
    
    public async Task<User> GetUserByIdAsync(long id)
    {
        logger.LogInformation($"Getting user by id: {id}");
        return await context.Users.FindAsync(id);
    }
}