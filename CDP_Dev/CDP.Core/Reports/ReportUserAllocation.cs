using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Core.Reports
{
    public class ReportUserAllocation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string User { get; set; }
        public int PeriodId { get; set; }
        public string Period { get; set; }
        public int UserAllocationId { get; set; }
        public string UserAllocation { get; set; }
        public string Comment { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public string Color { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
