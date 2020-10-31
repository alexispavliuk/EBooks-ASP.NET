using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.Repositories
{
    /// <summary>
    /// class that allows to work with reviews
    /// </summary>
    public class ReviewsRepository : IRepository<Review>
    {
        private readonly EBooksContext db;

        /// <summary>
        /// creates instance of reviews repository
        /// </summary>
        /// <param name="context">DbContext</param>
        public ReviewsRepository(EBooksContext context)
        {
            db = context;
        }

        /// <summary>
        /// get all reviews from database
        /// </summary>
        /// <returns>IEnumerable of reviews</returns>
        public IEnumerable<Review> GetAll()
        {
            return db.Reviews;
        }

        /// <summary>
        /// get concrete review by id
        /// </summary>
        /// <param name="id">id of review</param>
        /// <returns>review instance</returns>
        public Review Get(int id)
        {
            return db.Reviews.Find(id);
        }

        /// <summary>
        /// create new review
        /// </summary>
        /// <param name="item">instance of review to create</param>
        public void Create(Review item)
        {
            db.Reviews.Add(item);
        }

        /// <summary>
        /// change some review
        /// </summary>
        /// <param name="item">instance of review to change</param>
        public void Update(Review item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        /// <summary>
        /// delete some review by id
        /// </summary>
        /// <param name="id">id of review to delete</param>
        public void Delete(int id)
        {
            Review review = db.Reviews.Find(id);
            if (review != null)
                db.Reviews.Remove(review);
        }

        /// <summary>
        /// find some reviews by criteria
        /// </summary>
        /// <param name="predicate">func of criteria</param>
        /// <returns>IEnumerable of reviews</returns>
        public IEnumerable<Review> Find(Func<Review, bool> predicate)
        {
            return db.Reviews.Where(predicate).ToList();
        }
    }
}
