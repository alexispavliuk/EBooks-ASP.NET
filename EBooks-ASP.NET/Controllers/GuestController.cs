using BLL.DTO;
using BLL.Interfaces;
using System;
using System.Web.Mvc;

namespace EBooks_ASP.NET.Controllers
{
    public class GuestController : Controller
    {
        readonly IReviewService reviewService;

        public GuestController(IReviewService service)
        {
            reviewService = service;
        }

        public ActionResult Index()
        {
            return View(reviewService.GetReviews());
        }

        [HttpGet]
        public ActionResult AddReview()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddReview(ReviewDTO review)
        {
            if (ModelState.IsValid)
            {
                review.Date = DateTime.Now;
                reviewService.AddReview(review);
            }
            return RedirectToAction("Index");
        }

    }
}