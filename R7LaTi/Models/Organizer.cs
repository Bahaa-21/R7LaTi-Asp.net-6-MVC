using System.ComponentModel.DataAnnotations;

namespace R7LaTi.Models;

public class Organizer : ApplicationUsers
{

    [Required , MaxLength(500)]
    public string About { get; set; }

    //Navigations Properties
    public  List<Trip> Trips { get; set; }
}
