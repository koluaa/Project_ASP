using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using WebApplication.Models;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        static XmlSerializer formatter = new XmlSerializer(typeof(UserData));
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoadXml(HttpPostedFileBase file)
        {
            var userData = (UserData)formatter.Deserialize(file.InputStream);
            return View(userData);
        }
    }
}