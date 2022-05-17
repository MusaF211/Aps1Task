using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskPraktika1.Cantrollers
{
    public class HomeControllers : Controller
    {


        public ActionResult Index()
        {

                if (1 > 0)
                {
                    JsonResult jsonResult = new JsonResult("P129 Json Resun");
                return Json(new { name = "Musa", surname = "Dadashov" });
                }
                else
                {
                    ViewResult viewResult = new ViewResult();
                    viewResult.ViewName = "P129FirstView";

                    return View("P129FirstView");
                }
        }
    }
}
