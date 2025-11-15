using MeetingManagementDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetingManagementInfrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(u => u.Password)
            .IsRequired();

        builder.Property(u => u.Role)
            .IsRequired();

        builder.HasMany(u => u.AssignedResolutions)
            .WithOne(r => r.AssignedTo)
            .HasForeignKey(r => r.UserId);

        //builder.HasData(new User
        //{
        //    Id = Guid.Parse("7923C8A7-EDE6-4831-A735-98EBD700FC35"),
        //    FirstName = "امیر",
        //    LastName = "عزیزی",
        //    Email = "amirazizi67@gmail.com",
        //    Password = BCrypt.Net.BCrypt.HashPassword("123456@Aa"),
        //    Password = "$2a$11$mYriolok.RbfktG00wvrMOtw9dqMr5RVURQ8HJw2tkUkQYhd.ylou",
        //    Role = Role.Admin
        //});

    }
}