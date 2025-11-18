using MeetingManagementApplication.Interfaces;
using MeetingManagementApplication.Interfaces.Persistence;
using MeetingManagementDomain.Entities;
using MeetingManagementInfrastructure.Repositories;

namespace MeetingManagementInfrastructure.Persistence;

public class UnitOfWork(MeetingDbContext context) :IUnitOfWork
{
    private readonly MeetingDbContext _context = context;

    private IGenericRepository<Resolution>? _resolutionRepository;
    public IGenericRepository<Resolution> ResolutionRepository =>
        _resolutionRepository ??= new GenericRepository<Resolution>(_context);

    private IGenericRepository<Meeting>? _meetingRepository;
    public IGenericRepository<Meeting> MeetingRepository =>
        _meetingRepository ??= new GenericRepository<Meeting>(_context);

    private IGenericRepository<User>? _userRepository;
    public IGenericRepository<User> UserRepository =>
        _userRepository ??= new GenericRepository<User>(_context);

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }
}