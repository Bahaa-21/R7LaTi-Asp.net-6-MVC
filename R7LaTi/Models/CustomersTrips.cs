namespace R7LaTi.Models
{
    public class CustomersTrips
    {
        public int TripId { get; set; }
        public Trip Trips { get; set; }

        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
    }
}