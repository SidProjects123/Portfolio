using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using StudyProject_Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject_ApplicationServices.Context
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {

        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>(entity =>
            {
                entity.ToTable("About").HasKey("Id");
            }
            );

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service").HasKey("Id");
            }
            );

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Team").HasKey("Id");
            }
            );

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.ToTable("Portfolio").HasKey("Id");
            }
            );

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact").HasKey("Id");
            }
            );
        }
    }
}
