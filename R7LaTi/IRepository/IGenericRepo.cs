using System.Linq.Expressions;

namespace R7LaTi.IRepository;

public interface IGenericRepo<T> where T : class
{
    Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> expression = null,
    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
    string[] includes = null);

    //Task<IPagedList<T>> GetAll(RequestParams requestParams = null, string[] includes = null);

    Task<T> GetAsync(Expression<Func<T, bool>> expression = null,
       string[] includes = null);

    Task InsertAsync(T entity);

    Task InsertRangeAsync(IEnumerable<T> entities);

    Task DeleteAsync(int id);

    void Update(T entity);

    void DeleteRange(IEnumerable<T> entities);
}
