using Conf.Management.Entities;
using Microsoft.EntityFrameworkCore;

namespace Conf.Management.DataAccess.Database.EntityConfigurations
{
    internal static class ConferenceConfiguration
    {
        public static void ConfigureConference(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conference>().ToTable("conference");

            modelBuilder.Entity<Conference>()
                .Property(conf => conf.Id)
                .HasColumnName("id");

            modelBuilder.Entity<Conference>()
                .HasKey(conf => conf.Id);

            modelBuilder.Entity<Conference>()
                .Property(conf => conf.Name)
                .HasColumnName("name")
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}