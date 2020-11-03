using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface INewsService
    {
        void AddNews(NewsDTO news);
        IEnumerable<NewsDTO> GetNews();
        void Dispose();
    }
}
