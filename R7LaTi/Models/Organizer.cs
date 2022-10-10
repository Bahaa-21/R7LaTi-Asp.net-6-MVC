using System.ComponentModel.DataAnnotations;

namespace R7LaTi.Models
{
    public class Organizer
    {
        public int Id { get; set; }
        [Required , StringLength(35)]
        public string FirstName { get; set; }

        [Required , StringLength(35)]
        public string LastName { get; set; }
        [Required , StringLength(350)]

        public string FullName { get; set; }
        public string About { get; set; }
        [Required]
        public string Location { get; set; }
        [Required , DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required , DataType(DataType.Password)]
        public string Password { get; set; }
        [Required , DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        //Navigations Properties
        public virtual List<Trip> Trips { get; set; }
    }
}
