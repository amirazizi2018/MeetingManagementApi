using MeetingManagementApplication.Interfaces;
using MeetingManagementApplication.Interfaces.Persistence;
using MeetingManagementDomain.Entities;

namespace MeetingManagementApplication.Services;

public class ResolutionService(IUnitOfWork unitOfWork) : IResolutionService
{
    public async Task<IEnumerable<Resolution>> GetResolutionsByUserId(Guid userId)
    {
        var resolutions = await unitOfWork.ResolutionRepository.GetMany(r => r.UserId == userId);
        return resolutions;
    }

    public async Task<bool> UpdateProgress(Guid resolutionId, int progressPercent)
    {
        var resolution = await unitOfWork.ResolutionRepository.Get(r => r.Id == resolutionId);
        if (resolution is null)
        {
            return false;
        }

        resolution.ProgressPercent = progressPercent;
        unitOfWork.ResolutionRepository.Update(resolution);
        await unitOfWork.SaveChangesAsync();
        return true;
    }
}