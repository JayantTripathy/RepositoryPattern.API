using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEFCore.DataContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .Property(b => b.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<Movie>()
    .Property(b => b.UpdatedDate)
    .HasDefaultValue(DateTime.Now);
        }
        public DbSet<Movie> Movies { get; set; }
    }
}