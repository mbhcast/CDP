using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDP.Core.Skills;
using CDP.Service.Skills;
using CDP.Service.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CDP_Dev.Controllers
{
    [Authorize]
    public class SkillController : Controller
    {
        ISkill _ISkill;
        IUser _IUser;

        public SkillController(ISkill iskill, IUser iuser)
        {
            _ISkill = iskill;
            _IUser = iuser;
        }
        public IActionResult CreateSkillType()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkillType(SkillType SkillType)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _ISkill.InsertSkillType(SkillType);
                    return RedirectToAction("SkillTypeList");
                }
                return View(SkillType);
            }
            catch
            {
                return View();
            }
        }
        public IActionResult CreateSkill()
        {
            ViewBag.SkillTypeList = _ISkill.GetSkillTypeList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkill(Skill Skill)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _ISkill.InsertSkill(Skill);
                    return RedirectToAction("SkillList");
                }
                return View(Skill);
            }
            catch
            {
                return View();
            }
        }
        public IActionResult CreateUserSkill(int Id)
        {
            ViewBag.UserList = _IUser.GetUserList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateUserSkill(UserSkill UserSkill)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UserSkill.Id = 0;
                    _ISkill.InsertUserSkill(UserSkill);
                    return RedirectToAction("UserSkill", new { UserId = UserSkill.UserId });
                }
                return View(UserSkill);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SkillTypeList()
        {
            return View();
        }
        public IActionResult SkillList()
        {
            return View();
        }
        public IActionResult UserSkill()
        {
            ViewBag.UserList = _IUser.GetUserList();
            return View();
        }
        public IActionResult LoadSkillTypeData()
        {
            try
            {
                var TrainingCategotyList = _ISkill.GetSkillTypeList().AsEnumerable();

                var trainingcategoryData = TrainingCategotyList;

                //total number of rows counts   
                var recordsTotal = trainingcategoryData.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = trainingcategoryData });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadSkillData()
        {
            try
            {
                var TrainingMasterList = _ISkill.GetSkillList().AsEnumerable();

                var trainingmasterData = TrainingMasterList;

                //total number of rows counts   
                var recordsTotal = trainingmasterData.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = trainingmasterData });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadUserSkillData(int Id)
        {
            try
            {
                var UserSkillList = _ISkill.GetUserSkillList(Id).AsEnumerable();

                var userskillData = UserSkillList;

                //total number of rows counts   
                var recordsTotal = userskillData.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = userskillData });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadUserSkillNotMapped(int Id)
        {
            try
            {
                var SkillList = _ISkill.GetUserSkillNotMappedList(Id);
                //Returning Json Data  
                return Json(SkillList);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}