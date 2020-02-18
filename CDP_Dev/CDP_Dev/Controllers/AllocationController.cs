using CDP.Core.Allocations;
using CDP.Service.Allocations;
using CDP.Service.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CDP_Dev.Controllers
{
    [Authorize]
    public class AllocationController : Controller
    {
        IAllocation _IAllocation;
        IUser _IUser;

        public AllocationController(IAllocation iallocation, IUser iuser)
        {
            _IAllocation = iallocation;
            _IUser = iuser;
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateUserAllocation()
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            return View();
        }
        public IActionResult Edit(int Id)
        {
            var Allocation = _IAllocation.GetSingleAllocation(Id);
            return View(Allocation);
        }
        public IActionResult EditUserAllocation(int Id)
        {
            var userAllocation = _IAllocation.GetSingleUserAllocation(Id);
            ViewBag.AllocationList = _IAllocation.GetAllocationList();
            return View(userAllocation);
        }
        public IActionResult Delete(int Id)
        {
            var Allocation = _IAllocation.GetSingleAllocation(Id);
            return View(Allocation);
        }
        public IActionResult DeleteUserAllocation(int Id)
        {
            var userAllocation = _IAllocation.GetSingleUserAllocation(Id);
            return View(userAllocation);
        }
        [HttpPost]
        public IActionResult CreateUserAllocation(UserAllocation UserAllocation)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    UserAllocation.Id = 0;
                    _IAllocation.InsertUserAllocation(UserAllocation);
                    return RedirectToAction("UserAllocation", new { UserId = UserAllocation.UserId });
                }
                return View(UserAllocation);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(int id, Allocation Allocation)
        {
            try
            {
                _IAllocation.UpdateAllocation(Allocation);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult EditUserAllocation(int id, UserAllocation UserAllocation)
        {
            try
            {
                _IAllocation.UpdateUserAllocation(UserAllocation);
                return RedirectToAction("UserAllocation");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Delete(int id, Allocation Allocation)
        {
            try
            {
                _IAllocation.DeleteAllocation(Allocation.Id);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult DeleteUserAllocation(int id, UserAllocation UserAllocation)
        {
            try
            {
                _IAllocation.DeleteUserAllocation(UserAllocation.Id);
                return RedirectToAction("UserAllocation");
            }
            catch
            {
                return View();
            }
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult UserAllocation()
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Allocation Allocation)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _IAllocation.InsertAllocation(Allocation);
                    return RedirectToAction("List");
                }
                return View(Allocation);
            }
            catch
            {
                return View();
            }
        }
        public IActionResult LoadAllocationData()
        {
            try
            {
                var AllocationList = _IAllocation.GetAllocationList().AsEnumerable();

                var allocationData = AllocationList;

                //total number of rows counts   
                var recordsTotal = allocationData.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = allocationData });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadUserAllocationData(int Id)
        {
            try
            {
                var UserAllocationList = _IAllocation.GetUserAllocationList(Id).AsEnumerable();

                //total number of rows counts   
                var recordsTotal = UserAllocationList.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = UserAllocationList });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadUserAllocationNotMapped(int Id)
        {
            try
            {
                var AllocationList = _IAllocation.GetUserAllocationNotMappedList(Id);
                //Returning Json Data  
                return Json(AllocationList);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}