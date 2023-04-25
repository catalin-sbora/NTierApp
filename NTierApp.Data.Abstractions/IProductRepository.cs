using NTierApp.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DataAccess.Abstractions
{
    public interface IProductRepository: IBaseRepository<Product>
    {
        Product? GetProductByName(string name);
    }
}
