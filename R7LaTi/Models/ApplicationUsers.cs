using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace R7LaTi.Models;

public class ApplicationUsers : IdentityUser
{
    [Required, MaxLength(35)]
    public string FirstName { get; set; }
    [Required, MaxLength(35)]
    public string LastName { get; set; }
    public string FullName {get; set;}
    
    //Navigation Properties
    public List<UserTrips> UsersTrips { get; set; }
    public List<UserAddress> UsersAddresses { get; set; }
    public List<Photo> Photos { get; set; }

}
