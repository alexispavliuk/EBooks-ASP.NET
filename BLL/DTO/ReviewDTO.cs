using System;

namespace BLL.DTO
{
    public class ReviewDTO
    {
        /// <summary>
        /// unique id of review
        /// </summary>
        public int ReviewId { get; set; }

        /// <summary>
        /// name of author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// text of review
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// date of review
        /// </summary>
        public DateTime Date { get; set; }
    }
}
