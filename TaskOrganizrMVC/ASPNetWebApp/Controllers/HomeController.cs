using ASPNetWebApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ASPNetWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Contact([Bind(Include = "FromName,FromEmail,Subject,Message")] ContactEmail model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";

                ApplicationUserManager user = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var userId = user.FindByEmail("oxygen935@yahoo.gr");
                await user.SendEmailAsync(userId.Id, 
                                        "TaskOrganizr: " + model.Subject == null ? "" : model.Subject, 
                                        string.Format(body, model.FromName, model.FromEmail, model.Message));

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Your Blog.";

            return View();
        }

    }
}