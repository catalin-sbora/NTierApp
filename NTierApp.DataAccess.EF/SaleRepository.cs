using Microsoft.EntityFrameworkCore;
using NTierApp.DataAccess.Abstractions;
using NTierApp.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DataAccess.EF
{
    public class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
        public SaleRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
