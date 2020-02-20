using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDP.Core.Reports;
using CDP.Service.Common;
using CDP.Service.Reports;
using CDP.Service.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CDP_Dev.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        IUser _IUser;
        IReport _IReport;
        ICommon _ICommon;
        public ReportController(IReport ireport, IUser iuser, ICommon icommon)
        {
            _IReport = ireport;
            _IUser = iuser;
            _ICommon = icommon;
        }
        public IActionResult Index()
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            return View();
        }
        public IActionResult MarkUserAllocation()
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            ViewBag.StatusList = _ICommon.GetStatusList();
            return View();
        }
        public IActionResult MarkUserInternal()
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            ViewBag.StatusList = _ICommon.GetStatusList();
            return View();
        }
        public IActionResult MarkUserMentor()
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            ViewBag.StatusList = _ICommon.GetStatusList();
            return View();
        }
        //public IActionResult LoadUserAllocationReport(int Id, int PeriodId)
        //{
        //    try
        //    {
        //        var UserAllocationList = _IReport.GetUserAllocationReport(Id, PeriodId);
        //        //Returning Json Data  
        //        //total number of rows counts   
        //        var recordsTotal = UserAllocationList.Count();
        //        //Returning Json Data  
        //        return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = UserAllocationList });
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        public IActionResult LoadUserAllocationReport(int Id)
        {
            try
            {
                var UserAllocationList = _IReport.GetUserAllocationReport(Id);
                //Returning Json Data  
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
        public IActionResult LoadUserInternalReport(int Id)
        {
            try
            {
                var UserInternalList = _IReport.GetUserInternalReport(Id);
                //Returning Json Data  
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
        public IActionResult LoadUserMentorReport(int Id)
        {
            try
            {
                var UserMentorList = _IReport.GetUserMentorReport(Id);
                //Returning Json Data  
                //total number of rows counts   
                var recordsTotal = UserMentorList.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = UserMentorList });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadNotMarkedAllocationPeriod(int Id, int UserId)
        {
            try
            {
                var PeriodList = _ICommon.GetNotMarkedPeriodForUserAllocation(Id, UserId);
                //Returning Json Data  
                return Json(PeriodList);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadNotMarkedInternalPeriod(int Id, int UserId)
        {
            try
            {
                var PeriodList = _ICommon.GetNotMarkedPeriodForUserInternal(Id, UserId);
                //Returning Json Data  
                return Json(PeriodList);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadNotMarkedMentorPeriod(int Id, int UserId)
        {
            try
            {
                var PeriodList = _ICommon.GetNotMarkedPeriodForUserMentor(Id, UserId);
                //Returning Json Data  
                return Json(PeriodList);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public IActionResult MarkUserAllocation(ReportUserAllocation Allocation)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _IReport.InsertReportUserAllocation(Allocation);
                    return RedirectToAction("Index");
                }
                return View(Allocation);
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult MarkUserInternal(ReportUserInternal Internal)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _IReport.InsertReportUserInternal(Internal);
                    return RedirectToAction("Index");
                }
                return View(Internal);
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult MarkUserMentor(ReportUserMentor Mentor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _IReport.InsertReportUserMentor(Mentor);
                    return RedirectToAction("Index");
                }
                return View(Mentor);
            }
            catch
            {
                return View();
            }
        }
    }
}