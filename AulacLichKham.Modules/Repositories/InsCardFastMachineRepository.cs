using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Repositories
{
    public class InsCardFastMachineRepository : BaseRepository<InsCardFastMachine>, IInsCardFastMachineRepository
    {
        public InsCardFastMachineRepository(IDbConnection dbConnection) : base(dbConnection, "SP_GetAccountSocialInsurance")
        {
        }

        public string? Get_InsCardFastMachine(InsCardFastMachine entity)
        {
            return base.Execute(entity);
        }
    }
}
