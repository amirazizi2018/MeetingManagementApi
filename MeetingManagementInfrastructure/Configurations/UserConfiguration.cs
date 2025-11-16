using MeetingManagementDomain.Entities;
using MeetingManagementShared.Enums;
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
            .HasConversion<string>()
            .IsRequired();

        builder.HasMany(u => u.AssignedResolutions)
            .WithOne(r => r.AssignedTo)
            .HasForeignKey(r => r.UserId);

        builder.Property(u => u.CreatedAt)
            .IsRequired();

        builder.Property(u => u.UpdatedAt)
            .IsRequired();
        
        var users = new List<User>
        {
            new User
            {
                Id = Guid.Parse("cd3252f7-f18c-4b21-9a50-c54b58688e58"),
                FirstName = "امیر",
                LastName = "عزیزی",
                Email = "admin@gmail.com",
                Password = "$2a$11$PApAaAqms9uDUO5iRKiNce8sYcVSg4wxBSho1AUbNtiiQjl/9R67.",
                Role = UserRole.Admin,
                CreatedAt = new DateTime(2025, 11, 16, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2025, 11, 16, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = Guid.Parse("7b9684f9-51d1-423f-8666-b51c55d95918"),
                FirstName = "علی",
                LastName = "منصوری",
                Email = "ali@gmail.com",
                Password = "$2a$11$L4mbMrzlIbCGfoDxS3Q.H.vBlMXf4zipRi7axon5SXVbNEuqXvIlW",
                Role = UserRole.Member,
                CreatedAt = new DateTime(2025, 11, 16, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2025, 11, 16, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = Guid.Parse("d3a3b7fb-b599-4647-b059-306625200570"),
                FirstName = "محمد",
                LastName = "مقدسی",
                Email = "mohammad@gmail.com",
                Password = "$2a$11$57s53U4BtYwe6SrCZraP7u1JWycYZToWC9M5NNkBw9G58qhXl7hUO",
                Role = UserRole.Member,
                CreatedAt = new DateTime(2025, 11, 16, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2025, 11, 16, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = Guid.Parse("769b400f-aeec-4669-9784-e7a3ebf7fccb"),
                FirstName = "حسن",
                LastName = "احسانی",
                Email = "hassan@gmail.com",
                Password = "$2a$11$K9/BW2vLSJzDhIxpbLvkreFEipNpKSy4GLlkD1fvuR8J7jltaduV2",
                Role = UserRole.Member,
                CreatedAt = new DateTime(2025, 11, 16, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2025, 11, 16, 0, 0, 0, DateTimeKind.Utc)
            }
        };

        builder.HasData(users);

    }
}