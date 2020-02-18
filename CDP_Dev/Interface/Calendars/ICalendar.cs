using CDP.Core.Calendars;
using System.Collections.Generic;

namespace CDP.Service.Calendars
{
    public interface ICalendar
    {
        int InsertUserCalendar(UserCalendar UserCalendar);
        List<Calendar> GetCalendarList();
        List<UserCalendar> GetUserCalendarList(int UserId = 0);
        List<UserCalendar> GetUserCalendar(int UserId = 0);
        int UserCalendarMarkAttendance(UserCalendar UserCalendar);
    }
}
