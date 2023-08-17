using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulac.Service.Global
{
    public static class ValueHelper
    {
        /// <summary>
        /// Chuyen doi string date
        /// </summary>
        /// <param name="pStringDate">String Date Format: YYYY/MM/dd OR YYYY-MM-dd OR dd/MM/YYYY OR dd-MM-YYYY</param>
        /// <returns>null: loi chuyen doi; String Date Format dd/MM/YYYY</returns>
        public static string ConvertStringToDate(string pStringDate)
        {
            /* Code Update: 08/05/2018 by NxHung */

            try
            {
                if (pStringDate.Contains("-"))
                {
                    string[] arr = pStringDate.Split('-');
                    if (arr[0].Length > 3)
                    {
                        return arr[2].Trim() + "/" + arr[1].Trim() + "/" + arr[0].Trim();
                    }
                    else if (arr[2].Length > 3)
                    {
                        return arr[0].Trim() + "/" + arr[1].Trim() + "/" + arr[2].Trim();
                    }
                    else
                    {
                        return null;
                    }
                }
                else if (pStringDate.Contains("/"))
                {
                    string[] arr = pStringDate.Split('/');
                    if (arr[0].Length > 3)
                    {
                        return arr[2].Trim() + "/" + arr[1].Trim() + "/" + arr[0].Trim();
                    }
                    else if (arr[2].Length > 3)
                    {
                        return arr[0].Trim() + "/" + arr[1].Trim() + "/" + arr[2].Trim();
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Kiem tra ton tai field trong dataReader
        /// </summary>
        /// <param name="dataReader"></param>
        /// <param name="columnName"></param>
        /// <returns>true: ton tai; false: khong ton tai</returns>
        public static bool ContainsColumn(this IDataReader dataReader, string columnName)
        {
            try
            {
                return dataReader.GetOrdinal(columnName) >= 0;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }
    }
}
