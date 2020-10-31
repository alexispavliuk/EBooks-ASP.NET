using DAL.Entities;
using System;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<News> News { get; }
        IRepository<Review> Reviews { get; }
        IRepository<PollResult> PollResults { get; }
        void Save();
    }
}
