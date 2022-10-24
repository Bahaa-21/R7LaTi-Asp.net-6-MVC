using System.ComponentModel.DataAnnotations;

namespace R7LaTi.ViewModel
{
    public class TripVM
    {
        public int Id { get; set; }
        [Display(Name = "Start Going")]
        public DateTime DateStart { get; set; }
        
        public DateTime DateEnd { get; set; }
       
        public string Description { get; set; }
        
        public double Price { get; set; }
        
        public string StartLocation { get; set; }
        public double Rate { get; set; }
        
        public int OrganizerId { get; set; }
    }
}