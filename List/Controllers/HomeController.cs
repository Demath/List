using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using List.Models.Abstract;
using List.Models.Concrete;
using List.Models.Entities;

namespace List.Controllers {
    public class HomeController : Controller {

        private IInputInfoRepository repo;

        public HomeController(IInputInfoRepository repo) {
            this.repo = repo;
        }

        public ActionResult List() {
            return View();
        }

        public PartialViewResult GetData() {
            return PartialView(repo.InputInfoes);
        }

        public JsonResult Add(InputInfo inputInfo) {
            repo.AddInfo(inputInfo);
            return Json(repo.InputInfoes);
        }

        public JsonResult Delete(int id) {
            repo.DeleteInfo(id);
            return Json(repo.InputInfoes);
        }
    }
}