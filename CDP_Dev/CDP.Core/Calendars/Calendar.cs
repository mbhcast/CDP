using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDP.Core.Calendars
{
    public class Calendar
    {
        public int Id { get; set; }
        public int TrainingId { get; set; }
        public int PresentarId { get; set; }
        [Required(ErrorMessage = "Enter Description")]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StartDatestr { get; set; }
        public string EndDatestr { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
