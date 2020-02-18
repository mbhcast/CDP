using CDP.Core;
using CDP.Core.Training;
using CDP.Service.Training;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CDP.Data.Training
{
    public class Training : ITraining
    {
        IOptions<ReadConfig> _ConnectionString;
        public Training(IOptions<ReadConfig> ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
        public List<TrainingCategory> GetTrainingCategotyList()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var ret = con.Query<TrainingCategory>("TrainingCategoryList", null, null, true, 0, System.Data.CommandType.StoredProcedure).ToList();
                return ret;
            }
        }
        public TrainingCategory GetSingleTrainingCategory(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var ret = con.Query<TrainingCategory>("SelectSingleTrainingCategory", param, null, true, 0, System.Data.CommandType.StoredProcedure).SingleOrDefault();
                return ret;
            }
        }
        public TrainingMaster GetSingleTrainingMaster(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var ret = con.Query<TrainingMaster>("SelectSingleTrainingMaster", param, null, true, 0, System.Data.CommandType.StoredProcedure).SingleOrDefault();
                return ret;
            }
        }
        public UserTraining GetSingleUserTraining(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var ret = con.Query<UserTraining>("SelectSingleUserTraining", param, null, true, 0, System.Data.CommandType.StoredProcedure).SingleOrDefault();
                return ret;
            }
        }
        public int InsertTrainingCategory(TrainingCategory TrainingCategory)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", TrainingCategory.Id);
                param.Add("@Code", TrainingCategory.Code);
                param.Add("@Name", TrainingCategory.Name);
                param.Add("@Description", TrainingCategory.Description);
                param.Add("@IsPrimary", TrainingCategory.IsPrimary);
                var result = con.Execute("InsertUpdateSingleTrainingCategory", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int InsertTrainingMaster(TrainingMaster TrainingMaster)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", TrainingMaster.Id);
                param.Add("@Code", TrainingMaster.Code);
                param.Add("@TrainingCategoryId", TrainingMaster.TrainingCategoryId);
                param.Add("@Name", TrainingMaster.Name);
                param.Add("@Description", TrainingMaster.Description);
                param.Add("@TOC", TrainingMaster.TOC);
                param.Add("@IsExternal", TrainingMaster.IsExternal);
                var result = con.Execute("InsertUpdateSingleTrainingMaster", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int UpdateTrainingCategory(TrainingCategory TrainingCategory)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", TrainingCategory.Id);
                param.Add("@Code", TrainingCategory.Code);
                param.Add("@Name", TrainingCategory.Name);
                param.Add("@Description", TrainingCategory.Description);
                param.Add("@IsPrimary", TrainingCategory.IsPrimary);
                var result = con.Execute("InsertUpdateSingleTrainingCategory", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
        public int UpdateTrainingMaster(TrainingMaster TrainingMaster)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", TrainingMaster.Id);
                param.Add("@Code", TrainingMaster.Code);
                param.Add("@Name", TrainingMaster.Name);
                param.Add("@TrainingCategoryId", TrainingMaster.TrainingCategoryId);
                param.Add("@Description", TrainingMaster.Description);
                param.Add("@TOC", TrainingMaster.TOC);
                param.Add("@IsExternal", TrainingMaster.IsExternal);
                var result = con.Execute("InsertUpdateSingleTrainingMaster", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
        public int UpdateUserTraining(UserTraining UserTraining)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", UserTraining.Id);
                param.Add("@UserId", UserTraining.UserId);
                param.Add("@TrainingId", UserTraining.TrainingId);
                var result = con.Execute("InsertUpdateSingleUserTraining", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
        public int DeleteTrainingCategory(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var result = con.Execute("DeleteSingleTrainingCategory", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int DeleteTrainingMaster(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var result = con.Execute("DeleteSingleTrainingMaster", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
        public int DeleteUserTraining(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var result = con.Execute("DeleteUserTraining", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
        public List<TrainingMaster> GetTrainingMasterList()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var ret = con.Query<TrainingMaster>("TrainingMasterList", null, null, true, 0, System.Data.CommandType.StoredProcedure).ToList();
                return ret;
            }
        }

        public List<UserTraining> GetUserTrainingList(int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                var ret = con.Query<UserTraining>("UserTrainingList", param, null, true, 0, System.Data.CommandType.StoredProcedure).ToList();
                return ret;
            }
        }

        public List<TrainingMaster> GetUserTrainingNotMappedList(int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT TM.*,TC.Name AS TrainingCategory FROM TrainingMaster TM 
                            LEFT JOIN TrainingCategory TC ON TM.TrainingCategoryId = TC.Id 
                            WHERE TM.Id NOT IN(SELECT TrainingId FROM[User_Training] WHERE UserId = @UserId)";
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                var ret = con.Query<TrainingMaster>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }

        public int InsertUserTraining(UserTraining UserTraining)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", UserTraining.Id);
                param.Add("@UserId", UserTraining.UserId);
                param.Add("@TrainingId", UserTraining.TrainingId);
                param.Add("@PriorityId", UserTraining.PriorityId);
                var result = con.Execute("InsertUpdateSingleUserTraining", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public List<TrainingMaster> GetUniqueUserTrainingList()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT DISTINCT (TM.Id), (TM.Code + ' - ' + TM.Name) AS Name FROM User_Training UT 
                                LEFT JOIN TrainingMaster TM ON TM.Id = UT.TrainingId 
                                ORDER BY TM.Id;";
                var ret = con.Query<TrainingMaster>(sql, null, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
    }
}
