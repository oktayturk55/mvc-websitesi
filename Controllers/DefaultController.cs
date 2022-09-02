using System.Linq;
using System.Web.Mvc;
using vs1.Models.Siniflar;

namespace vs1.Controllers
{
    public class DefaultController : Controller
    {
        Context a = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult DriverStanding()
        {
            var degerler = a.driverstandings.ToList();
            return View(degerler);
        }
        public ActionResult ConstructorStanding()
        {
            var degerler = a.constructorstandings.ToList();
            return View(degerler);
        }
        public ActionResult Test()
        {
            var degerler = a.tests.ToList();
            return View(degerler);
        }
        public ActionResult Blog()
        {
            var degerler = a.blogs.ToList();
            return View(degerler);
        }
        blogyorum by = new blogyorum();
        public ActionResult Blogdetail(int id)
        {
            by.deger1 = a.blogs.Where(x => x.ID == id).ToList();
            by.deger2 = a.yorumlars.Where(x => x.blogs.ID == id).ToList();
            
            return View(by);
        }
        [HttpGet]
        public PartialViewResult yorumyap()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult yorumyap(yorumlar y)
        {
            a.yorumlars.Add(y);
            a.SaveChanges();
            return PartialView();
        }

    }
}