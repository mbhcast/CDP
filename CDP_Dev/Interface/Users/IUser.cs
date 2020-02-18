using CDP.Core.Users;
using System.Collections.Generic;

namespace CDP.Service.Users
{
    public interface IUser
    {
        List<User> GetUserList();
        List<Core.Users.User> GetInternalUserList();
        List<User> GetUserListForTraining(int TrainingId);
        User GetUser(int Id);
        int InsertUser(Core.Users.User user);
        int UpdateUser(Core.Users.User user);
        int DeleteUser(Core.Users.User User);
        List<User> GetExPreUserList(int Option = 0);
        int UpdateUserToPresenter(Core.Users.User User);
    }
}
