using MeetingManagementDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetingManagementInfrastructure.Configurations;

public class ResolutionConfiguration: IEntityTypeConfiguration<Resolution>
{
    public void Configure(EntityTypeBuilder<Resolution> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Content)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(r => r.Deadline)
            .IsRequired();

        builder.HasOne(r => r.Meeting)
            .WithMany(m => m.Resolutions)
            .HasForeignKey(r => r.MeetingId);

        builder.HasOne(r => r.AssignedTo)
            .WithMany(u => u.AssignedResolutions)
            .HasForeignKey(r => r.UserId);

        builder.Property(r => r.ProgressPercent)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(u => u.CreatedAt)
            .IsRequired();

        builder.Property(u => u.UpdatedAt)
            .IsRequired();


    }
}