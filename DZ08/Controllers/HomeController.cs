using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using static DataLibrary.BusinessLogic.UserProcessor;
using DZ08.Models;

namespace DZ08.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Facebook Sing Up - Domaći Zadatak 08";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserModels model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateUser(model.FirstName, model.LastName, model.Email, model.Password, model.BirthDate, model.Gender);
                return RedirectToAction("Users");
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Users()
        {
            ViewBag.Message = "List of Users";
            var data = LoadUsers();
            List<UserModels> users = new List<UserModels>();

            foreach (var row in data)
            {
                users.Add(new UserModels
                {
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    Email = row.EmailAddress,
                    Password = row.Password,
                    BirthDate = row.BirthDay,
                    Gender = row.Gender
                });
            }

            return View(users);
        }
    }
}