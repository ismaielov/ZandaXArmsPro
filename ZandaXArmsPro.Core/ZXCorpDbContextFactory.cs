using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ZandaXArmsPro.Core
{
    public class ZXCorpDbContextFactory : IDesignTimeDbContextFactory<ZXCorpDbContext>
    {
        public ZXCorpDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ZXCorpDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ZandaXCorporation;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new ZXCorpDbContext(optionsBuilder.Options);
        }

    }


}