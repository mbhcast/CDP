using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDP.Core.Aspirations;
using CDP.Service.Aspirations;
using CDP.Service.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CDP_Dev.Controllers
{
    [Authorize]
    public class AspirationController : Controller
    {
        IAspiration _IAspiration;
        IUser _IUser;
        public AspirationController(IAspiration iaspiration, IUser iuser)
        {
            _IAspiration = iaspiration;
            _IUser = iuser;
        }
        public IActionResult List()
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            return View();
        }
        public IActionResult Edit(int Id)
        {
            var Aspiration = _IAspiration.GetSingleUserAspiration(Id);
            return View(Aspiration);
        }
        public IActionResult Delete(int Id)
        {
            var Aspiration = _IAspiration.GetSingleUserAspiration(Id);
            return View(Aspiration);
        }
        [HttpPost]
        public IActionResult Create(UserAspiration UserAspiration)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    UserAspiration.Id = 0;
                    _IAspiration.InsertUserAspiration(UserAspiration);
                    return RedirectToAction("List", new { UserId = UserAspiration.UserId });
                }
                return View(UserAspiration);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(int id, UserAspiration Aspiration)
        {
            try
            {
                _IAspiration.UpdateUserAspiration(Aspiration);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Delete(int id, UserAspiration Aspiration)
        {
            try
            {
                _IAspiration.DeleteUserAspiration(id);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        public IActionResult LoadUserAspirationData(int Id)
        {
            try
            {
                var UserAspirationList = _IAspiration.GetUserAspirationList(Id).AsEnumerable();

                //total number of rows counts   
                var recordsTotal = UserAspirationList.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = UserAspirationList });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}