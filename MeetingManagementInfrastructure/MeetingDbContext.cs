using MeetingManagementDomain.Entities;
using MeetingManagementInfrastructure.Configurations;
using Microsoft.EntityFrameworkCore;


namespace MeetingManagementInfrastructure
{
    public class MeetingDbContext(DbContextOptions<MeetingDbContext> options) : DbContext(options)
    {

        public DbSet<Meeting> Meetings => Set<Meeting>();
        public DbSet<Resolution> Resolutions => Set<Resolution>();
        public DbSet<User> Users => Set<User>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MeetingConfiguration());

            modelBuilder.ApplyConfiguration(new ResolutionConfiguration());

            modelBuilder.ApplyConfiguration(new UserConfiguration());

        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseEntity>();

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }


    }

}
