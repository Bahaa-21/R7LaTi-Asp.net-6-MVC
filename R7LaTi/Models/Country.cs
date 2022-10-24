
using System.ComponentModel.DataAnnotations;

namespace R7LaTi.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required , Display(Name ="Country Name")]
        public string Country_Name { get; set; }

        public virtual List<Address> Addresses { get; set; } 
    }
}
