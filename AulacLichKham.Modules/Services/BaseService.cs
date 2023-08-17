using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Services
{
    public class BaseService<T> : IBaseService<T> where T : IEntity
    {

        private readonly IBaseRepository<T> _repo;
        public BaseService(IBaseRepository<T> repo)
        {
            _repo = repo;
        }

        public virtual string? Execute(T entity)
        {
            return _repo.Execute(entity);
        }

        public virtual T? Get(T entity)
        {
            return _repo.Get(entity);
        }

        public virtual IEnumerable<T> Gets(T entity)
        {
            return _repo.Gets(entity);
        }
    }
}
