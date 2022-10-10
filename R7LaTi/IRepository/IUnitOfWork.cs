using R7LaTi.Models;

namespace R7LaTi.IRepository;

public interface IUnitOfWork : IDisposable
{
    IGenericRepo<Organizer> Organizers { get; }
    IGenericRepo<Customer>  Customers { get; }
    IGenericRepo<CustomersTrips> CustomersTrips { get; }
    IGenericRepo<Trip> Trips { get; }

    Task Save();
}
