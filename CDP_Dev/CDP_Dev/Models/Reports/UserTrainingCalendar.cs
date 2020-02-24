using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDP_Dev.Models.Reports
{
    public class UserTrainingCalendar
    {
        public string IsPrimary { get; set; }
        public string Training { get; set; }
        public string TrainingCategory { get; set; }
        public string Priority { get; set; }
        public string Presenter { get; set; }
        public string Status { get; set; }
        public string Color { get; set; }
    }
}
