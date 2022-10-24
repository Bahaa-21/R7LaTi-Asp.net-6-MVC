namespace R7LaTi.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public byte[]? ProfilePecture { get; set; }
        public DateTime DateAdded { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }

        public string UserId { get; set; }
        public ApplicationUsers User { get; set; }
    }
}