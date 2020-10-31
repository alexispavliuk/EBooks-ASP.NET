using DAL.Entities;
using System.Data.Entity;

namespace DAL.EF
{
    /// <summary>
    /// DbContext for working with database
    /// </summary>
    public class EBooksContext : DbContext
    {
        /// <summary>
        /// DnSet of news
        /// </summary>
        public DbSet<News> News { get; set; }

        /// <summary>
        /// DbSet of reviews
        /// </summary>
        public DbSet<Review> Reviews { get; set; }

        /// <summary>
        /// DbSet of PollResults
        /// </summary>
        public DbSet<PollResult> PollResults { get; set; }

        /// <summary>
        /// static constructor for setting initializer of database
        /// </summary>
        static EBooksContext()
        {
            Database.SetInitializer<EBooksContext>(new EBooksDbInitializer());
        }

        public EBooksContext(string connectionString) : base(connectionString) { }
    }
}
