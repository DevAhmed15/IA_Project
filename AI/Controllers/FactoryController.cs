using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AI.Controllers
{
    public class FactoryController : Controller
    {
        //
        // GET: /Factory/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult admEditor()
        {
            return View();
        }
        public ActionResult admNews()
        {
            ViewBag.Message = "Admin section for news Edition & Deletion.";
            ViewBag.editor1_p = "“Nullam dapibus blandit orci, viverra gravida dui lobortis eget. Maecenas fringilla urna eu nisl scelerisque.”";
            ViewBag.editor1_name = "Chanel Iman";
            ViewBag.editor2_p = "“Nullam dapibus blandit orci, viverra gravida dui lobortis eget. Maecenas fringilla urna eu nisl scelerisque.”";
            ViewBag.editor2_name = "Chanel Iman";
            ViewBag.editor3_p = "“Nullam dapibus blandit orci, viverra gravida dui lobortis eget. Maecenas fringilla urna eu nisl scelerisque.”";
            ViewBag.editor3_name = "Chanel Iman";
            ViewBag.editor4_p = "“Nullam dapibus blandit orci, viverra gravida dui lobortis eget. Maecenas fringilla urna eu nisl scelerisque.”";
            ViewBag.editor4_name = "Chanel Iman";
            return View();
        }
        public ActionResult admEditedNews()
        {
            return View();
        }
        public ActionResult EdiNews()
        {
            return View();
        }

    }
}
