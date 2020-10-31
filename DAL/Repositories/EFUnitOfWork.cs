using DAL.Interfaces;
using DAL.Entities;
using DAL.EF;
using System;

namespace DAL.Repositories
{
    /// <summary>
    /// main class for working with database
    /// </summary>
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly EBooksContext db;
        private NewsRepository newsRepository;
        private ReviewsRepository reviewsRepository;
        private PollResultsRepository pollResultsRepository;

        /// <summary>
        /// creating instance of EF unit of work
        /// </summary>
        /// <param name="connectionString">string of connection</param>
        public EFUnitOfWork(string connectionString)
        {
            db = new EBooksContext(connectionString);
        }

        /// <summary>
        /// get repo of news
        /// </summary>
        public IRepository<News> News
        {
            get
            {
                if (newsRepository == null)
                    newsRepository = new NewsRepository(db);
                return newsRepository;
            }
        }

        /// <summary>
        /// get repo of reviews
        /// </summary>
        public IRepository<Review> Reviews
        {
            get
            {
                if (reviewsRepository == null)
                    reviewsRepository = new ReviewsRepository(db);
                return reviewsRepository;
            }
        }

        /// <summary>
        /// get repo of poll results
        /// </summary>
        public IRepository<PollResult> PollResults
        {
            get
            {
                if (pollResultsRepository == null)
                    pollResultsRepository = new PollResultsRepository(db);
                return pollResultsRepository;
            }
        }

        private bool isDisposed = false;

        /// <summary>
        /// dispose method
        /// </summary>
        public void Dispose()
        {
            if (!isDisposed)
            {
                isDisposed = true;
                GC.SuppressFinalize(this);
            }
        }

        /// <summary>
        /// save changes method
        /// </summary>
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
