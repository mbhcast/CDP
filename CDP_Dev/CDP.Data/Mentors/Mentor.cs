using CDP.Core;
using CDP.Core.Mentors;
using CDP.Service.Mentors;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CDP.Data.Mentors
{
    public class Mentor : IMentor
    {
        IOptions<ReadConfig> _ConnectionString;
        public Mentor(IOptions<ReadConfig> ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
        public List<UserMentor> GetUserMentorList(int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                var ret = con.Query<UserMentor>("UserMentorList", param, null, true, 0, System.Data.CommandType.StoredProcedure).ToList();
                return ret;
            }
        }

        public List<UserMentor> GetUserMentorNotMappedList(int UserId)
        {
            throw new NotImplementedException();
        }

        public int InsertUserMentor(UserMentor UserMentor)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", UserMentor.Id);
                param.Add("@UserId", UserMentor.UserId);
                param.Add("@MentorId", UserMentor.MentorId);
                param.Add("@TrainingCategoryId", UserMentor.TrainingCategoryId);
                param.Add("@Comment", UserMentor.Comment);
                var result = con.Execute("InsertUpdateUserMentor", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int UpdateUserMentor(UserMentor UserMentor)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", UserMentor.Id);
                param.Add("@UserId", UserMentor.UserId);
                param.Add("@MentorId", UserMentor.MentorId);
                param.Add("@TrainingCategoryId", UserMentor.TrainingCategoryId);
                param.Add("@Comment", UserMentor.Comment);
                var result = con.Execute("InsertUpdateUserMentor", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public UserMentor GetSingleUserMentor(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var ret = con.Query<UserMentor>("SelectSingleUserMentor", param, null, true, 0, System.Data.CommandType.StoredProcedure).SingleOrDefault();
                return ret;
            }
        }
        public int DeleteUserMentor(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var result = con.Execute("DeleteUserMentor", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
