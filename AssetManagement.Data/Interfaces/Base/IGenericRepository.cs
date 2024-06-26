using System.Linq.Expressions;

namespace AssetManagement.Data.Interfaces.Base;
public interface IGenericRepository<T>
{
    Task<IEnumerable<T>> All();
    IEnumerable<T> Get(
        Expression<Func<T, bool>> filter,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy,
        string includeProperties);
    IQueryable<T> GetQueryableSet();
    T Add(T entity);
    IEnumerable<T> AddRange(IEnumerable<T> entities);
    Task<List<T>> Find(Expression<Func<T, bool>> predicate);
    Task<T> FindOne(Expression<Func<T, bool>> predicate);
    Task<bool> Check(Expression<Func<T, bool>> predicate);
    T Update(T entity);
    bool Delete(Guid id);
    bool DeleteByEntity(T entity);
    bool DeleteRange(IEnumerable<T> entities);

}
