using CDP.Core;
using CDP.Core.Reports;
using CDP.Service.Reports;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CDP.Data.Reports
{
    public class Report : IReport
    {
        IOptions<ReadConfig> _ConnectionString;
        public Report(IOptions<ReadConfig> ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
        public List<Core.Reports.ReportUserAllocation> GetUserAllocationReport(int UserId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
                {
                    string sql = @"SELECT RUA.Id AS Id, A.Name AS UserAllocation, P.Name AS Period, S.Id AS StatusId, S.Name AS Status, S.Color, *FROM Report_UserAllocation RUA 
                                    LEFT JOIN Period P ON P.Id = RUA.PeriodId 
                                    LEFT JOIN User_Allocation UA ON UA.Id = RUA.UserAllocationId 
                                    LEFT JOIN Allocation A ON A.Id = UA.AllocationId 
                                    LEFT JOIN Status S ON S.Id = RUA.StatusId 
                                    WHERE RUA.UserId = @UserId;";
                    var param = new DynamicParameters();
                    param.Add("@UserId", UserId);
                    var ret = con.Query<Core.Reports.ReportUserAllocation>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                    return ret;

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<ReportUserInternal> GetUserInternalReport(int UserId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
                {
                    string sql = @"SELECT RUI.Id AS Id, I.Topic AS UserAllocation, P.Name AS Period, S.Id AS StatusId, S.Name AS Status, S.Color, *FROM Report_UserInternal RUI 
                                    LEFT JOIN Period P ON P.Id = RUI.PeriodId 
                                    LEFT JOIN User_Internal UI ON UI.Id = RUI.UserInternalId 
                                    LEFT JOIN Internal I ON I.Id = UI.InternalId 
                                    LEFT JOIN Status S ON S.Id = RUI.StatusId 
                                    WHERE RUI.UserId = @UserId;";
                    var param = new DynamicParameters();
                    param.Add("@UserId", UserId);
                    var ret = con.Query<Core.Reports.ReportUserInternal>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                    return ret;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ReportUserMentor> GetUserMentorReport(int UserId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
                {
                    string sql = @"SELECT RUM.Id AS Id, U.Name AS UserMentor, P.Name AS Period, S.Id AS StatusId, S.Name AS Status, S.Color, *FROM Report_UserMentor RUM 
                                    LEFT JOIN Period P ON P.Id = RUM.PeriodId 
                                    LEFT JOIN User_Mentor UM ON UM.Id = RUM.UserMentorId 
                                    LEFT JOIN Users U ON U.Id = UM.MentorId 
                                    LEFT JOIN Status S ON S.Id = RUM.StatusId 
                                    WHERE RUM.UserId = @UserId;";
                    var param = new DynamicParameters();
                    param.Add("@UserId", UserId);
                    var ret = con.Query<Core.Reports.ReportUserMentor>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                    return ret;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int InsertReportUserAllocation(Core.Reports.ReportUserAllocation ReportUserAllocation)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", ReportUserAllocation.Id);
                param.Add("@Comment", ReportUserAllocation.Comment);
                param.Add("@PeriodId", ReportUserAllocation.PeriodId);
                param.Add("@UserAllocationId", ReportUserAllocation.UserAllocationId);
                param.Add("@UserId", ReportUserAllocation.UserId);
                param.Add("@StatusId", ReportUserAllocation.StatusId);
                var result = con.Execute("InsertUpdateReportUserAllocation", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int InsertReportUserInternal(ReportUserInternal ReportUserInternal)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", ReportUserInternal.Id);
                param.Add("@Comment", ReportUserInternal.Comment);
                param.Add("@PeriodId", ReportUserInternal.PeriodId);
                param.Add("@UserAllocationId", ReportUserInternal.UserInternalId);
                param.Add("@UserId", ReportUserInternal.UserId);
                param.Add("@StatusId", ReportUserInternal.StatusId);
                var result = con.Execute("InsertUpdateReportUserInternal", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int InsertReportUserMentor(ReportUserMentor ReportUserMentor)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", ReportUserMentor.Id);
                param.Add("@Comment", ReportUserMentor.Comment);
                param.Add("@PeriodId", ReportUserMentor.PeriodId);
                param.Add("@UserAllocationId", ReportUserMentor.UserMentorId);
                param.Add("@UserId", ReportUserMentor.UserId);
                param.Add("@StatusId", ReportUserMentor.StatusId);
                var result = con.Execute("InsertUpdateReportUserMentor", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
    }
}
