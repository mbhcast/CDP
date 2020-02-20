using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Service.Reports
{
    public interface IReport
    {
        List<Core.Reports.ReportUserAllocation> GetUserAllocationReport(int UserId);
        List<Core.Reports.ReportUserInternal> GetUserInternalReport(int UserId);
        List<Core.Reports.ReportUserMentor> GetUserMentorReport(int UserId);
        int InsertReportUserAllocation(Core.Reports.ReportUserAllocation ReportUserAllocation);
        int InsertReportUserInternal(Core.Reports.ReportUserInternal ReportUserInternal);
        int InsertReportUserMentor(Core.Reports.ReportUserMentor ReportUserMentor);
    }
}
