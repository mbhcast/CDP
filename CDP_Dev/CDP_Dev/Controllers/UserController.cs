using System;
using System.Linq;
using CDP.Core.Users;
using CDP.Service.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CDP_Dev.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        IUser _IUser;
        public UserController(IUser iuser)
        {
            _IUser = iuser;
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult ListExPre()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.ManagerList = _IUser.GetUserList();
            return View();
        }
        public IActionResult CreateExPre()
        {
            return View();
        }
        public IActionResult Edit(int Id)
        {
            var User = _IUser.GetUser(Id);
            ViewBag.ManagerList = _IUser.GetUserList();
            return View(User);
        }
        public IActionResult Delete(int Id)
        {
            var User = _IUser.GetUser(Id);
            return View(User);
        }
        public IActionResult DeleteExPre(int Id)
        {
            var User = _IUser.GetUser(Id);
            return View(User);
        }
        public IActionResult EditExPre(int Id)
        {
            var User = _IUser.GetUser(Id);
            return View(User);
        }
        public IActionResult LoadUserData(int Id)
        {
            try
            {
                var UserData = _IUser.GetUser(Id);  
                //Returning Json Data  
                return Json(new { data = UserData });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadAllUsers()
        {
            try
            {
                var UserList = _IUser.GetUserList().AsEnumerable();
                var recordsTotal = UserList.Count();
                //Returning Json Data  
                return Json(new { recordsTotal = recordsTotal, data = UserList });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadAllInternalUsers()
        {
            try
            {
                var UserList = _IUser.GetExPreUserList(4).AsEnumerable();
                var recordsTotal = UserList.Count();
                //Returning Json Data  
                return Json(new { recordsTotal = recordsTotal, data = UserList });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadAllUsersEx()
        {
            try
            {
                var UserList = _IUser.GetExPreUserList(1).AsEnumerable();
                var recordsTotal = UserList.Count();
                //Returning Json Data  
                return Json(new { recordsTotal = recordsTotal, data = UserList });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadAllUsersNotPre()
        {
            try
            {
                var UserList = _IUser.GetExPreUserList(3).AsEnumerable();
                var recordsTotal = UserList.Count();
                //Returning Json Data  
                return Json(new { recordsTotal = recordsTotal, data = UserList });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadUsersForTraining(int Id)
        {
            try
            {
                var UserList = _IUser.GetUserListForTraining(Id).AsEnumerable();
                var recordsTotal = UserList.Count();
                //Returning Json Data  
                return Json(new { recordsTotal = recordsTotal, data = UserList });
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _IUser.InsertUser(user);
                    return RedirectToAction("List");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult CreateExPre(User user)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _IUser.InsertUser(user);
                    return RedirectToAction("ExPreList");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(User User)
        {
            try
            {
                _IUser.UpdateUser(User);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Delete(User User)
        {
            try
            {
                _IUser.DeleteUser(User);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult DeleteExPre(User User)
        {
            try
            {
                _IUser.DeleteUser(User);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult UpdateUserToPresenter(int id, bool ispresenter)
        {
            try
            {
                bool success = false;
                User user = new CDP.Core.Users.User();
                user.Id = id;
                user.IsPresenter = ispresenter;
                int ret = _IUser.UpdateUserToPresenter(user);
                if (ret > 0)
                {
                    success = true;
                }
                return Json(new { success = success });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}