using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
    public class PollResultDTO
    {
        /// <summary>
        /// Unique id of result
        /// </summary>
        public int PollResultId { get; set; }

        /// <summary>
        /// Name of participant
        /// </summary>
        [Required(ErrorMessage = "Введіть будь ласка ім'я")]
        [RegularExpression("^[a-zA-Zа-яА-Я'][a-zA-Zа-яА-Я-' ]+[a-zA-Zа-яА-Я']", ErrorMessage = "Формат імені некоректний")]
        public string Name { get; set; }

        /// <summary>
        /// Unique email
        /// </summary>
        [Required(ErrorMessage = "Введіть будь ласка електронну пошту")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Формат електронної пошти некоректний")]
        public string Email { get; set; }

        /// <summary>
        /// True if participant is married
        /// </summary>
        [Required(ErrorMessage = "Оберіть будь ласка чи перебуваєте у шлюбі")]
        public bool IsMarried { get; set; }

        /// <summary>
        /// Year of birth
        /// </summary>
        [Required]
        [Range(1920,2020,ErrorMessage = "Недопустимий рік народження")]
        public int BornIn { get; set; }
    }
}
