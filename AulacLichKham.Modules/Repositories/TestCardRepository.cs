using Aulac.Service.Rsc.Tags;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Repositories
{
    public class TestCardRepository : BaseRepository<TestCard>, ITestCardRepository
    {
        public TestCardRepository(IDbConnection dbConnection) : base(dbConnection)
        {
        }

        public bool TestCard(string deviceID, string id)
        {
            try
            {
                var parameters = new { DeviceID = deviceID, ID = id };
                var result = _dbConnection.Execute("SP_TestCard", parameters, commandType: CommandType.StoredProcedure);

                _dbConnection.Open();
                if (result == 0)
                {
                    _dbConnection.Close();
                    return false;
                }
                else
                {
                    _dbConnection.Close();
                    return true;
                }
            } 
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
