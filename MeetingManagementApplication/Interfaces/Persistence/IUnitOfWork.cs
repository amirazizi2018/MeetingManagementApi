using MeetingManagementDomain.Entities;

namespace MeetingManagementApplication.Interfaces.Persistence;

public interface IUnitOfWork
{
    IGenericRepository<Resolution> ResolutionRepository { get; }
    IGenericRepository<Meeting> MeetingRepository { get; }
    IGenericRepository<User> UserRepository { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

}