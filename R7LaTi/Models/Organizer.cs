namespace R7LaTi.Models
{
    public class Organizer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //Navigations Properties
        public virtual List<Trip> Trips { get; set; }
    }
}
