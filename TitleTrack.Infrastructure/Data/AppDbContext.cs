using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitleTrack.Domain.Entities;

namespace TitleTrack.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TitleAbstract> TitleAbstracts => Set<TitleAbstract>();
        public DbSet<Property> Properties => Set<Property>();
        public DbSet<ProductType> ProductTypes => Set<ProductType>();
        public DbSet<Client> Clients => Set<Client>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=TitleTrackDb;Trusted_Connection=True");
    }
}
