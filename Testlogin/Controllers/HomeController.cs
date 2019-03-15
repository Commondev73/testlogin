using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Testlogin.Models;
using Testlogin.ServiceReference1;

namespace Testlogin.Controllers
{
    public class HomeController : Controller
    {
        Service1Client sv = new Service1Client();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(ServiceReference1.LoginViewModel model)
        {
            if (model.Username != null && model.Password != null)
            {
                var login = sv.Getlogin(model);
                if (login.Any())
                {
                    return RedirectToAction("Account", "Home", new { userid = model.Username, pass = model.Password });
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is wrong");
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(ServiceReference1.RegisterViewModel model)
        {
            ServiceReference1.RegisterViewModel Check = new ServiceReference1.RegisterViewModel()
            {
                ID = model.ID.Trim(),
                email = model.email.Trim()
            };
            var chid = sv.Checkid(Check);
            var chemail = sv.Checkemail(Check);
            if (model.email != null && model.ID != null && model.PW != null && model.Name != null && model.Lastname != null)
            {
                if (chid == null && chemail == null)
                {
                    model.ID = model.ID.Trim();
                    model.Name = model.Name.Trim();
                    model.Lastname = model.Lastname.Trim();
                    model.email = model.email.Trim();
                    sv.Registerid(model);
                    return RedirectToAction("Login","Home");
                }
                else
                {
                    ModelState.AddModelError("", "ID or Email Not Avaialable");
                }

            }
            return View();
        }
        public JsonResult Check(string checkid,string checkemail)
        {
            ServiceReference1.RegisterViewModel Cid = new ServiceReference1.RegisterViewModel()
            {
                ID = checkid.Trim(),
                email = checkemail.Trim()
            };
            var Chuser = sv.Checkid(Cid);
            var Chemail = sv.Checkemail(Cid);
            int id = 0;
            int email = 0;
            if (Chuser != null)
            {
                id = 1;
            }
            if (Chemail != null)
            {
                email = 1;
            }
            //return checkuser != null ? Json(1) : Json(0);
            return Json(new {Rid = id, Remail= email});
        }
        [HttpGet]
        public ActionResult Account(string userid, string pass)
        {
            ServiceReference1.LoginViewModel user = new ServiceReference1.LoginViewModel()
            {
                Username = userid,
                Password = pass
            };
            var datauser = sv.Getlogin(user);
            ViewBag.data = datauser;
            //TempData["datauser"] = datauser;
            Session["userid"] = userid;
            Session["pass"] = pass;
            return View();
        }
        [HttpPost]
        public ActionResult Account(ServiceReference1.LoginViewModel user)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(ServiceReference1.RegisterViewModel model)
        {
            //ViewBag.datauser = TempData["datauser"];
            model.ID = Session["userid"].ToString();
            model.PW = Session["pass"].ToString();
            if (model.email != null && model.Name != null && model.Lastname != null)
            {
                model.Name = model.Name.Trim();
                model.Lastname = model.Lastname.Trim();
                model.email = model.email.Trim();
                sv.Updateid(model);
            }
            return RedirectToAction("Login", "Home");
        }
        [HttpGet]
        public ActionResult Deleteid()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Deleteid(ServiceReference1.LoginViewModel model)
        {
            model.Username = Session["userid"].ToString();
            if (model.Password != null)
            {
                if (model.Password.Equals(Session["pass"].ToString()))
                {
                    sv.Deleteid(model);
                    return RedirectToAction("Login", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Password is wrong");
                }
                
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
    }
}