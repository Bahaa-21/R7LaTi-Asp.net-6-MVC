using R7LaTi.Models;

namespace R7LaTi.IRepository;

public interface IUnitOfWork : IDisposable
{
    IGenericRepo<Organizer> Organizers { get; }
    IGenericRepo<UserTrips> CustomersTrips { get; }
    IGenericRepo<Trip> Trips { get; }

    Task Save();
}
