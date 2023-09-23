using Microsoft.AspNetCore.Mvc;

namespace MVCWebApp2.Controllers
{
    public class PartialViewController : Controller
    {
        //Get: PartialView
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are good friends";
            return View();  
        }
    }
}
