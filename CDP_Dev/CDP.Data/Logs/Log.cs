using CDP.Core;
using CDP.Core.Logs;
using CDP.Service.Logs;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CDP.Data.Logs
{
    public class Log : ILog
    {
        IOptions<ReadConfig> _ConnectionString;
        public Log(IOptions<ReadConfig> ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }

        public int InsertLog(Core.Logs.Log Log)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
                {
                    con.Open();
                    SqlTransaction sqltrans = con.BeginTransaction();
                    var param = new DynamicParameters();
                    param.Add("@ShortDescription", Log.ShortDescription);
                    param.Add("@FullDescription", Log.FullDescription);
                    param.Add("@CreatedOn", Log.CreatedOn);
                    var result = con.Query<int>("INSERT INTO Log VALUES(@ShortDescription,@FullDescription,getutcdate()); SELECT CAST(SCOPE_IDENTITY() as int);", param, sqltrans, true, 0, System.Data.CommandType.Text).Single();

                    if (result > 0)
                    {
                        sqltrans.Commit();
                    }
                    else
                    {
                        sqltrans.Rollback();
                    }
                    return result;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
