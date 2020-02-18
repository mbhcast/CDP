using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CDP_Dev.Models;
using System.Text;
using CDP.Service.Users;
using CDP.Service.Training;
using Microsoft.AspNetCore.Authorization;
using CDP_Dev.PdfProvider;
using CDP_Dev.PdfProvider.DataModel;
using System.IO;
using CDP.Service.Mentors;
using CDP.Service.Allocations;
using CDP.Service.Internals;
using CDP.Service.Aspirations;
using CDP.Service.Logs;
using CDP.Core.Logs;
using AspNetCorePdf.PdfProvider;
using System.Text.RegularExpressions;

namespace CDP_Dev.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        IUser _IUser;
        ITraining _ITraining;
        IMentor _IMentor;
        IAllocation _IAllocation;
        IInternal _IInternal;
        IAspiration _IAspiration;
        ILog _ILog;
        private readonly IPdfSharpService _pdfService;
        private readonly IMigraDocService _migraDocService;
        public HomeController(IUser iuser, ITraining itraining, 
            IPdfSharpService pdfService, IMentor mentor, 
            IInternal iinternal, IAllocation allocation,
            IAspiration aspiration, ILog log,
            IMigraDocService migraDocService)
        {
            _IUser = iuser;
            _ITraining = itraining;
            _pdfService = pdfService;
            _IMentor = mentor;
            _IInternal = iinternal;
            _IAllocation = allocation;
            _IAspiration = aspiration;
            _ILog = log;
            _migraDocService = migraDocService;
        }
        [HttpGet]
        public FileStreamResult CreateMigraDocPdf(int Id)
        {
            try
            {
                var mentor = _IMentor.GetUserMentorList(Id);
                var user = _IUser.GetUser(Id);
                var aspiration = _IAspiration.GetUserAspirationList(Id);
                var allocation = _IAllocation.GetUserAllocationList(Id);
                var iinternal = _IInternal.GetUserInternalList(Id);
                var training = _ITraining.GetUserTrainingList(Id);

                var data = new PdfData
                {
                    DocumentTitle = "CDP for " + user.Name,
                    DocumentName = "CDP - " + Regex.Replace(user.Name, @"\t|\n|\r", ""),
                    CreatedBy = "system",
                    Description = "Career Development Plan",
                    DisplayListItems = new List<ItemsToDisplay>
                {
                    new ItemsToDisplay{ Id = "Print Servers", Data1= "some data", Data2 = "more data to display"},
                    new ItemsToDisplay{ Id = "Network Stuff", Data1= "IP4", Data2 = "any left"},
                    new ItemsToDisplay{ Id = "Job details", Data1= "too many", Data2 = "say no"},
                    new ItemsToDisplay{ Id = "Firewall", Data1= "what", Data2 = "Let's burn it"}

                },
                    User = user,
                    Training = training,
                    Allocation = allocation,
                    Aspiration = aspiration,
                    IInternal = iinternal,
                    Mentor = mentor
                };
                var path = _migraDocService.CreateMigraDocPdf(data);

                var stream = new FileStream(path, FileMode.Open);
                return File(stream, "application/pdf");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public FileStreamResult CreatePdf(int Id)
        {
            Log l = new Log();
            try
            {


                var mentor = _IMentor.GetUserMentorList(Id);
                var user = _IUser.GetUser(Id);
                var aspiration = _IAspiration.GetUserAspirationList(Id);
                var allocation = _IAllocation.GetUserAllocationList(Id);
                var iinternal = _IInternal.GetUserInternalList(Id);
                var training = _ITraining.GetUserTrainingList(Id);
                var data = new PdfData
                {
                    DocumentTitle = "Career Development Plan",
                    DocumentName = "CDP",
                    CreatedBy = "Automatic generated file",
                    //Description = "some data description which I have, and want to display in the PDF file..., This is another text, what is happening here, why is this text display...",
                    Description = "some data description ...",
                    DisplayListItems = new List<ItemsToDisplay>
                {
                    new ItemsToDisplay { Id = "Print Servers", Data1 = "some data", Data2 = "more data to display" },
                    new ItemsToDisplay { Id = "Network Stuff", Data1 = "IP4", Data2 = "any left" },
                    new ItemsToDisplay { Id = "Job details", Data1 = "too many", Data2 = "say no" },
                    new ItemsToDisplay { Id = "Firewall", Data1 = "what", Data2 = "Let's burn it" }

                },
                    User = user,
                    Training = training,
                    Allocation = allocation,
                    Aspiration = aspiration,
                    IInternal = iinternal,
                    Mentor = mentor
                };

                var path = _pdfService.CreatePdf(data);
                l.CreatedOn = System.DateTime.UtcNow;
                l.ShortDescription = "Calling Log";
                l.FullDescription = "Called Service";
                _ILog.InsertLog(l);
                var stream = new FileStream(path, FileMode.Open);
                //return new FileContentResult(pdf, "application/pdf");
                return File(stream, "application/pdf");
            }
            catch(Exception ex)
            {
                l.CreatedOn = System.DateTime.UtcNow;
                l.ShortDescription = ex.Message;
                l.FullDescription = ex.InnerException.ToString();
                _ILog.InsertLog(l);
                throw ex;
            }
        }
        public IActionResult Index()
        {
            //PdfDocument document = new PdfDocument();
            //document.Info.Title = "Created with PDFsharp";

            //PdfPage page = document.AddPage();
            //XGraphics gfx = XGraphics.FromPdfPage(page);

            //XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            //gfx.DrawString("Hello, World!", font, XBrushes.Black,
            //new XRect(0, 0, page.Width, page.Height),

            //XStringFormats.Center);
            //const string filename = "HelloWorld.pdf";
            //document.Save(filename);

            ViewBag.UserList = _IUser.GetInternalUserList();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult LoadSampleData()
        {
            try
            {
                StringBuilder sbJson = new StringBuilder();
                sbJson.Append(@"[{""text"":""Primary Technical Skills"",""tags"": [""3""],""nodes"":[{""text"":""Onboarding Training"",""tags"": [""2""],""nodes"":[{""text"":""OT01 - Infrastructure Set up best practices""},{""text"":""OT02 - Sizing Recommendations""}]},{""text"":""Migration Training"",""tags"": [""2""],""nodes"":[{""text"":""MT01 - Pre-migration Study""},{""text"":""MT02 - Migration Pilot run""}]}, {""text"":""MISC Training"",""tags"": [""2""],""nodes"":[{""text"":""TT01 - Golden Nuggets""},{""text"":""TT07 - Onboarding Best practices""}]}]},{""text"":""Secondary Technical Skills"",""tags"": [""1""],""nodes"":[{""text"":""Technology Training"",""tags"": [""2""],""nodes"": [{""text"":""TG02 - Python""},{""text"":""TG04 - Jenkins""}]}]}]");

                //sbJson.Append("[");

                //for (int i = 0; i < 4; i++)
                //{
                //    sbJson.Append("{");
                //    sbJson.Append(@"""Text"": ");
                //    sbJson.Append(@"""" + "Parent" + i.ToString() + @"""");
                //    sbJson.Append("},");
                //}
                //sbJson.Remove(sbJson.Length - 1, 1);
                //sbJson.Append("]");

                //Returning Json Data
                return Json(new { treedata = sbJson.ToString() });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IActionResult LoadTrainingData(int Id)
        {
            try
            {
                StringBuilder sbJson = new StringBuilder();

                var UserTrainingList = _ITraining.GetUserTrainingList(Id).AsEnumerable();
                var Primary = UserTrainingList.Where(a => a.IsPrimary == true).OrderBy(a => a.TrainingCategory);
                var Secondary = UserTrainingList.Where(a => a.IsPrimary == false);
                sbJson.Append(@"[");
                if (Primary.Count() > 0)
                {
                    sbJson.Append(TrainingJsonString(Primary, "Primary Skills"));
                }
                if (Secondary.Count() > 0)
                {
                    if (Primary.Count() > 0)
                    {
                        sbJson.Append(",");
                    }
                    sbJson.Append(TrainingJsonString(Secondary, "Secondary Skills"));
                }
                //if (Primary.Count() > 0)
                //{
                //    sbJson.Append(@"{""text"":""Primary Skills"",""tags"": [""" + Primary.Count() + @"""],""nodes"":[");

                //    var vGroup = Primary.GroupBy(a => a.TrainingCategory);
                //    foreach (var group in vGroup)
                //    {
                //        sbJson.Append(@"{""text"":""" + group.Key + @""",""tags"":[""" + group.Count() + @"""],""nodes"":[");
                //        foreach (var v in group)
                //        {
                //            sbJson.Append(@"{""text"":""" + v.TrainingCode + " - " + v.Training + @"""},");
                //        }
                //        sbJson.Remove(sbJson.Length - 1, 1);
                //        sbJson.Append("]");
                //        sbJson.Append("},");
                //    }
                //    sbJson.Remove(sbJson.Length - 1, 1);
                //    sbJson.Append("]");
                //    sbJson.Append("}");
                //}


                //if (Secondary.Count() > 0)
                //{
                //    if (Primary.Count() > 0)
                //    {
                //        sbJson.Append(",");
                //    }
                //    sbJson.Append(@"{""text"":""Secondary Skills"",""tags"": [""" + Secondary.Count() + @"""],""nodes"":[");

                //    var vGroup = Secondary.GroupBy(a => a.TrainingCategory);
                //    foreach (var group in vGroup)
                //    {
                //        sbJson.Append(@"{""text"":""" + group.Key + @""",""tags"":[""" + group.Count() + @"""],""nodes"":[");
                //        foreach (var v in group)
                //        {
                //            sbJson.Append(@"{""text"":""" + v.TrainingCode + " - " + v.Training + @"""},");
                //        }
                //        sbJson.Remove(sbJson.Length - 1, 1);
                //        sbJson.Append("]},");
                //    }
                //    sbJson.Remove(sbJson.Length - 1, 1);
                //    sbJson.Append("]");
                //    sbJson.Append("}");
                //}
                sbJson.Append("]");
                //Returning Json Data
                return Json(new { treedata = sbJson.ToString() });
            }
            catch (Exception)
            {
                throw;
            }
        }

        //private string TrainingJsonString(IEnumerable<CDP.Core.Training.UserTraining> UserTraining, String Key)
        //{
        //    StringBuilder sbJson = new StringBuilder();
        //    sbJson.Append(@"{""text"":""" + Key + @""",""tags"": [""" + UserTraining.Count() + @"""],""nodes"":[");

        //    var vGroup = UserTraining.GroupBy(a => a.TrainingCategory);
        //    foreach (var group in vGroup)
        //    {
        //        sbJson.Append(@"{""text"":""" + group.Key + @""",""tags"":[""" + group.Count() + @"""],""nodes"":[");
        //        foreach (var v in group)
        //        {
        //            sbJson.Append(@"{""text"":""" + v.TrainingCode + " - " + v.Training + @"""},");
        //        }
        //        sbJson.Remove(sbJson.Length - 1, 1);
        //        sbJson.Append("]");
        //        sbJson.Append("},");
        //    }
        //    sbJson.Remove(sbJson.Length - 1, 1);
        //    sbJson.Append("]");
        //    sbJson.Append("}");

        //    return sbJson.ToString();
        //}

        private string TrainingJsonString(IEnumerable<CDP.Core.Training.UserTraining> UserTraining, String Key)
        {
            StringBuilder sbJson = new StringBuilder();
            sbJson.Append(@"{""text"":""" + Key + @""",""tags"": [""" + UserTraining.Count() + @"""],""nodes"":[");

            var vGroup = UserTraining.GroupBy(a => a.TrainingCategory);
            foreach (var group in vGroup)
            {
                sbJson.Append(@"{""text"":""" + group.Key + @""",""tags"":[""" + group.Count() + @"""],""nodes"":[");
                foreach (var v in group)
                {
                    string color = @"""color"":""";
                    if (v.PriorityId == 10)
                    {
                        color += "#d9534f";
                    }
                    if (v.PriorityId == 20)
                    {
                        color += "#d58512";
                    }
                    if (v.PriorityId == 30)
                    {
                        color += "#5cb85c";
                    }
                    color += @"""";
                    sbJson.Append(@"{""text"":""" + v.TrainingCode + " - " + v.Training + " - " + v.Priority + " Priority" + @"""," + color + "},");
                }
                sbJson.Remove(sbJson.Length - 1, 1);
                sbJson.Append("]");
                sbJson.Append("},");
            }
            sbJson.Remove(sbJson.Length - 1, 1);
            sbJson.Append("]");
            sbJson.Append("}");

            return sbJson.ToString();
        }
    }
}
