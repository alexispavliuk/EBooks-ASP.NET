using BLL.Interfaces;
using System;
using System.Web.Mvc;


namespace EBooks_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        readonly INewsService newsService;

        public HomeController(INewsService service)
        {
            newsService = service;
        }

        public ActionResult Index()
        {
            return View(newsService.GetNews());
        }

        [HttpGet]
        public ActionResult ReadNews(int id)
        {
            try
            {
                return View(newsService.GetNewsById(id));
            }
            catch (ArgumentException)
            {
                return HttpNotFound();
            }
        }
    }
}