using CDP.Core.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Service.Internals
{
    public interface IInternal
    {
        int InsertInternal(Internal Internal);
        int InsertUserInternal(UserInternal UserInternal);
        List<Internal> GetInternalList();
        List<UserInternal> GetUserInternalList(int UserId);
        List<Internal> GetUserInternalNotMappedList(int UserId);
        int UpdateUserInternal(UserInternal UserInternal);
        int UpdateInternal(Internal Internal);
        int DeleteUserInternal(int Id);
        int DeleteInternal(int Id);
        Core.Internals.Internal GetSingleInternal(int Id);
        UserInternal GetSingleUserInternal(int Id);
    }
}
