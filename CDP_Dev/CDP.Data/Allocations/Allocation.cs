using CDP.Core;
using CDP.Core.Allocations;
using CDP.Service.Allocations;
using Dapper;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CDP.Data.Allocations
{
    public class Allocation : IAllocation
    {
        IOptions<ReadConfig> _ConnectionString;
        public Allocation(IOptions<ReadConfig> ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }

        public int DeleteAllocation(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var result = con.Execute("DeleteAllocation", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int DeleteUserAllocation(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var result = con.Execute("DeleteUserAllocation", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public List<Core.Allocations.Allocation> GetAllocationList()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var ret = con.Query<Core.Allocations.Allocation>("AllocationList", null, null, true, 0, System.Data.CommandType.StoredProcedure).ToList();
                return ret;
            }
        }
        public List<UserAllocation> GetUserAllocationList(int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                var ret = con.Query<UserAllocation>("UserAllocationList", param, null, true, 0, System.Data.CommandType.StoredProcedure).ToList();
                return ret;
            }
        }

        public List<Core.Allocations.Allocation> GetUserAllocationNotMappedList(int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT A.* FROM Allocation A  
                             WHERE A.Id NOT IN(SELECT AllocationId FROM [User_Allocation] WHERE UserId = @UserId)";
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                var ret = con.Query<Core.Allocations.Allocation>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
        public List<Core.Allocations.UserAllocation> GetUserAllocationNotMarkedList(int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT A.Name AS Allocation, *FROM User_Allocation UA 
                                LEFT JOIN Allocation A ON A.Id = UA.AllocationId 
                                WHERE UA.UserId = @UserId 
                                AND UA.Id NOT IN (SELECT UserAllocationId FROM Report_UserAllocation WHERE UserId = @UserId);";
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                var ret = con.Query<Core.Allocations.UserAllocation>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
        public int InsertAllocation(Core.Allocations.Allocation Allocation)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Allocation.Id);
                param.Add("@Name", Allocation.Name);
                var result = con.Execute("InsertUpdateAllocation", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int InsertUserAllocation(UserAllocation UserAllocation)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", UserAllocation.Id);
                param.Add("@UserId", UserAllocation.UserId);
                param.Add("@AllocationId", UserAllocation.AllocationId);
                param.Add("@Comment", UserAllocation.Comment);
                param.Add("@PriorityId", UserAllocation.PriorityId);
                var result = con.Execute("InsertUpdateUserAllocation", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int UpdateAllocation(Core.Allocations.Allocation Allocation)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Allocation.Id);
                param.Add("@Name", Allocation.Name);
                var result = con.Execute("InsertUpdateAllocation", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int UpdateUserAllocation(UserAllocation UserAllocation)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", UserAllocation.Id);
                param.Add("@UserId", UserAllocation.UserId);
                param.Add("@AllocationId", UserAllocation.AllocationId);
                param.Add("@Comment", UserAllocation.Comment);
                param.Add("@PriorityId", UserAllocation.PriorityId);
                var result = con.Execute("InsertUpdateUserAllocation", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public UserAllocation GetSingleUserAllocation(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var ret = con.Query<UserAllocation>("SelectSingleUserAllocation", param, null, true, 0, System.Data.CommandType.StoredProcedure).SingleOrDefault();
                return ret;
            }
        }

        public Core.Allocations.Allocation GetSingleAllocation(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var ret = con.Query<Core.Allocations.Allocation>("SelectSingleAllocation", param, null, true, 0, System.Data.CommandType.StoredProcedure).SingleOrDefault();
                return ret;
            }
        }
    }
}
