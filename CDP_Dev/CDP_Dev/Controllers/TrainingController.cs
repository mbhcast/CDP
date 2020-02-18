using CDP.Core.Training;
using CDP.Service.Common;
using CDP.Service.Training;
using CDP.Service.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDP_Dev.Controllers
{
    [Authorize]
    public class TrainingController : Controller
    {
        ITraining _ITraining;
        IUser _IUser;
        ICommon _ICommon;
        public TrainingController(ITraining itraining, IUser iuser, ICommon icommon)
        {
            _ITraining = itraining;
            _IUser = iuser;
            _ICommon = icommon;
        }
        public IActionResult Index()
        {
            var TrainingCategotyList = _ITraining.GetTrainingCategotyList();
            return View(TrainingCategotyList);
        }
        public IActionResult LoadDataServer()
        {
            try
            {
                var TrainingCategotyList = _ITraining.GetTrainingCategotyList().AsEnumerable();

                int recordsTotal = 0;
                IEnumerable<TrainingCategory> filteredTrainingCategory = TrainingCategotyList;

                // getting all Customer data  
                var trainingcategoryData = filteredTrainingCategory;

                //total number of rows counts   
                recordsTotal = trainingcategoryData.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = trainingcategoryData });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadTrainingCategoryData()
        {
            try
            {
                var TrainingCategotyList = _ITraining.GetTrainingCategotyList().AsEnumerable();

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
        public IActionResult LoadTrainingMasterData()
        {
            try
            {
                var TrainingMasterList = _ITraining.GetTrainingMasterList().AsEnumerable();

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
        public IActionResult LoadPriority()
        {
            try
            {
                var PriorityList = _ICommon.GetPriorityList().AsEnumerable();

                //total number of rows counts   
                var recordsTotal = PriorityList.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = PriorityList });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadUserTrainingData(int Id)
        {
            try
            {
                var UserTrainingList = _ITraining.GetUserTrainingList(Id).AsEnumerable();

                var usertrainingData = UserTrainingList;

                //total number of rows counts   
                var recordsTotal = usertrainingData.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = usertrainingData });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadUniqueUserTrainingData()
        {
            try
            {
                var UniqueUserTrainingList = _ITraining.GetUniqueUserTrainingList().AsEnumerable();

                //total number of rows counts   
                var recordsTotal = UniqueUserTrainingList.Count();
                //Returning Json Data  
                return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = UniqueUserTrainingList });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult LoadUserTrainingNotMapped(int Id)
        {
            try
            {
                var TrainingList = _ITraining.GetUserTrainingNotMappedList(Id);
                //Returning Json Data  
                return Json(TrainingList);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult TrainingList()
        {
            var TrainingMasterList = _ITraining.GetTrainingMasterList();
            return View(TrainingMasterList);
        }
        public IActionResult UserTraining()
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            //var TrainingMasterList = _ITraining.GetTrainingMasterList();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateTrainingMaster()
        {
            ViewBag.TrainingCategoryList = _ITraining.GetTrainingCategotyList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateTrainingMaster(TrainingMaster TrainingMaster)
        {
            try
            {
                _ITraining.InsertTrainingMaster(TrainingMaster);
                return RedirectToAction("TrainingList");
            }
            catch(Exception ex)
            {
                return View();
            }
        }
        public IActionResult CreateUserTraining(int Id)
        {
            ViewBag.UserList = _IUser.GetInternalUserList();
            //ViewBag.TrainingMasterList = _ITraining.GetUserTrainingNotMappedList(Id);
            return View();
        }
        public IActionResult EditUserTraining(int Id, int UserId)
        {
            var UserTraining = _ITraining.GetSingleUserTraining(Id);
            ViewBag.User = _IUser.GetUser(UserId);
            ViewBag.TrainingMasterList = _ITraining.GetUserTrainingNotMappedList(Id);
            ViewBag.PriorityList = _ICommon.GetPriorityList();
            return View(UserTraining);
        }
        [HttpPost]
        public IActionResult EditUserTraining(int id, UserTraining UserTraining)
        {
            try
            {
                _ITraining.UpdateUserTraining(UserTraining);
                return RedirectToAction("UserTraining");
            }
            catch
            {
                return View();
            }
        }
        public IActionResult MapUserTraining(int Id)
        {
            ViewBag.User = "User";
            ViewBag.TrainingMasterList = _ITraining.GetUserTrainingNotMappedList(Id);
            return View();
        }
        [HttpPost]
        public IActionResult Create(TrainingCategory TrainingCategory)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _ITraining.InsertTrainingCategory(TrainingCategory);
                    return RedirectToAction("Index");
                }
                return View(TrainingCategory);
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult CreateUserTraining(UserTraining UserTraining)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    _ITraining.InsertUserTraining(UserTraining);
                    return RedirectToAction("UserTraining", new { UserId = UserTraining.UserId });
                }
                return View(UserTraining);
            }
            catch
            {
                return View();
            }
        }
        public IActionResult Edit(int id)
        {
            var TrainingCategory = _ITraining.GetSingleTrainingCategory(id);
            return View(TrainingCategory);
        }

        [HttpPost]
        public IActionResult Edit(int id, TrainingCategory TrainingCategory)
        {
            try
            {
                // TODO: Add update logic here
                _ITraining.UpdateTrainingCategory(TrainingCategory);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Delete(int id, TrainingCategory TrainingCategory)
        {
            try
            {
                // TODO: Add update logic here
                _ITraining.DeleteTrainingCategory(TrainingCategory.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult DeleteTrainingMaster(int id, TrainingMaster TrainingMaster)
        {
            try
            {
                // TODO: Add update logic here
                _ITraining.DeleteTrainingMaster(TrainingMaster.Id);
                return RedirectToAction("TrainingList");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult DeleteUserTraining(int id, UserTraining UserTraining)
        {
            try
            {
                // TODO: Add update logic here
                _ITraining.DeleteUserTraining(UserTraining.Id);
                return RedirectToAction("UserTraining");
            }
            catch
            {
                return View();
            }
        }
        public IActionResult EditTrainingMaster(int id)
        {
            var TrainingMaster = _ITraining.GetSingleTrainingMaster(id);
            ViewBag.TrainingCategoryList = _ITraining.GetTrainingCategotyList();
            return View(TrainingMaster);
        }

        [HttpPost]
        public IActionResult EditTrainingMaster(int id, TrainingMaster TrainingMaster)
        {
            try
            {
                _ITraining.UpdateTrainingMaster(TrainingMaster);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public IActionResult Delete(int id)
        {
            var Product = _ITraining.GetSingleTrainingCategory(id);
            return View(Product);
        }
        public IActionResult DeleteTrainingMaster(int id)
        {
            var Product = _ITraining.GetSingleTrainingMaster(id);
            return View(Product);
        }
        public IActionResult DeleteUserTraining(int id)
        {
            var UserTraining = _ITraining.GetSingleUserTraining(id);
            return View(UserTraining);
        }
    }
}
