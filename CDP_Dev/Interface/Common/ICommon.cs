using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Service.Common
{
    public interface ICommon
    {
        List<Core.Common.Priority> GetPriorityList();
    }
}
