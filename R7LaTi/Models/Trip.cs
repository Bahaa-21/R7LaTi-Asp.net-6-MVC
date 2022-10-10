using System.ComponentModel.DataAnnotations;

namespace R7LaTi.Models
{
    public class Trip
    {
        public int Id { get; set; }
        [Required , DataType(DataType.Date)]
        public DateTime DateStart { get; set; }
        [Required , DataType(DataType.Date)]
        public DateTime DateEnd { get; set; }
        [Required , StringLength(500)]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required , StringLength(300)]
        public string StartLocation { get; set; }
        public double Rate { get; set; }
        [Required]
        public int OrganizerId { get; set; }
        
        //Navigations Properties
        public virtual Organizer Organizer {get; set;}
        
        public virtual List<CustomersTrips> CustomersTrips {get; set;}

    }
}
