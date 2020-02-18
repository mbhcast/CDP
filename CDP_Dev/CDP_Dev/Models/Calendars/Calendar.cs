using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CDP_Dev.Models.Calendars
{
    public class Calendar
    {
        public int Id { get; set; }
        public int TrainingId { get; set; }
        public int PresenterId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StartDatestr { get; set; }
        public string EndDatestr { get; set; }
        public List<int> Attendees { get; set; }
    }
}
