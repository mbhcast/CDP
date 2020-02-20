using CDP.Core.Allocations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Service.Allocations
{
    public interface IAllocation
    {
        int InsertAllocation(Allocation Allocation);
        int InsertUserAllocation(UserAllocation UserAllocation);
        List<Allocation> GetAllocationList();
        List<UserAllocation> GetUserAllocationList(int UserId);
        List<Allocation> GetUserAllocationNotMappedList(int UserId);
        List<UserAllocation> GetUserAllocationNotMarkedList(int UserId);
        Allocation GetSingleAllocation(int Id);
        UserAllocation GetSingleUserAllocation(int Id);
        int UpdateUserAllocation(UserAllocation UserAllocation);
        int UpdateAllocation(Allocation Allocation);
        int DeleteUserAllocation(int Id);
        int DeleteAllocation(int Id);
    }
}
