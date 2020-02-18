using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Core.Calendars
{
    public class UserCalendar
    {
        public int Id { get; set; }
        public List<int> Attendees { get; set; }
        public int AttendeeId { get; set; }
        public string Attendee { get; set; }
        public int CalendarId { get; set; }
        public string Description { get; set; }
        public int TrainingId { get; set; }
        public string Training { get; set; }
        public int PresenterId { get; set; }
        public string Presenter { get; set; }
        public bool Attended { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Duration { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
