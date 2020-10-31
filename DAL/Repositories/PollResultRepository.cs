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
    public class PollResultsRepository : IRepository<PollResult>
    {
        private readonly EBooksContext db;

        /// <summary>
        /// creates instance of PollResults repository
        /// </summary>
        /// <param name="context">DbContext</param>
        public PollResultsRepository(EBooksContext context)
        {
            db = context;
        }

        /// <summary>
        /// get all poll results from database
        /// </summary>
        /// <returns>IEnumerable of poll results</returns>
        public IEnumerable<PollResult> GetAll()
        {
            return db.PollResults;
        }

        /// <summary>
        /// get concrete poll result by id
        /// </summary>
        /// <param name="id">id of poll result</param>
        /// <returns>poll result instance</returns>
        public PollResult Get(int id)
        {
            return db.PollResults.Find(id);
        }

        /// <summary>
        /// create new poll result
        /// </summary>
        /// <param name="item">instance of poll result to create</param>
        public void Create(PollResult item)
        {
            db.PollResults.Add(item);
        }

        /// <summary>
        /// change some poll result
        /// </summary>
        /// <param name="item">instance of poll result to change</param>
        public void Update(PollResult item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        /// <summary>
        /// delete some poll result by id
        /// </summary>
        /// <param name="id">id of poll result to delete</param>
        public void Delete(int id)
        {
            PollResult result = db.PollResults.Find(id);
            if (result != null)
                db.PollResults.Remove(result);
        }

        /// <summary>
        /// find some poll results by criteria
        /// </summary>
        /// <param name="predicate">func of criteria</param>
        /// <returns>IEnumerable of poll results</returns>
        public IEnumerable<PollResult> Find(Func<PollResult, bool> predicate)
        {
            return db.PollResults.Where(predicate).ToList();
        }
    }
}
