using System;
using System.ComponentModel.DataAnnotations;


namespace EBooks_ASP.NET.Models
{
    /// <summary>
    /// class of review viewmodel
    /// </summary>
    public class ReviewViewModel
    {
        /// <summary>
        /// unique id of review
        /// </summary>
        public int ReviewId { get; set; }

        /// <summary>
        /// name of author
        /// </summary>
        [Required(ErrorMessage = "Введіть будь ласка ім'я")]
        [RegularExpression("^[a-zA-Zа-яА-Я'][a-zA-Zа-яА-Я-' ]+[a-zA-Zа-яА-Я']", ErrorMessage = "Формат імені некоректний")]
        public string Author { get; set; }

        /// <summary>
        /// text of review
        /// </summary>
        [Required(ErrorMessage = "Введіть будь ласка текст відгуку")]
        public string Text { get; set; }

        /// <summary>
        /// date of review
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}