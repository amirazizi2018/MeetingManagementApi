using System.Linq.Expressions;

namespace MeetingManagementApplication.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<T?> Get(Expression<Func<T, bool>> predicate);
    Task<IEnumerable<T>> GetAll();
    Task Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}