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
        public List<Core.Common.Period> GetPeriodList()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT * FROM Period;";
                var param = new DynamicParameters();
                var ret = con.Query<Core.Common.Period>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
        public List<Core.Common.Status> GetStatusList()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT * FROM Status;";
                var param = new DynamicParameters();
                var ret = con.Query<Core.Common.Status>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
        public List<Core.Common.Period> GetNotMarkedPeriodForUserAllocation(int UserAllocationId, int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT *FROM Period P  
                            WHERE Id NOT IN (SELECT PeriodId FROM Report_UserAllocation WHERE UserId = @UserId AND UserAllocationId = @UserAllocationId);";
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                param.Add("@UserAllocationId", UserAllocationId);
                var ret = con.Query<Core.Common.Period>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
        public List<Core.Common.Period> GetNotMarkedPeriodForUserInternal(int UserInternalId, int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT *FROM Period P  
                            WHERE Id NOT IN (SELECT PeriodId FROM Report_UserInternal WHERE UserId = @UserId AND UserInternalId = @UserInternalId);";
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                param.Add("@UserInternalId", UserInternalId);
                var ret = con.Query<Core.Common.Period>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
        public List<Core.Common.Period> GetNotMarkedPeriodForUserMentor(int UserMentorId, int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT *FROM Period P  
                            WHERE Id NOT IN (SELECT PeriodId FROM Report_UserMentor WHERE UserId = @UserId AND UserMentorId = @UserMentorId);";
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                param.Add("@UserMentorId", UserMentorId);
                var ret = con.Query<Core.Common.Period>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
    }
}
