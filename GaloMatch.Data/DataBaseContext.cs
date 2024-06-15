
using GaloMatch.Domain.Aggregates.Matches;
using GaloMatch.Domain.Aggregates.Users;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaloMatch.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() { }
        public DbSet<Match> Matches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PretendedEvent> PretendedEvents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=tcp:dayrell.database.windows.net,1433;Initial Catalog=galomatch;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";");
        }

    }

}
