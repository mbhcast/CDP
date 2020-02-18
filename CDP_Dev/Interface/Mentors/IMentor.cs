using CDP.Core.Mentors;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Service.Mentors
{
    public interface IMentor
    {
        int InsertUserMentor(UserMentor UserMentor);
        List<UserMentor> GetUserMentorList(int UserId);
        List<UserMentor> GetUserMentorNotMappedList(int UserId);
        UserMentor GetSingleUserMentor(int Id);
        int UpdateUserMentor(UserMentor UserMentor);
        int DeleteUserMentor(int Id);
    }
}
