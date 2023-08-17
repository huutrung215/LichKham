using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Utils
{
    public class ParamHelper
    {
        public static DynamicParameters GetParamOnlyTable(object? obj, bool allowPrimaryKey = true)
        {
            var param = new DynamicParameters();
            var typeT = obj?.GetType();
            var properties = typeT?.GetProperties();
            if (properties != null)
            {
                foreach (var property in properties)
                {
                    var primaryKey = property.GetCustomAttribute<PrimaryKeyAttribute>();
                    if (primaryKey == null || allowPrimaryKey)
                    {
                        var tableForeign = property.GetCustomAttribute<TableForeignAttribute>();
                        if (tableForeign == null)
                        {
                            var value = property.GetValue(obj, null);
                            param.Add(property.Name, value);
                        }
                    }
                }
            }
            return param;
        }

        public static string? GetPrimaryKeyName<T>()
        {
            string? idName = null;
            var typeT = typeof(T);
            var properties = typeT?.GetProperties();
            if (properties != null)
            {
                foreach (var property in properties)
                {
                    var primaryKey = property.GetCustomAttribute<PrimaryKeyAttribute>();
                    if (primaryKey != null)
                    {
                        idName = property.Name;
                        break;
                    }
                }
            }
            return idName;
        }
    }
}
