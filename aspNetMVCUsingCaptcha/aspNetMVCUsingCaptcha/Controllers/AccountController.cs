using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc.HtmlHelpers;
using aspNetMVCUsingCaptcha.Models;

namespace aspNetMVCUsingCaptcha.Controllers
{
    public class AccountController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var account = new Account();
            return View("Index",account);
        }
        [HttpPost]
        public ActionResult Save(Account account)
        {

            if (!this.IsCaptchaValid(""))
            {
                ViewBag.error = "Invalid Captcha";
                return View("Index",account);
            }
            else
            {
                ViewBag.account = account;
                return View("Success",account);
            }

        }
    }
}