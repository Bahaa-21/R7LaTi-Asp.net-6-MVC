namespace R7LaTi.Models
{
    public class UserTrips
    {
        public int TripId { get; set; }
        public Trip Trips { get; set; }

        public string UserId { get; set; }
        public ApplicationUsers Users { get; set; }

        public DateTime AddedOn { get; set;} 
    }
}