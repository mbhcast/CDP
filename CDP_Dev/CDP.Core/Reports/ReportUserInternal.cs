using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Core.Reports
{
    public class ReportUserInternal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string User { get; set; }
        public int PeriodId { get; set; }
        public string Period { get; set; }
        public int UserInternalId { get; set; }
        public string UserInternal { get; set; }
        public string Comment { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public string Color { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
