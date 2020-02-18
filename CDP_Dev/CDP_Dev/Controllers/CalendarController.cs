using System;
using System.Linq;
using System.Text;
using CDP.Core.Calendars;
using CDP.Service.Calendars;
using CDP.Service.Training;
using CDP.Service.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CDP_Dev.Controllers
{
    [Authorize]
    public class CalendarController : Controller
    {
        ICalendar _ICalendar;
        IUser _IUser;
        ITraining _ITraining;
        public CalendarController(ICalendar icalendar, IUser iuser, ITraining itraining)
        {
            _ICalendar = icalendar;
            _IUser = iuser;
            _ITraining = itraining;
        }
        public IActionResult Index()
        {
            ViewBag.UserList = _IUser.GetExPreUserList(2);
            ViewBag.TrainingList = _ITraining.GetUniqueUserTrainingList();
            return View();
        }
        //public IActionResult LoadCalendar()
        //{
        //    try
        //    {
        //        StringBuilder sbJson = new StringBuilder();

        //        var CalendarList = _ICalendar.GetUserCalendarList().GroupBy(a => new { a.CalendarId, a.PresenterId, a.Presenter, a.StartDate, a.EndDate, a.Training });
        //        sbJson.Append("[");
        //        if (CalendarList.Count() > 0)
        //        {
        //            foreach (var vAll in CalendarList)
        //            {
        //                //sbJson.Append(@"{""Id"":""" + vAll.Key.CalendarId + @""",""startDate"": new Date(2020, 1 , 1),""endDate"": new Date(2020, 1, 1),""startTime"": """ + vAll.Key.EndDate.ToString("HH:mm") + @""",""name"": """ + vAll.Key.Training + @""",""presenter"": """ + vAll.Key.Presenter + @""",""attendee"":""");
        //                //sbJson.Append(@"{""Id"":""" + vAll.Key.CalendarId + @""",""startDate"": new Date('" + vAll.Key.StartDate.ToString("yyyy-MM-dd") + @"'),""endDate"": new Date('" + vAll.Key.EndDate.ToString("yyyy-MM-dd") + @"'),""startTime"": """ + vAll.Key.EndDate.ToString("HH:mm") + @""",""name"": """ + vAll.Key.Training + @""",""presenter"": """ + vAll.Key.Presenter + @""",""attendee"":""");
        //                sbJson.Append(@"{""Id"":""" + vAll.Key.CalendarId + @""",""startDate"": """ + vAll.Key.StartDate.ToString("yyyy-MM-dd") + @""",""endDate"": """ + vAll.Key.EndDate.ToString("yyyy-MM-dd") + @""",""startTime"": """ + vAll.Key.StartDate.ToString("HH:mm") + @""",""name"": """ + vAll.Key.Training + @""",""presenter"": """ + vAll.Key.Presenter + @""",""attendee"":""");
        //                foreach (var v in vAll)
        //                {
        //                    sbJson.Append(@"" + v.Attendee + ", ");
        //                }
        //                sbJson.Remove(sbJson.Length - 2, 2);
        //                sbJson.Append(@"""},");
        //            }
        //            sbJson.Remove(sbJson.Length - 1, 1);
        //        }
        //        sbJson.Append("]");
        //        //Returning Json Data 
        //        return Json(new { caldata = sbJson.ToString() });

        //        //return Json(sbJson.ToString());
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        public IActionResult LoadCalendar()
        {
            try
            {
                StringBuilder sbJson = new StringBuilder();

                var CalendarList = _ICalendar.GetUserCalendarList().GroupBy(a => new { a.CalendarId, a.PresenterId, a.Presenter, a.StartDate, a.EndDate, a.Training });
                sbJson.Append("[");
                if (CalendarList.Count() > 0)
                {
                    foreach (var vAll in CalendarList)
                    {
                        sbJson.Append(@"{""Id"":""" + vAll.Key.CalendarId + @""",""startDate"": """ + vAll.Key.StartDate.ToString("yyyy-MM-dd") + @""",""endDate"": """ + vAll.Key.EndDate.ToString("yyyy-MM-dd") + @""",""startTime"": """ + vAll.Key.StartDate.ToString("HH:mm") + @""",""name"": """ + vAll.Key.Training + @""",""presenterid"": """ + vAll.Key.PresenterId + @""",""presenter"": """ + vAll.Key.Presenter + @""",""attendees"":[");
                        foreach (var v in vAll)
                        {
                            sbJson.Append(@"{""attendeeid"":""" + v.AttendeeId + @""", ""attended"":""" + v.Attended + @""", ""attendee"":""" + v.Attendee + @"""},");
                        }
                        sbJson.Remove(sbJson.Length - 1, 1);
                        sbJson.Append(@"]},");
                    }
                    sbJson.Remove(sbJson.Length - 1, 1);
                }
                sbJson.Append("]");
                //Returning Json Data 
                return Json(new { caldata = sbJson.ToString() });

                //return Json(sbJson.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public IActionResult PostDataJson([FromBody]UserCalendar cal)
        {
            try
            {
                bool success = false;
                //Adding to adjust UTC
                cal.StartDate = cal.StartDate.AddHours(5.5);
                cal.EndDate = cal.StartDate.AddHours(cal.Duration);
                int ret = _ICalendar.InsertUserCalendar(cal);
                if (ret > 0)
                {
                    success = true;
                }
                return Json(new { success = success } );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult PostAttendanceDataJson([FromBody]UserCalendar cal)
        {
            try
            {
                bool success = false;
                int ret = _ICalendar.UserCalendarMarkAttendance(cal);
                if (ret > 0)
                {
                    success = true;
                }
                return Json(new { success = success });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult PostData(string Test, string Text)
        {
            try
            {
                return Json(null);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadUserCalendar()
        {
            try
            {
                StringBuilder sbJson = new StringBuilder();

                var CalendarList = _ICalendar.GetUserCalendarList().GroupBy(a => new { a.CalendarId, a.PresenterId, a.Presenter, a.StartDate, a.EndDate, a.Training });
                sbJson.Append("[");
                if (CalendarList.Count() > 0)
                {
                    foreach (var vAll in CalendarList)
                    {
                        sbJson.Append(@"{""Id"":""" + vAll.Key.CalendarId + @""",""startDate"": """ + vAll.Key.StartDate.ToString("yyyy-MM-dd") + @""",""endDate"": """ + vAll.Key.EndDate.ToString("yyyy-MM-dd") + @""",""startTime"": """ + vAll.Key.StartDate.ToString("HH:mm") + @""",""name"": """ + vAll.Key.Training + @""",""presenterid"": """ + vAll.Key.PresenterId + @""",""presenter"": """ + vAll.Key.Presenter + @""",""attendees"":[");
                        foreach (var v in vAll)
                        {
                            sbJson.Append(@"{""attendeeid"":""" + v.AttendeeId + @""", ""attendee"":""" + v.Attendee + @"""},");
                        }
                        sbJson.Remove(sbJson.Length - 1, 1);
                        sbJson.Append(@"]},");
                    }
                    sbJson.Remove(sbJson.Length - 1, 1);
                }
                sbJson.Append("]");
                //Returning Json Data 
                return Json(new { caldata = sbJson.ToString() });

                //return Json(sbJson.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}