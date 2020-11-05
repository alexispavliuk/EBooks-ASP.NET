using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    /// <summary>
    /// service for working with news
    /// </summary>
    public class NewsService : INewsService
    {
        IUnitOfWork Database { get; set; }

        /// <summary>
        /// creating instance of news service
        /// </summary>
        /// <param name="unit"></param>
        public NewsService(IUnitOfWork unit)
        {
            Database = unit;
        }

        /// <summary>
        /// add news to db
        /// </summary>
        /// <param name="news">news</param>
        public void AddNews(NewsDTO news)
        {
            News newsToAdd = new News
            {
                Author = news.Author,
                Header = news.Header,
                Text = news.Text,
                Date = news.Date
            };
            Database.News.Create(newsToAdd);
            Database.Save();
        }

        /// <summary>
        /// get all news
        /// </summary>
        /// <returns> IEnumerable of news</returns>
        public IEnumerable<NewsDTO> GetNews()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<News>, List<NewsDTO>>(Database.News.GetAll());
        }

        /// <summary>
        /// get news by id
        /// </summary>
        /// <param name="id">id of news</param>
        /// <returns>newsdto</returns>
        public NewsDTO GetNewsById(int id)
        {
            var news = Database.News.Get(id);
            if (news == null)
            {
                throw new ArgumentException("There is no news with such id", "id");
            }
            return new NewsDTO
            {
                Author = news.Author,
                Text = news.Text,
                Header = news.Header,
                Date = news.Date
            };
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
