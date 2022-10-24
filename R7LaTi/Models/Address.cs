using System.ComponentModel.DataAnnotations;

namespace R7LaTi.Models;

public class Address
{
    public int Id { get; set; }
    [Required , Display(Name ="Street Number")]
    public string Street_Number { get; set; }
    [Required, Display(Name = "Street Name")]
    
    public string Street_Name{ get; set; }
    [Required, Display(Name = "City")]

    public string City { get; set; }
    [Required]
    public int CountryId { get; set; }

    //Navigations Properties
    public virtual Country  Country { get; set; }
    public List<UserAddress> UsersAddresses { get; set; }

}
