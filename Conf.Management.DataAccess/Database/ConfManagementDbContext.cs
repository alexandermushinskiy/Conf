using Microsoft.EntityFrameworkCore;
using Conf.Management.Entities;
using Conf.Management.Infrastructure.DataAccess.Database.EntityConfigurations;

namespace Conf.Management.Infrastructure.DataAccess.Database
{
    public class ConfManagementDbContext : DbContext
    {
        public ConfManagementDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Conference> Conferences { get; set; }

        public DbSet<ConferenceOrganizer> ConferenceOrganizers { get; set; }

        //    public DbSet<SharedAttachment> SharedAttachments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureConference();
            //        modelBuilder.ConfigureCustomerServiceRequest();
            //        modelBuilder.ConfigureSharedAttachment();

            base.OnModelCreating(modelBuilder);
        }
    }
}