using Microsoft.EntityFrameworkCore;
using NTierApp.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DataAccess.EF
{
    public class NTierAppDbContext: DbContext
    {
        public NTierAppDbContext(DbContextOptions<NTierAppDbContext> options)
           : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
