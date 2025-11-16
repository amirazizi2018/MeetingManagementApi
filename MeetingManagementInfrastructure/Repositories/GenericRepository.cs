using MeetingManagementApplication.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MeetingManagementInfrastructure.Repositories;

public class GenericRepository<T>(MeetingDbContext context) : IGenericRepository<T>
    where T : class
{
    private readonly MeetingDbContext _context = context;
    private readonly DbSet<T> _dbSet = context.Set<T>();


    public async Task<T?> Get(Expression<Func<T, bool>> predicate) => await _dbSet.FirstOrDefaultAsync(predicate);
    
    public async Task<IEnumerable<T>> GetAll() => await _dbSet.ToListAsync();

    public async Task Add(T entity) => await _dbSet.AddAsync(entity);

    public void Update(T entity) => _dbSet.Update(entity);

    public void Delete(T entity) => _dbSet.Remove(entity);

}