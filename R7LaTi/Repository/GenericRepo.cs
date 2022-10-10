using Microsoft.EntityFrameworkCore;
using R7LaTi.Data;
using R7LaTi.IRepository;
using System.Linq.Expressions;
using X.PagedList;

namespace R7LaTi.Repository;

public class GenericRepo<T> : IGenericRepo<T> where T : class
{

    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _db;

    public GenericRepo(ApplicationDbContext context) => (_context, _db) = (context, _context.Set<T>());

    public async Task DeleteAsync(int id)
    {
        var entity = await _db.FindAsync(id);
        _db.Remove(entity);
    }

    public void DeleteRange(IEnumerable<T> entities) => _db.RemoveRange(entities);


    public async Task<T> GetAsync(Expression<Func<T, bool>> expression = null, string[] includes = null)
    {
        IQueryable<T> query = _db;
        if (includes != null)
        {
            foreach (var item in includes)
            {
                query = query.Include(item);
            }
        }
        return await query.AsNoTracking().FirstOrDefaultAsync(expression);
    }

    public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string[] includes = null)
    {
        IQueryable<T> query = _db;

        if (expression != null)
        {
            query = query.Where(expression);
        }

        if (includes != null)
        {
            foreach (var item in includes)
            {
                query = query.Include(item);
            }
        }

        if (orderBy != null)
        {
            query = orderBy(query);
        }

        return await query.AsNoTracking().ToListAsync();
    }

    //public async Task<IPagedList<T>> GetAll(RequestParams requestParams = null, string[] includes = null)
    //{
    //    IQueryable<T> query = _db;

    //    if (includes != null)
    //    {
    //        foreach (var item in includes)
    //        {
    //            query = query.Include(item);
    //        }
    //    }
    //    return await query.AsNoTracking().ToPagedListAsync(requestParams.PageNumber, requestParams.PageSize);
    //}

    public async Task InsertAsync(T entity) => await _db.AddAsync(entity);

    public async Task InsertRangeAsync(IEnumerable<T> entities) => await _db.AddRangeAsync(entities);

    public void Update(T entity)
    {
        _db.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }
}
