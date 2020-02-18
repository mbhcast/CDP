using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDP.Core.Internals;
using CDP.Service.Internals;
using CDP.Service.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CDP_Dev.Controllers
{
    [Authorize]
    public class InternalController : Controller
    {
        IInternal _IInternal;
        IUser _IUser;

        public InternalController(IInternal iinternal, IUser iuser)
        {
            _IInternal = iinternal;
            _IUser = iuser;
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete(int Id)
        {
            var Internal = _IInternal.GetSingleInternal(Id);
            return View(Internal);
        }
        public IActionResult DeleteUserInternal(int Id)
        {
            var Internal = _IInternal.GetSingleUserInternal(Id);
            return View(Internal);
        }
        public IActionResult CreateUserInternal()
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            ViewBag.InternalList = _IInternal.GetInternalList();
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Edit(int Id)
        {
            var Internal = _IInternal.GetSingleInternal(Id);
            return View(Internal);
        }
        public IActionResult EditUserInternal(int Id)
        {
            
            var userAllocation = _IInternal.GetSingleUserInternal(Id);
            ViewBag.InternalList = _IInternal.GetInternalList();
            //ViewBag.AllocationList = _IInternal.GetAllocationList();
            return View(userAllocation);
        }
        public IActionResult UserInternal()
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Internal Internal)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _IInternal.InsertInternal(Internal);
                    return RedirectToAction("List");
                }
                return View(Internal);
            }
            catch(Exception ex)
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult CreateUserInternal(UserInternal UserInternal)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _IInternal.InsertUserInternal(UserInternal);
                    return RedirectToAction("List");
                }
                return View(UserInternal);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public IActionResult LoadInternalData()
        {
            try
            {
                var InternalList = _IInternal.GetInternalList().AsEnumerable();
                var internalData = InternalList;

                //total number of rows counts   
                var recordsTotal = internalData.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = internalData });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadUserInternalData(int Id)
        {
            try
            {
                var UserInternalList = _IInternal.GetUserInternalList(Id).AsEnumerable();

                //total number of rows counts   
                var recordsTotal = UserInternalList.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = UserInternalList });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadUserInternalNotMapped(int Id)
        {
            try
            {
                var InternalList = _IInternal.GetUserInternalNotMappedList(Id);
                //Returning Json Data  
                return Json(InternalList);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public IActionResult Edit(int id, Internal Internal)
        {
            try
            {
                _IInternal.UpdateInternal(Internal);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult EditUserInternal(int id, UserInternal UserInternal)
        {
            try
            {
                _IInternal.UpdateUserInternal(UserInternal);
                return RedirectToAction("UserInternal");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Delete(int id, Internal Internal)
        {
            try
            {
                _IInternal.DeleteInternal(Internal.Id);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult DeleteUserInternal(int id, UserInternal UserInternal)
        {
            try
            {
                _IInternal.DeleteUserInternal(UserInternal.Id);
                return RedirectToAction("UserInternal");
            }
            catch
            {
                return View();
            }
        }
    }
}