using System.ComponentModel.DataAnnotations;

namespace R7LaTi.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required ,StringLength(35)]
        public string FirstName { get; set; }

        [Required ,StringLength(35)]
        public string LastName { get; set; }
        public string FullName { get; set; }


        [Required , DataType(DataType.EmailAddress)]
        public string Email {get; set;}

        [Required , DataType(DataType.Password)]
        public string Password {get ; set;}
        [Required]
        public short Age { get; set; }


        //Navigations Properties
        public virtual List<CustomersTrips> CustomersTrips {get; set;}

    }
}
