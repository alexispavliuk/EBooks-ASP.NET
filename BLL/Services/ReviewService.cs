using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;


namespace BLL.Services
{
    /// <summary>
    /// service for working with reviews
    /// </summary>
    public class ReviewService : IReviewService
    {
        IUnitOfWork Database { get; set; }

        /// <summary>
        /// creating instance of service
        /// </summary>
        /// <param name="unit"></param>
        public ReviewService(IUnitOfWork unit)
        {
            Database = unit;
        }

        /// <summary>
        /// add new review to datatbase
        /// </summary>
        /// <param name="review">new review</param>
        public void AddReview(ReviewDTO review)
        {
            Review newReview = new Review
            {
                Author = review.Author,
                Text = review.Text,
                Date = review.Date
            };
            Database.Reviews.Create(newReview);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        /// <summary>
        /// get all reviews from database
        /// </summary>
        /// <returns>IEnumerable of reviews</returns>
        public IEnumerable<ReviewDTO> GetReviews()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Review, ReviewDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Review>, List<ReviewDTO>>(Database.Reviews.GetAll());
        }
    }
}
