using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleClub.Web.Controllers {
    public class DetailsController : Controller {
        public ActionResult IndividualLessons() {
            return View();
        }
        public ActionResult IndividualLessonsForChildren() {
            return View();
        }
        public ActionResult SkypeLessons() {
            return View();
        }
    }
}