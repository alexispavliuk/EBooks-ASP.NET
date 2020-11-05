using BLL.DTO;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface INewsService
    {
        void AddNews(NewsDTO news);
        IEnumerable<NewsDTO> GetNews();
        NewsDTO GetNewsById(int id);
        void Dispose();
    }
}
