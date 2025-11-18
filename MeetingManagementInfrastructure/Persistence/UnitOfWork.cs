using MeetingManagementApplication.Interfaces.Persistence;

namespace MeetingManagementInfrastructure.Persistence;

public class UnitOfWork(MeetingDbContext context) :IUnitOfWork
{
    private readonly MeetingDbContext _context = context;

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);

    }
}