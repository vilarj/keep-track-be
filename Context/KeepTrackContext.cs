namespace keep_track_be.Context;

using keep_track_be.Models;
using Microsoft.EntityFrameworkCore;

public class KeepTrackContext : DbContext
{
    public KeepTrackContext(DbContextOptions<KeepTrackContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
}