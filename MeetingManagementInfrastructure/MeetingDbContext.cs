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

    }
}
