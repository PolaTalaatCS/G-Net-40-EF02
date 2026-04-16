using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace G_Net_40_EF02
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Assigment2;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Organizer>()
                .HasOne(o => o.Profile)
                .WithOne(p => p.Organizer)
                .HasForeignKey<OrganizerProfile>(p => p.OrganizerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
