using BLL.DTO;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Entities;

namespace BLL.Services
{
    /// <summary>
    /// service for adding poll results to database
    /// </summary>
    public class PollResultService : IPollResultService
    {
        IUnitOfWork Database { get; set; }

        /// <summary>
        /// creating instance of service
        /// </summary>
        /// <param name="unit"></param>
        public PollResultService(IUnitOfWork unit)
        {
            Database = unit;
        }

        /// <summary>
        /// add poll result to db
        /// </summary>
        /// <param name="pollResult"></param>
        public void AddPollResult(PollResultDTO pollResult)
        {
            PollResult newResult = new PollResult
            {
                Name = pollResult.Name,
                Email = pollResult.Email,
                BornIn = pollResult.BornIn,
                IsMarried = pollResult.IsMarried
            };
            Database.PollResults.Create(newResult);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
