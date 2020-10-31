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
    /// class that allows to work with news
    /// </summary>
    public class NewsRepository : IRepository<News>
    {
        private readonly EBooksContext db;

        /// <summary>
        /// creates instance of news repository
        /// </summary>
        /// <param name="context">DbContext</param>
        public NewsRepository(EBooksContext context)
        {
            db = context;
        }

        /// <summary>
        /// get all news from database
        /// </summary>
        /// <returns>IEnumerable of news</returns>
        public IEnumerable<News> GetAll()
        {
            return db.News;
        }

        /// <summary>
        /// get concrete news by id
        /// </summary>
        /// <param name="id">id of news</param>
        /// <returns>news instance</returns>
        public News Get(int id)
        {
            return db.News.Find(id);
        }
        
        /// <summary>
        /// create new news
        /// </summary>
        /// <param name="item">instance of news to create</param>
        public void Create(News item)
        {
            db.News.Add(item);
        }

        /// <summary>
        /// change some news
        /// </summary>
        /// <param name="item">instance of news to change</param>
        public void Update(News item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        /// <summary>
        /// delete some news by id
        /// </summary>
        /// <param name="id">id of news to delete</param>
        public void Delete(int id)
        {
            News news = db.News.Find(id);
            if (news != null)
                db.News.Remove(news);
        }

        /// <summary>
        /// find some news by criteria
        /// </summary>
        /// <param name="predicate">func of criteria</param>
        /// <returns>IEnumerable of news</returns>
        public IEnumerable<News> Find(Func<News, bool> predicate)
        {
            return db.News.Where(predicate).ToList();
        }
    }
}
