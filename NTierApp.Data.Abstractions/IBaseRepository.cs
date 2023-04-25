using NTierApp.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DataAccess.Abstractions
{
    public interface IBaseRepository<T> where T : ModelEntity
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        T Add(T entity);
        void Remove(int entityId);

    }
}
