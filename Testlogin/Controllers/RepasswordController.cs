using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Testlogin.Models;
using Testlogin.ServiceReference1;

namespace Testlogin.Controllers
{
    public class RepasswordController : Controller
    {
        Service1Client sv = new Service1Client();
        // GET: Repassword
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Repassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Repassword(ServiceReference1.RepasswordViewModel model)
        {
            model.username = Session["userid"].ToString();
            if (model.Password != null && model.NewPassword != null && model.ConfirmPassword != null)
            {
               if (model.Password.Equals(Session["pass"].ToString()))
               {
                   sv.Repass(model);
                   return RedirectToAction("Login", "Home");
               }
               else
               {
                  ModelState.AddModelError("","Password is wrong");
               }
            }
            
            return View();
        }
    }
}