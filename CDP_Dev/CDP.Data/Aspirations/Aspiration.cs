using CDP.Core;
using CDP.Core.Aspirations;
using CDP.Service.Aspirations;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CDP.Data.Aspirations
{
    public class Aspiration : IAspiration
    {
        IOptions<ReadConfig> _ConnectionString;
        public Aspiration(IOptions<ReadConfig> ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
        public List<UserAspiration> GetUserAspirationList(int UserId = 0)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT UA.*, U.Name AS [User] FROM UserAspiration UA 
                                LEFT JOIN Users U ON U.Id = UA.UserId 
                                WHERE UA.UserId = @UserId";
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                var ret = con.Query<UserAspiration>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }

        public int InsertUserAspiration(UserAspiration UserAspiration)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", UserAspiration.Id);
                param.Add("@UserId", UserAspiration.UserId);
                param.Add("@Description", UserAspiration.Description);
                var result = con.Execute("InsertUpdateUserAspiration", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
        public int UpdateUserAspiration(UserAspiration UserAspiration)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
                {
                    con.Open();
                    SqlTransaction sqltrans = con.BeginTransaction();
                    var param = new DynamicParameters();
                    param.Add("@Id", UserAspiration.Id);
                    param.Add("@UserId", UserAspiration.UserId);
                    param.Add("@Description", UserAspiration.Description);
                    var result = con.Execute("InsertUpdateUserAspiration", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
        public int DeleteUserAspiration(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var result = con.Execute("DeleteUserAspiration", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
        public UserAspiration GetSingleUserAspiration(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var ret = con.Query<UserAspiration>("SelectSingleUserAspiration", param, null, true, 0, System.Data.CommandType.StoredProcedure).SingleOrDefault();
                return ret;
            }
        }
    }
}
