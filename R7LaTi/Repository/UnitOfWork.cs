using R7LaTi.Data;
using R7LaTi.IRepository;
using R7LaTi.Models;

namespace R7LaTi.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    private IGenericRepo<Trip> _trip;
    private IGenericRepo<Organizer> _organizer;
    private IGenericRepo<UserTrips> _customersTrips;

    public UnitOfWork(ApplicationDbContext context) => _context = context;

    public IGenericRepo<Organizer> Organizers => _organizer ??= new GenericRepo<Organizer>(_context);

    public IGenericRepo<UserTrips> CustomersTrips => _customersTrips ??= new GenericRepo<UserTrips>(_context);

    public IGenericRepo<Trip> Trips => _trip ??= new GenericRepo<Trip>(_context);

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task Save() => await _context.SaveChangesAsync();
    
}
