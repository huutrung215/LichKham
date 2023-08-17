using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Utils;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AulacLichKham.Modules.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : IEntity
    {
        protected IDbConnection _dbConnection;
        private readonly string _nameStoreProcedure;

        public BaseRepository(IDbConnection dbConnection, string? nameStoreProcedure = null)
        {
            _dbConnection = dbConnection;
            _nameStoreProcedure = nameStoreProcedure ?? typeof(T).Name;
        }

        public virtual string? Execute(T entity)
        {
            string? outputName = ParamHelper.GetPrimaryKeyName<T>();
            //if (string.IsNullOrWhiteSpace(outputName))
            //{
            //    throw new ArgumentNullException(nameof(outputName));
            //}
            var param = ParamHelper.GetParamOnlyTable(entity);
            param.Add(outputName, direction: ParameterDirection.Output, size: 3);
            _dbConnection.Execute(_nameStoreProcedure, param, commandType: CommandType.StoredProcedure);
            string? output = param.Get<string>(outputName);
            return output;
        }

        public virtual T? Get(T entity)
        {
            var param = ParamHelper.GetParamOnlyTable(entity);
            var result = _dbConnection.QueryFirstOrDefault<T>(_nameStoreProcedure, param, commandType: CommandType.StoredProcedure);
            return result;
        }

        public virtual IEnumerable<T> Gets(T entity)
        {
            var param = ParamHelper.GetParamOnlyTable(entity);
            return _dbConnection.Query<T>(_nameStoreProcedure, param, commandType: CommandType.StoredProcedure);
        }
    }
}
