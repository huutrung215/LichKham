using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Repositories
{
    public interface IInfoPntCureInDeptRepository : IBaseRepository<InfoPntCureInDept>
    {
        public IEnumerable<InfoPntCureInDept> Gets_InfoPntCureInDept(InfoPntCureInDeptParam entity);
    }
}
