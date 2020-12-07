using EXAMENFINALN00038802.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXAMENFINALN00038802.Models
{
    public class ExamenFinalContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ExamenFinalContext(DbContextOptions<ExamenFinalContext> options)
    : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }

    }
}
