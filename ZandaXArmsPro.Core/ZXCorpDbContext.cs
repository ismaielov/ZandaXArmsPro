using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZandaXArmsPro.Core
{
    public class ZXCorpDbContext : DbContext
    {
        public ZXCorpDbContext(DbContextOptions<ZXCorpDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        

    }
}