using CDP.Core;
using CDP.Core.Calendars;
using CDP.Service.Calendars;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CDP.Data.Calendars
{
    public class Calendar : ICalendar
    {
        IOptions<ReadConfig> _ConnectionString;
        public Calendar(IOptions<ReadConfig> ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
        public List<Core.Calendars.Calendar> GetCalendarList()
        {
            throw new NotImplementedException();
        }

        public List<UserCalendar> GetUserCalendarList(int UserId = 0)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                var param = new DynamicParameters();
                param.Add("@UserId", UserId);
                var ret = con.Query<UserCalendar>("UserCalendarList", param, null, true, 0, System.Data.CommandType.StoredProcedure).ToList();
                return ret;
            }
        }

        public int InsertUserCalendar(UserCalendar UserCalendar)
        {
            try {
                using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
                {
                    con.Open();
                    SqlTransaction sqltrans = con.BeginTransaction();
                    var param = new DynamicParameters();
                    param.Add("@TrainingId", UserCalendar.TrainingId);
                    param.Add("@PresenterId", UserCalendar.PresenterId);
                    param.Add("@Description", UserCalendar.Description);
                    param.Add("@StartDate", UserCalendar.StartDate);
                    param.Add("@EndDate", UserCalendar.EndDate);
                    var result = con.Query<int>("INSERT INTO Calendar VALUES(@TrainingId,@PresenterId,@Description,@StartDate,@EndDate,getutcdate(),getutcdate()); SELECT CAST(SCOPE_IDENTITY() as int);", param, sqltrans, true, 0, System.Data.CommandType.Text).Single();

                    if (result > 0)
                    {
                        UserCalendar.CalendarId = result;
                        foreach (var v in UserCalendar.Attendees)
                        {
                            var paramUserCalendar = new DynamicParameters();
                            paramUserCalendar.Add("@AttendeeId", v);
                            paramUserCalendar.Add("@CalendarId", UserCalendar.CalendarId);
                            var resultCalendar = con.Query<int>("INSERT INTO User_Calendar VALUES(@AttendeeId,@CalendarId,getutcdate(),getutcdate(),0); SELECT CAST(SCOPE_IDENTITY() as int);", paramUserCalendar, sqltrans, true, 0, System.Data.CommandType.Text).Single();
                        }
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
        public List<UserCalendar> GetUserCalendar(int UserId)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            {
                string sql = @"SELECT UC.Id AS Id, C.Id AS CalendarId, C.Description, C.StartDate, C.EndDate, TM.Code, TM.Name AS Training, TC.Description AS TrainingCategory,U.Trigram, U.Name AS [Attendee], U1.Name AS [Presenter], *FROM [User_Calendar] UC 
                                LEFT JOIN [Calendar] C ON C.Id = UC.CalendarId
                                LEFT JOIN [TrainingMaster] TM ON TM.Id = C.TrainingId
                                LEFT JOIN [TrainingCategory] TC ON TC.Id = TM.TrainingCategoryId
                                LEFT JOIN [Users] U ON U.Id = UC.AttendeeId
                                LEFT JOIN [Users] U1 ON U1.Id = C.PresenterId;";
                var param = new DynamicParameters();
                var ret = con.Query<UserCalendar>(sql, param, null, true, 0, System.Data.CommandType.Text).ToList();
                return ret;
            }
        }
        public int UserCalendarMarkAttendance(UserCalendar UserCalendar)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
                {
                    con.Open();
                    SqlTransaction sqltrans = con.BeginTransaction();
                    StringBuilder Attendee = new StringBuilder();
                    Attendee.Append("(");
                    foreach (var v in UserCalendar.Attendees)
                    {
                        Attendee.Append(v + ",");
                    }
                    Attendee.Remove(Attendee.Length - 1, 1);
                    Attendee.Append(")");
                    var paramUserCalendar = new DynamicParameters();
                    //paramUserCalendar.Add("@AttendeeId", Attendee.ToString());
                    //paramUserCalendar.Add("@CalendarId", UserCalendar.CalendarId);
                    string sql = "UPDATE User_Calendar SET Attended = 1 WHERE CalendarId = " + UserCalendar.CalendarId + " AND AttendeeId IN " + Attendee.ToString();
                    var resultCalendar = con.Execute(sql, null, sqltrans, 0, System.Data.CommandType.Text);

                    if (resultCalendar > 0)
                    {
                        sqltrans.Commit();
                    }
                    else
                    {
                        sqltrans.Rollback();
                    }
                    return resultCalendar;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
