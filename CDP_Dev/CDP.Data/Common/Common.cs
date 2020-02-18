using CDP.Core;
using CDP.Service.Common;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CDP.Data.Common
{
    public class Common : ICommon
    {
        IOptions<ReadConfig> _ConnectionString;
        public Common(IOptions<ReadConfig> ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }

        public List<Core.Common.Priority> GetPriorityList()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT * FROM Priority;";
                var param = new DynamicParameters();
                var ret = con.Query<Core.Common.Priority>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
    }
}
