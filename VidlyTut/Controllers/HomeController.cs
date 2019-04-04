using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemporaryRepository;
using VidlyTut.Models;

namespace VidlyTut.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LogModel logModel)
        {
            TempRepo repo = new TempRepo();
            var checkUser = repo.GetUser(logModel.UserName, logModel.Password);

            if (checkUser)
                ViewBag.Status = checkUser;
            else
                ViewBag.Status = checkUser;

            return View("Index");
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}