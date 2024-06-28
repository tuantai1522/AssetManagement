using AssetManagement.Data.Data;
using AssetManagement.Data.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AssetManagement.Data.Repositories.Base;
public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected AssetManagementDbContext _context;
    internal DbSet<T> dbSet;

    public GenericRepository(AssetManagementDbContext context)
    {
        _context = context;
        dbSet = context.Set<T>();
    }

    public virtual IEnumerable<T> Get(
           Expression<Func<T, bool>> filter,
           Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
           string includeProperties = "")
    {
        IQueryable<T> query = dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        if (orderBy != null)
        {
            return orderBy(query).ToList();
        }
        else
        {
            return query.ToList();
        }
    }

    public IQueryable<T> GetQueryableSet()
    {
        return _context.Set<T>();
    }

    public virtual T Add(T entity)
    {
        dbSet.Add(entity);
        return entity;
    }

    public virtual IEnumerable<T> AddRange(IEnumerable<T> entities)
    {
        if (entities.Any())
        {
            dbSet.AddRange(entities);
            return entities;
        }
        else
        {
            throw new Exception(message: "An error occours when adding ranged of entities");
        }
    }

    public virtual bool Delete(Guid id)
    {
        var entity = dbSet.Find(id);
        if (entity == null)
        {
            return false;
        }
        else
            dbSet.Remove(entity);
        return true;
    }

    public virtual bool DeleteByEntity(T entity)
    {
        dbSet.Remove(entity);
        return true;
    }

    public virtual bool DeleteRange(IEnumerable<T> entities)
    {
        dbSet.RemoveRange(entities);
        return true;
    }

    public virtual async Task<IEnumerable<T>> All()
    {
        return await dbSet.ToListAsync();
    }

    public async Task<List<T>> Find(Expression<Func<T, bool>> predicate)
    {
        return await dbSet.Where(predicate).ToListAsync();
    }

    public async Task<T?> FindOne(Expression<Func<T, bool>> predicate)
    {
        return await dbSet.Where(predicate).FirstOrDefaultAsync();
    }

    public async Task<bool> Check(Expression<Func<T, bool>> predicate)
    {
        return await dbSet.AnyAsync(predicate);
    }

    public T Update(T entity)
    {
        dbSet.Update(entity);
        return entity;
    }
}
