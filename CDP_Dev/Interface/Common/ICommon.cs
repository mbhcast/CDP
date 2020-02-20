using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Service.Common
{
    public interface ICommon
    {
        List<Core.Common.Priority> GetPriorityList();
        List<Core.Common.Period> GetPeriodList();
        List<Core.Common.Status> GetStatusList();
        List<Core.Common.Period> GetNotMarkedPeriodForUserAllocation(int UserAllocationId, int UserId);
        List<Core.Common.Period> GetNotMarkedPeriodForUserInternal(int UserInternalId, int UserId);
        List<Core.Common.Period> GetNotMarkedPeriodForUserMentor(int UserMentorId, int UserId);
    }
}
