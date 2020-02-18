using CDP.Core.Logs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Service.Logs
{
    public interface ILog
    {
        int InsertLog(Log Log);
    }
}
