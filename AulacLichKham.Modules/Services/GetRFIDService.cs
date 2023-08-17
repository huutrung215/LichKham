using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Interfaces.Services;
using AulacLichKham.Modules.Utils;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Services
{
    public class GetRFIDService : BaseService<GetRFID>, IGetRFIDService
    {
        private readonly IGetRFIDRepository _repo;
        public GetRFIDService(IGetRFIDRepository repo) : base(repo)
        {
            _repo = repo;
        }
    }
    
    public class GetRFID2Service : BaseService<GetRFID2>, IGetRFID2Service
    {
        private readonly IGetRFID2Repository _repo;
        public GetRFID2Service(IGetRFID2Repository repo) : base(repo)
        {
            _repo = repo;
        }

        public virtual RFID2Response? Execute1(GetRFID2 entity)
        {
            return _repo.Execute1(entity);
        }
    }

}
