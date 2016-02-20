using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeckDietSolution.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            int[] strengthOfHungerValues = {0,1,2,3,4,5,6,7,8,9,10};
            return View(strengthOfHungerValues);
        }

    }
}
