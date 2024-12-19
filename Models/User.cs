using System.ComponentModel.DataAnnotations;

namespace keep_track_be.Models;

public class User
{
    [Required]
    private long Id { get; }
    
    [Required]
    private string RecordNumber { get; set; }
    
    [Required]
    private string FirstName { get; set; }
    
    private string? MiddleName { get; set; }
    
    [Required]
    private string LastName { get; set; }
    
    private string? Surname { get; set; }
    
    [Required]
    private string Email { get; set; }
    
    [Required]
    private string PhoneNumber { get; set; }
    
    [Required]
    private string Address { get; set; }
    
    [Required]
    private DateTime DoB { get; set; }
    
    [Required]
    private DateTime LastVisit { get; set; }
}