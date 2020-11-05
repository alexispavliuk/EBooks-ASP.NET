using BLL.DTO;
using BLL.Interfaces;
using System.Web.Mvc;

namespace EBooks_ASP.NET.Controllers
{
    public class PollController : Controller
    {
        readonly IPollResultService pollResultService;

        public PollController(IPollResultService service)
        {
            pollResultService = service;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PollResult(PollResultDTO result)
        {
            if (ModelState.IsValid)
            {
                pollResultService.AddPollResult(result);
            }
            return View(result);
        }
    }
}