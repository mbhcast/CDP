using CDP.Core.Aspirations;
using System.Collections.Generic;

namespace CDP.Service.Aspirations
{
    public interface IAspiration
    {
        int InsertUserAspiration(UserAspiration UserAspiration);
        int UpdateUserAspiration(UserAspiration UserAspiration);
        int DeleteUserAspiration(int Id);
        List<UserAspiration> GetUserAspirationList(int UserId = 0);
        UserAspiration GetSingleUserAspiration(int Id);
    }
}
