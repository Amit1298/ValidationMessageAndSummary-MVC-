using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidationMessageAndSummary.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string fullName,string Age,string Email)
        {
            if (fullName.Equals("") == true)
            {
                ModelState.AddModelError("fullName", "Full Name is Required !!");
            }
            if (Age.Equals("") == true)
            {
                ModelState.AddModelError("Age", "Age is Required !!");
            }
            if (Email.Equals("") == true)
            {
                ModelState.AddModelError("Email", "Email is Required !!");
            }
            if (ModelState.IsValid == true)
            {
                ViewData["SuccessMessage"] = "<script>alert('Data has been Submitted Succcessfully')</script>";
            }
            return View();
        }
    }
}