using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDP.Core.Mentors;
using CDP.Service.Mentors;
using CDP.Service.Training;
using CDP.Service.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CDP_Dev.Controllers
{
    [Authorize]
    public class MentorController : Controller
    {
        ITraining _ITraining;
        IUser _IUser;
        IMentor _IMentor;
        public MentorController(ITraining itraining, IUser iuser, IMentor imentor)
        {
            _ITraining = itraining;
            _IUser = iuser;
            _IMentor = imentor;
        }
        public IActionResult Create()
        {
            ViewBag.TrainingCategoryList = _ITraining.GetTrainingCategotyList();
            ViewBag.UserList = _IUser.GetInternalUserList();
            ViewBag.AllUserList = _IUser.GetUserList();
            return View();
        }
        public IActionResult DeleteUserMentor(int Id)
        {
            var UserMwntor= _IMentor.GetSingleUserMentor(Id);
            return View(UserMwntor);
        }
        public IActionResult UserMentor()
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            ViewBag.AllUserList = _IUser.GetUserList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserMentor usermentor)
        {
            try
            {
                _IMentor.InsertUserMentor(usermentor);
                return RedirectToAction("UserMentor");
            }
            catch(Exception ex)
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult DeleteUserMentor(int Id, UserMentor usermentor)
        {
            try
            {
                _IMentor.DeleteUserMentor(usermentor.Id);
                return RedirectToAction("UserMentor");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public IActionResult EditUserMentor(int id, int UserId)
        {
            ViewBag.User = _IUser.GetUser(UserId);
            var UserMentor = _IMentor.GetSingleUserMentor(id);
            ViewBag.TrainingCategoryList = _ITraining.GetTrainingCategotyList();
            ViewBag.UserList = _IUser.GetInternalUserList();
            ViewBag.AllUserList = _IUser.GetUserList();
            return View(UserMentor);
        }
        public IActionResult LoadUserMentorData(int Id)
        {
            try
            {
                var UserMentorList = _IMentor.GetUserMentorList(Id).AsEnumerable();
                var usermentorData = UserMentorList;

                //total number of rows counts   
                var recordsTotal = usermentorData.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = usermentorData });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}