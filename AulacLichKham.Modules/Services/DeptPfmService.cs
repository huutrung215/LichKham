using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Services
{
    public class DeptPfmService:BaseService<DeptPfm>, IDeptPfmService
    {
        private readonly IDeptPfmRepository _repo;
        public DeptPfmService(IDeptPfmRepository repo) : base(repo)
        {
            _repo = repo;
        }
    }
}
