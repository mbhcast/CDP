using CDP.Core;
using CDP.Core.Users;
using CDP.Service.Users;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CDP.Data.Users
{
    public class User : IUser
    {
        IOptions<ReadConfig> _ConnectionString;
        public User(IOptions<ReadConfig> ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
        public List<Core.Users.User> GetUserList()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT U1.*, U2.Name AS Manager, U2.Trigram AS  ManagerTrigram 
                                FROM Users U1 LEFT JOIN Users U2 ON U1.ManagerId = U2.Id ORDER BY U1.Name;";

                var ret = con.Query<Core.Users.User>(sql, null, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
        public List<Core.Users.User> GetInternalUserList()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT * FROM Users WHERE IsExternal = 0 ORDER BY Name;";

                var ret = con.Query<Core.Users.User>(sql, null, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
        public List<Core.Users.User> GetUserListForTraining(int TrainingId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@TrainingId", TrainingId);

                string sql = @"SELECT U.* FROM User_Training UT 
                                LEFT JOIN Users U ON UT.UserId = U.Id 
                                WHERE UT.TrainingId = @TrainingId AND UT.UserId NOT IN ( 
                                SELECT UC.AttendeeId FROM Calendar C 
                                LEFT JOIN User_Calendar UC ON UC.CalendarId = C.Id 
                                WHERE C.TrainingId = @TrainingId);";

                var ret = con.Query<Core.Users.User>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
        public Core.Users.User GetUser(int Id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@Id", Id);
                string sql = @"SELECT U1.*, U2.Name AS Manager, U2.Trigram AS  ManagerTrigram 
                                FROM Users U1 LEFT JOIN Users U2 ON U1.ManagerId = U2.Id WHERE U1.Id = @Id;";
                var ret = con.Query<Core.Users.User>(sql, param, null, true, 0, System.Data.CommandType.Text).FirstOrDefault();
                return ret;
            }
        }
        public int InsertUser(Core.Users.User user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
                {
                    con.Open();
                    SqlTransaction sqltrans = con.BeginTransaction();
                    var param = new DynamicParameters();
                    param.Add("@Id", user.Id);
                    param.Add("@DisplayName", user.DisplayName);
                    param.Add("@Name", user.Name);
                    param.Add("@Trigram", user.Trigram);
                    param.Add("@ManagerId", user.ManagerId);
                    param.Add("@Email", user.Email);
                    param.Add("@IsExternal", user.IsExternal);
                    param.Add("@IsPresenter", user.IsPresenter);
                    var result = con.Execute("InsertUpdateUser", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateUser(Core.Users.User user)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                con.Open();
                SqlTransaction sqltrans = con.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Id", user.Id);
                param.Add("@DisplayName", user.DisplayName);
                param.Add("@Name", user.Name);
                param.Add("@Trigram", user.Trigram);
                param.Add("@ManagerId", user.ManagerId);
                param.Add("@Email", user.Email);
                param.Add("@IsExternal", user.IsExternal);
                param.Add("@IsPresenter", user.IsPresenter);
                var result = con.Execute("InsertUpdateUser", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);

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

        public List<Core.Users.User> GetExPreUserList(int Option = 0)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = "";
                if (Option == 1)
                {
                    sql = @"SELECT * FROM Users WHERE IsExternal = 1;";
                }
                else if(Option == 2)
                {
                    sql = @"SELECT * FROM Users WHERE IsPresenter = 1;";
                }
                else if (Option == 3)
                {
                    sql = @"SELECT * FROM Users WHERE (IsExternal = 0 AND IsPresenter = 0);";
                }
                else if (Option == 4)
                {
                    sql = @"SELECT U1.*,U2.DisplayName As Manager FROM Users U1 
                            LEFT JOIN Users U2 ON U2.Id = U1.ManagerId 
                            WHERE U1.IsExternal = 0;";
                }
                else
                {
                    sql = @"SELECT * FROM Users WHERE (IsExternal = 1 AND IsPresenter = 1);";
                }
                var ret = con.Query<Core.Users.User>(sql, null, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
        public int UpdateUserToPresenter(Core.Users.User User)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
                {
                    con.Open();
                    SqlTransaction sqltrans = con.BeginTransaction();
                    var paramUserCalendar = new DynamicParameters();
                    string sql = "";
                    if(User.IsPresenter)
                    {
                        sql = "UPDATE Users SET IsPresenter = 1 WHERE Id = " + User.Id;
                    }
                    else
                    {
                        sql = "UPDATE Users SET IsPresenter = 0 WHERE Id = " + User.Id;
                    }
                    var resultUser= con.Execute(sql, null, sqltrans, 0, System.Data.CommandType.Text);

                    if (resultUser > 0)
                    {
                        sqltrans.Commit();
                    }
                    else
                    {
                        sqltrans.Rollback();
                    }
                    return resultUser;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteUser(Core.Users.User User)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
                {
                    con.Open();
                    SqlTransaction sqltrans = con.BeginTransaction();
                    var paramUserCalendar = new DynamicParameters();
                    string sql = "DELETE FROM Users WHERE Id = " + User.Id;
                    var resultUser = con.Execute(sql, null, sqltrans, 0, System.Data.CommandType.Text);

                    if (resultUser > 0)
                    {
                        sqltrans.Commit();
                    }
                    else
                    {
                        sqltrans.Rollback();
                    }
                    return resultUser;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
