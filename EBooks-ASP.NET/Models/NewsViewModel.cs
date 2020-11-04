﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBooks_ASP.NET.Models
{
    /// <summary>
    /// class of news viewmodel
    /// </summary>
    public class NewsViewModel
    {
        /// <summary>
        /// unique id of news
        /// </summary>
        public int NewsId { get; set; }

        /// <summary>
        /// name of author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// header of the news
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// text of news
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// date of news
        /// </summary>
        public DateTime Date { get; set; }
    }
}