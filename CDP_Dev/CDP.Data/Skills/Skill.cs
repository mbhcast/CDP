using CDP.Core;
using CDP.Core.Skills;
using CDP.Service.Skills;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CDP.Data.Skills
{
    public class Skill : ISkill
    {
        IOptions<ReadConfig> _ConnectionString;
        public Skill(IOptions<ReadConfig> ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
        public int DeleteSkill(int Id)
        {
            throw new NotImplementedException();
        }

        public int DeleteSkillType(int Id)
        {
            throw new NotImplementedException();
        }

        public Core.Skills.Skill GetSkill(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var ret = con.Query<Core.Skills.Skill>("SelectSkill", param, null, true, 0, System.Data.CommandType.StoredProcedure).SingleOrDefault();
                return ret;
            }
        }

        public List<Core.Skills.Skill> GetSkillList()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var ret = con.Query<Core.Skills.Skill>("SkillList", null, null, true, 0, System.Data.CommandType.StoredProcedure).ToList();
                return ret;
            }
        }

        public SkillType GetSkillType(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                var ret = con.Query<SkillType>("SelectSkillType", param, null, true, 0, System.Data.CommandType.StoredProcedure).SingleOrDefault();
                return ret;
            }
        }

        public List<SkillType> GetSkillTypeList()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var ret = con.Query<SkillType>("SkillTypeList", null, null, true, 0, System.Data.CommandType.StoredProcedure).ToList();
                return ret;
            }
        }

        public List<UserSkill> GetUserSkillList(int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                var ret = con.Query<UserSkill>("UserSkillList", param, null, true, 0, System.Data.CommandType.StoredProcedure).ToList();
                return ret;
            }
        }

        public List<Core.Skills.Skill> GetUserSkillNotMappedList(int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT S.*,ST.Name AS SkillType FROM Skill S 
                             LEFT JOIN SkillType ST ON S.SkillTypeId = ST.Id 
                             WHERE S.Id NOT IN(SELECT SkillId FROM[User_Skill] WHERE UserId = @UserId)";
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                var ret = con.Query<Core.Skills.Skill>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }

        public int InsertSkill(Core.Skills.Skill Skill)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Skill.Id);
                param.Add("@SkillTypeId", Skill.SkillTypeId);
                param.Add("@Name", Skill.Name);
                param.Add("@Description", Skill.Description);
                var result = con.Execute("InsertUpdateSkill", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int InsertSkillType(SkillType SkillType)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", SkillType.Id);
                param.Add("@Name", SkillType.Name);
                param.Add("@Description", SkillType.Description);
                var result = con.Execute("InsertUpdateSkillType", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int InsertUserSkill(UserSkill UserSkill)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", UserSkill.Id);
                param.Add("@UserId", UserSkill.UserId);
                param.Add("@IsPrimary", UserSkill.IsPrimary);
                param.Add("@SkillId", UserSkill.SkillId);
                var result = con.Execute("InsertUpdateUserSkill", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int UpdateSkill(Core.Skills.Skill Skill)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", Skill.Id);
                param.Add("@SkillTypeId", Skill.SkillTypeId);
                param.Add("@Name", Skill.Name);
                param.Add("@Description", Skill.Description);
                var result = con.Execute("InsertUpdateSkill", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int UpdateSkillType(SkillType SkillType)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", SkillType.Id);
                param.Add("@Name", SkillType.Name);
                param.Add("@Description", SkillType.Description);
                var result = con.Execute("InsertUpdateSkillType", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public int UpdateUserSkill(UserSkill UserSkill)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", UserSkill.Id);
                param.Add("@UserId", UserSkill.UserId);
                param.Add("@IsPrimary", UserSkill.IsPrimary);
                param.Add("@SkillId", UserSkill.SkillId);
                var result = con.Execute("InsertUpdateUserSkill", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
