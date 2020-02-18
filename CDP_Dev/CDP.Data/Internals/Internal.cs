using CDP.Core;
using CDP.Core.Internals;
using CDP.Service.Internals;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CDP.Data.Internals
{
    public class Internal : IInternal
    {
        IOptions<ReadConfig> _ConnectionString;
        public Internal(IOptions<ReadConfig> ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
        public List<Core.Internals.Internal> GetInternalList()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var ret = con.Query<Core.Internals.Internal>("InternalList", null, null, true, 0, System.Data.CommandType.StoredProcedure).ToList();
                return ret;
            }
        }

        public List<Core.Internals.Internal> GetUserInternalNotMappedList(int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT A.* FROM Internal A  
                             WHERE A.Id NOT IN(SELECT InternalId FROM [User_Internal] WHERE UserId = @UserId)";
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                var ret = con.Query<Core.Internals.Internal>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }

        public List<UserInternal> GetUserInternalList(int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                var ret = con.Query<UserInternal>("UserInternalList", param, null, true, 0, System.Data.CommandType.StoredProcedure).ToList();
                return ret;
            }
        }

        public int InsertInternal(Core.Internals.Internal Internal)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Internal.Id);
                param.Add("@Topic", Internal.Topic);
                param.Add("@TrainingMode", Internal.TrainingMode);
                param.Add("@Description", Internal.Description);
                var result = con.Execute("InsertUpdateInternal", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int InsertUserInternal(UserInternal UserInternal)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", UserInternal.Id);
                param.Add("@UserId", UserInternal.UserId);
                param.Add("@InternalId", UserInternal.InternalId);
                var result = con.Execute("InsertUpdateUserInternal", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int UpdateInternal(Core.Internals.Internal Internal)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Internal.Id);
                param.Add("@Topic", Internal.Topic);
                param.Add("@TrainingMode", Internal.TrainingMode);
                param.Add("@Description", Internal.Description);
                var result = con.Execute("InsertUpdateInternal", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int UpdateUserInternal(UserInternal UserInternal)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", UserInternal.Id);
                param.Add("@UserId", UserInternal.UserId);
                param.Add("@InternalId", UserInternal.InternalId);
                var result = con.Execute("InsertUpdateUserInternal", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int DeleteUserInternal(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var result = con.Execute("DeleteUserInternal", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int DeleteInternal(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var result = con.Execute("DeleteInternal", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
        public UserInternal GetSingleUserInternal(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var ret = con.Query<UserInternal>("SelectSingleUserInternal", param, null, true, 0, System.Data.CommandType.StoredProcedure).SingleOrDefault();
                return ret;
            }
        }

        public Core.Internals.Internal GetSingleInternal(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var ret = con.Query<Core.Internals.Internal>("SelectSingleInternal", param, null, true, 0, System.Data.CommandType.StoredProcedure).SingleOrDefault();
                return ret;
            }
        }
    }
}
