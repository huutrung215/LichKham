using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : IEntity
    {
        public T? Get(T entity);
        public IEnumerable<T> Gets(T entity);
        public string? Execute(T entity);
    }
}
