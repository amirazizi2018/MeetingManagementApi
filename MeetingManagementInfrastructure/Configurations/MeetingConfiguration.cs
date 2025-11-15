using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeetingManagementDomain.Entities;


namespace MeetingManagementInfrastructure.Configurations;

public class MeetingConfiguration: IEntityTypeConfiguration<Meeting>
{
    public void Configure(EntityTypeBuilder<Meeting> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(m => m.Description)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(m => m.CreatedAt)
            .IsRequired();

        builder.HasMany(m => m.Resolutions)
            .WithOne(r => r.Meeting)
            .HasForeignKey(r => r.MeetingId);
    }
}