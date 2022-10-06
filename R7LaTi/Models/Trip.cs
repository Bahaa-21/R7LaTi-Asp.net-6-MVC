namespace R7LaTi.Models
{
    public class Trip
    {
        public string Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string StartLocation { get; set; }
        public double Rate { get; set; }

        public int OrganizerId { get; set; }

        
    }
}
