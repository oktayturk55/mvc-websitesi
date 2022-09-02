using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vs1.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }
    }
    //public ActionResult News()
    //{
    //    var degerler = a.haberlers.ToList();
    //    return View(degerler);
    //}
    //public ActionResult NewsDetail()
    //{
    //    return View();
    //}

}